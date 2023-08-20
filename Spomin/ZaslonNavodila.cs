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
    public partial class ZaslonNavodila : Form
    {
        public ZaslonNavodila()
        {
            InitializeComponent();
        }

        /// <summary>
        /// S klikom na gumb nazaj zapremo okno Navodila.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nazaj_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
