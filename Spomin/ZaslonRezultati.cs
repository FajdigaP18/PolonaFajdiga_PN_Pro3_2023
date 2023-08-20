using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spomin
{
    public partial class ZaslonRezultati : Form
    {
        public ZaslonRezultati(List<Igralec> igralci)
        {
            InitializeComponent();
            Izpisrezultatov(igralci);
        }

        /// <summary>
        /// V tabelo razvrstimo imena desetih najboljših igralcev in njihove točke
        /// </summary>
        /// <param name="igralci"></param>
        private void Izpisrezultatov(List<Igralec> igralci)
        {
            int stevec = 1;
            foreach (Igralec igralec in igralci)
            {
                if (stevec < 11)
                {
                    Label uvrstitev = new Label();
                    Label uporabnik = new Label();
                    Label rezultat  = new Label();
                    uvrstitev.Text = stevec.ToString();
                    uvrstitev.Visible = true;
                    uvrstitev.Dock = DockStyle.Fill;
                    uporabnik.Text = igralec.UporabniskoIme;
                    uporabnik.Visible = true;
                    uporabnik.Dock = DockStyle.Fill;


                    rezultat.Text = igralec.Tocke.ToString();
                    rezultat.Visible = true;
                    rezultat.Dock = DockStyle.Fill;


                    rezultati.Controls.Add(uvrstitev, 0, stevec - 1);
                    rezultati.Controls.Add(uporabnik, 1, stevec - 1);
                    rezultati.Controls.Add(rezultat, 2, stevec - 1);
                    stevec++;

                }
            }
        }

        /// <summary>
        /// Z pritiskom na gumb Zapri zapremo zaslon ZaslonREzultati
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zapri_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
