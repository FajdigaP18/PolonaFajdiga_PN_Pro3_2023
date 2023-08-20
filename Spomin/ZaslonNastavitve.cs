using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Spomin
{
    public partial class ZaslonNastavitve : Form
    {
        private string[] dimenzije = new string[] { "4", "4"}; // dimenzije tabele, če ta ni podana
        private string imeMape = "Smejkoti"; // kot privzeto mapo s slikami si izberemo Smejkote
        private string imeHrtisca; 
        private Image hrbtisce = Properties.Resources.Snoopy4; // kot privzeto hrbtno stran karte si izberemo sliko Snoopy

        
        private List<string> imenaSlicic = new List<string>(); // seznam imen slikic


        private string potSlike = "";  
        private string uporabnik;  // ime uporabnik

        private List<Igralec> igralci; // seznam igralcev

        private string zacetnaPot = $"{Application.StartupPath}\\"; // pot na kateri je bil pognana aplikacija
        public ZaslonNastavitve(string ime, List<Igralec> seznam) 
        {
            InitializeComponent();
            uporabnik = ime; 
            igralci = seznam;
        }

        /// <summary>
        /// Izberemo dimenzije igralne površine.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dimenzijeIgralnePovrsine_SelectedIndexChanged(object sender, EventArgs e)
        {   
            string vrednost = comboBox1.Text; // preberemo katero dimenzijo smo izbrali
            dimenzije = vrednost.Split(':');
            shrani.Enabled = false;
        }

        /// <summary>
        /// Z gumbom začni odpremo novo okno ZaslonIgra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zacni_Click(object sender, EventArgs e)
        {
            ZaslonIgra zaslonIgra = new ZaslonIgra(int.Parse(dimenzije[0]), int.Parse(dimenzije[1]), imeMape, hrbtisce, uporabnik, igralci);
            zaslonIgra.Show();
            // zapremo zaslon  ZaslonNastavitve
            Close();
        }

        /// <summary>
        /// Izberemo temo sličic.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void temaSlicic_SelectedIndexChanged(object sender, EventArgs e)
        {
            imeMape = temaSlicic.Text; // izberemo temo sličic
            shrani.Enabled = false;
        }

        /// <summary>
        /// Z gumbom Zapri zapremo okno ZaslonNastavitev.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zapri_Click(object sender, EventArgs e)
        {
            // zapremo zaslon ZaslinNastavitve
            Close();
        }

        /// <summary>
        /// Z gumbom Naloži naložimo sliko tipa .jpg ali png  in jo prikažemo v prostorcku za sliko.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nalozi_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg|*.jpg|png|*.png";
                // prikažemo izbrano sliko (sliko ki jo želimo naložiti/uporabiti)
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    potSlike = dialog.FileName;
                    naloziSliko.Image = new Bitmap(potSlike);
                    naloziSliko.Visible = true;
                    naloziSliko.SizeMode = PictureBoxSizeMode.StretchImage;
                    naloziSliko.Size = new Size(200, 200);
                }
                shrani.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Poiskusite naložiti drugo sliko.");
            }

        }

        /// <summary>
        /// S klikom na gumb Shrani shranimo sliko, ki smo jo naložili.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shrani_Click(object sender, EventArgs e)
        {
            try
            {
                // shranimo sliko ki smo jo prikazali oz naložili v aplikacijo 
                string imeSlike = Path.GetFileName(potSlike);
                imenaSlicic.Add(potSlike);
                File.Copy(potSlike, Path.Combine(zacetnaPot + @"Hrbtna stran\", imeSlike), true);
                // ob uspešni naložitvi slike se prikaže sporočilo o uspehu
                MessageBox.Show("Slika je  uspešno shranjena!!");
                shrani.Enabled = false; // onemogočimo gumb za shranjevanje
                if (!izberiHrbtsce.Items.Contains(imeSlike))
                {
                    // sliko ki smo jo shranili dodamo na  seznam hrbtne strani sličic
                    izberiHrbtsce.Items.Add(imeSlike);
                }

            }
            // Slike nismo uspešno naložili     
            catch
            {
                MessageBox.Show("Sliko morate prvo naložiti");
            }

        }

        /// <summary>
        /// V seznamu izberemo naslov hrbtne strani sličice in jo prikažemo na zaslonu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void izberiHrbtsce_SelectedIndexChanged(object sender, EventArgs e)
        {
            imeHrtisca = izberiHrbtsce.Text;  // izberemo hrbtišče
            hrbtisce = Image.FromFile(zacetnaPot + $"Hrbtna stran\\{imeHrtisca}"); // poiscemo sliko (hrbtišče)
            naloziSliko.Image = hrbtisce; // prikažemo sliko (hrbtišče)
            shrani.Enabled = false;

        }

        /// <summary>
        /// Ko poženemo zaslon zaslonNastavitve moramo prvo pogledati katere hrbtne stranisličic imamo na razpolago.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZaslonNastavitve_Load(object sender, EventArgs e)
        {
            string[] imena = Directory.GetFiles(zacetnaPot + @"Hrbtna stran"); // vse sličice (elementi) v datoteki 'Hrbtna stran'
            foreach (string ime in imena)
            {
                // v seznam hrbtnih strani kartic shranimo ime sličice
                izberiHrbtsce.Items.Add(Path.GetFileName(ime));
            }
            shrani.Enabled = false;
        }
    }
}
