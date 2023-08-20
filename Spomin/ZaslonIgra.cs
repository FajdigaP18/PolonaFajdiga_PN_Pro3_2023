using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;


namespace Spomin
{
    public partial class ZaslonIgra : Form
    {
        List<Image> slikice = new List<Image>(); // seznam slik
        // https://stackoverflow.com/questions/18540325/how-to-dynamically-produce-pictureboxes-via-button-click
        private List<PictureBox> karte = new List<PictureBox>(); // seznam skatelj slikic
        private List<int> postavitve1 = new List<int>();
        private int tocke; // stevilo odkritih parov
        private int odkritaSlikca1; // katera slikca je odkrita
        private int odkritaSlikca2; // druga odkrita slikca
        private PictureBox drugaKarta; // prva odkrita karta (PictureBox)
        private PictureBox prvaKarta; // druga odkrita karta (PictureBox)

        private int stParov; // stevilo parov

        private int sekunde; // stetje sekund
        private int minute; // stetje minut


        private Image hrbtisce = Properties.Resources.Snoopy4;

        private string pot = @"Rezultati.json"; // pot kjer bomo shranili rezultate
        private List<Igralec> igralci; // seznam igralcev 

        private Igralec igralec = new Igralec(); // nov igralec

        private string zacetnaPot = $"{Application.StartupPath}\\"; // pot v katerem je zagnana aplikacija



        public ZaslonIgra(int stStolpcev, int stVrstic, string imeMape, Image slika, string ime, List<Igralec> seznam)
        {
            InitializeComponent();
            igralci = seznam;
            stParov = stStolpcev * stVrstic / 2;
            tocke = 0; // stejemo koliko parov smoze odkrili
            sekunde = 0;
            minute = 0;
            hrbtisce = slika; // nastavimo hrbtno stran kartic
            igralec.UporabniskoIme = ime; // Uporabniško ime uporabnika
            DodajanjeKart(zacetnaPot + imeMape); // Na povezavi ki jopodana dodamo slikice v seznam slikice
            MesanjeKart(stParov);  // premesamo kartice (seznam nakljućno razvrščenih parov števil)
            timer2.Start(); // začnemo s štopanjem
            Postavitev(stStolpcev, stVrstic); // Ustvarimo tabelo in ji dodamo karte (slikice)
        }

        /// <summary>
        /// Odkrivanje sličic 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Odkrij_slicico(object sender, EventArgs e)
        {
            // Nismo še odkrili sličice
            if (prvaKarta != null && drugaKarta != null)
            {
                return;
            }
            // 
            PictureBox ploscica = sender as PictureBox;


            if (ploscica == null)
            {
                return;
            }
            int element = postavitve1.ElementAt(karte.IndexOf(ploscica));
            if (ploscica.Image == slikice.ElementAt(element))
            {
                return;
            }
            if (prvaKarta == null)
            {
                prvaKarta = ploscica;
                odkritaSlikca1 = element;
                prvaKarta.Image = slikice.ElementAt(element);
                return;
            }
            // odkrijemo drugo karto
            drugaKarta = ploscica;
            odkritaSlikca2 = element;
            drugaKarta.Image = slikice.ElementAt(element);

            // dobili smo par
            if (odkritaSlikca1 == odkritaSlikca2)
            {
                timer3.Start();
                // dobimo točko
                tocke = tocke + 1;
                // preverimo ali smo zmagali
                AliSiZmagal();

            }
            // obrnemo nazaj ploščico,tako da je vidna rbtna stran
            else
            {
                timer1.Start();
            }

        }

        /// <summary>
        /// Obrnemo ploščico če sta karti, ki jih kliknemo različni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_odpriPloscico_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            prvaKarta.Image = hrbtisce;
            drugaKarta.Image = hrbtisce;
            // karti ki smo jih odkrili nazaj postavimo na null
            prvaKarta = null;
            drugaKarta = null;

        }

        /// <summary>
        /// Pri odkritju para za nekaj sekund prikažemo sliki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void par(object sender, EventArgs e)
        {
            // karti skrijemo
            drugaKarta.Visible = false;
            drugaKarta.Image = hrbtisce;
            prvaKarta.Visible = false;
            prvaKarta.Image = hrbtisce;
            // karti ki smo jih odkrili nastavimo na null
            prvaKarta = null;
            drugaKarta = null;
            timer3.Stop();
        }

        /// <summary>
        /// Preverimo ali smo zamgalli in izpišemo sporoilo ter prikažemo rezultate
        /// </summary>
        private void AliSiZmagal()
        {
            // zmagamo, ko poiščemo vse pare, izpiše se nam sporočilo
            if (tocke == stParov)
            {
                timer2.Stop();
                // glede na rezultat in stevilo parov dodelimo toćke.
                //double vmesnizracun = ((sekunde + (minute * 60.0)) / stParov * 1.0)  * 100;
                double vmesnizracun = ((sekunde + (16 - stParov) + (minute * 60.0)) / stParov * 1.0) * 100; // povprečni čas da dkrijemo par
                igralec.Tocke = (int) vmesnizracun ;
                igralci.Add(igralec);
                MessageBox.Show($"ČESTITKE {igralec.UporabniskoIme}! :) Našel si vse pare. \n Točke, k si jih osvojil: {igralec.Tocke}.");
                // rezultate shranimo
                DodajamoVRezultate();
                
            }
        }


        /// <summary>
        /// Dodajamo slike iz mape v seznam slikice
        /// </summary>
        /// <param name="ime">ime mape v kaeri so sranjene slike *.jpg</param>
        private void DodajanjeKart(string ime)
        {

            for (int i = 1; i < 17; i++)
            {
                slikice.Add(Image.FromFile($"{ime}/slika{i}.jpg"));
            }
        }

        /// <summary>
        /// Premešamo "sličice" glede na število parov.
        /// </summary>
        private void MesanjeKart(int stParov)
        {
            int[] pomozna = new int[stParov];
            for (int k = 0; k < stParov; k++)
            {
                pomozna[k] = 0;
                postavitve1.Add(k);
                postavitve1.Add(k);
            }
            // Naključno razporejanje števil v danem seznamu
            postavitve1 = postavitve1.OrderBy(x => Guid.NewGuid()).ToList();

        }

        /// <summary>
        /// Postavitev kartic po "igralni povrsini" (tabela, celice tabele so slikice)
        /// </summary>
        /// <param name="stStolpcev">stevilo stolpcev</param>
        /// <param name="stVrstic">stevilo vrstic</param>
        private void Postavitev(int stStolpcev, int stVrstic)
        {
            TableLayoutPanel igralnaPostavitev = new TableLayoutPanel();
            // Dodamo novo tabelo s slikicami 
            tableLayoutPanel1.Controls.Add(igralnaPostavitev,0,1);

            igralnaPostavitev.ColumnCount = stStolpcev;
            igralnaPostavitev.RowCount = stVrstic;
            igralnaPostavitev.Dock = DockStyle.Fill;
            igralnaPostavitev.AutoSize = true;
            igralnaPostavitev.BackgroundImage = Properties.Resources.menu_3;
            igralnaPostavitev.BackgroundImageLayout = ImageLayout.Stretch;


            // v celice tabele dodamo slikico
            for (int i = 0; i < stStolpcev; i++)
            {
                for (int j = 0; j < stVrstic; j++)
                {
                    // celice tabele ima lastnost PictureBox v katero dodamo slikco (hrbtna stran slikic)
                    PictureBox slika = new PictureBox();
                    slika.Image = hrbtisce;
                    igralnaPostavitev.Controls.Add(slika, i, j);
                    slika.Size = new Size(150, 150);
                    slika.Visible = true;
                    slika.SizeMode = PictureBoxSizeMode.StretchImage;
                    karte.Add(slika);
                    // dodamo dogodek
                    slika.Click += new EventHandler(Odkrij_slicico);

                }
            }
            
        }

        /// <summary>
        /// Čas igranja (minute:sekunde)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            sekunde++;
            if (sekunde >= 60)
            {
                minute++;
                sekunde = 0;
            }
            string min = "", sek = "";
            if (sekunde < 10)
            {
                sek = $"0{sekunde}";
            }
            if (minute < 10)
            {
                min = $"0{minute}";
            }
            if (minute > 10)
            {
                min = $"{minute}";
            }
            if (sekunde > 10)
            {
                sek = $"{sekunde}";
            }
            // Izpišemo čas
            LabelSek.Text = sek;
            LabelMn.Text = min;
        }


        /// <summary>
        /// Podatke (slovar podatkov igralci ) shranimo v json datoteko 'rezultati.json' 
        /// </summary>
        private void Shranimo()
        {
            string json = JsonSerializer.Serialize(igralci);
            File.WriteAllText(pot, json);
        }

        /// <summary>
        /// Izpis reziltatov v listBoxu
        /// </summary>
        private void DodajamoVRezultate()
        {
            igralci = igralci.OrderBy(x => x.Tocke).ToList();
            // rezultate shranimo v json datoteko
            Shranimo();
            // prikažemo rezultate na zaslonu
            ZaslonRezultati rezultati = new ZaslonRezultati(igralci);
            rezultati.Show();
            // zapremo zaslon ZaslonIgra
            Close();
        }

    }
}
