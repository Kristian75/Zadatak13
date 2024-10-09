using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string poruka, naslov, buttons, ikona;

        private void btnOtvori_Click(object sender, EventArgs e)
        {

            string poruka = "Odaberite Da / Ne / Odustani";
            string naslov = "Naslovna linija Dijaloga za poruke";

            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon ikona = MessageBoxIcon.Information;

            DialogResult rez = MessageBox.Show(poruka, naslov, buttons, ikona);

            switch (rez) { 

                case DialogResult.Yes:

                txtIspis.Text = "Izabrali ste dugme DA";

                break;

            case DialogResult.No:

                txtIspis.Text = "Izabrali ste dugme NE";

                break;

            case DialogResult.Cancel:

                txtIspis.Text = "Izabrali ste dugme ODUSTANI";

                break;
            }
        }
    }
}
