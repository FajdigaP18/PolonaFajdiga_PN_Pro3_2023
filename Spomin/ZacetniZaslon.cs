using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Spomin
{
    public partial class ZacetniZaslon : Form
    {
        private List<Igralec> igralci; // seznam igralcev
        private bool load = true; // preverimo ali smo pognali program, ko ga prvič poženemos se spremenjljivka dobi vrednost false
        private string pot = @"Rezultati.json"; // pot kjer so shranjeni rezultati
        public ZacetniZaslon()
        {
            InitializeComponent();
            if (load)
            {
                igralci = LoadJson();
            }


        }


        /// <summary>
        /// S pritiskom na gumbzacni seodpre novo okno zaslon igra na katerem lahko zacnemo z iganjem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbZacni_Click(object sender, EventArgs e)
        {
            
            ZaslonIgra zaslonIgra = new ZaslonIgra(4, 4, "Smejkoti", Properties.Resources.Snoopy4, uporabnik.Text, igralci);
            zaslonIgra.Show();
        }


        /// <summary>
        /// S pritiskom na gumb Nastavitve odpre okno zalsonNastavitve
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbNadtavitve_Click(object sender, EventArgs e)
        {
            ZaslonNastavitve zaslonNastavitve =  new ZaslonNastavitve(uporabnik.Text, igralci);
            zaslonNastavitve.Show();

        }

        /// <summary>
        /// S pritiskom na gumb Navodila odpremo zaslon ZaslonNavodila
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumbNavodila_Click(object sender, EventArgs e)
        {
            ZaslonNavodila navodila = new ZaslonNavodila();
            navodila.Show();
        }

        /// <summary>
        /// Iz datoteke ki je na povezavi pot, preberemo in vrnemo rezultate v seznamu. Če datoteka ne obstataja vrnemo prazen seznam.
        /// </summary>
        /// <returns></returns>
        public List<Igralec> LoadJson()
        {
            load = false; // podatke smo prebrali 
            if (File.Exists(pot))
            {
                using (StreamReader r = new StreamReader(pot))
                {
                    string json = r.ReadToEnd();
                    List<Igralec> podatki = JsonSerializer.Deserialize<List<Igralec>>(json);
                    List<Igralec> podatki2 = podatki.OrderBy(x => x.Tocke).ToList(); // podatke uredimo naraščajoče uredimo
                    return podatki2;
                }
            }
            // datoteka ne obstaja zato vrnemo prazen seznam 
            else
            {

                return new List<Igralec>();
            }
        }

    }
}
