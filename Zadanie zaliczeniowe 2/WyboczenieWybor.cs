using System;
using System.Windows.Forms;

namespace Zadanie_zaliczeniowe_3
{
    public partial class WyboczenieWybor : Form
    {

        #region KOMPONENTY POCZATKOWE
        public WyboczenieWybor()
        {
            InitializeComponent();     
        }


        private void WyboczenieWybor_Load(object sender, EventArgs e)
        {
 
        }
        #endregion


        //przekazywanie wartosci do innej formy
        private string myVal_private;


        public string MyVal_public
        {
            get { return myVal_private; }
            set { myVal_private = value; }
        }
     
        //przycisk OK z charaklterystyka "OK"
        public void WyboczenieOK_Click(object sender, EventArgs e)
        {
            Opcja();
            this.Close();
        }

        //zapisanie wartosci parametrow wyboczeniowych
        private void Opcja()
        {
            if (WyboczenieRadio1.Checked) { MyVal_public = "1,0"; }
            if (WyboczenieRadio2.Checked) { MyVal_public = "0,5"; }
            if (WyboczenieRadio3.Checked) { MyVal_public = "0,7"; }
            if (WyboczenieRadio4.Checked) { MyVal_public = "2,0"; }
            if (WyboczenieRadio5.Checked) { MyVal_public = "1,0"; }
        }

        #region RADIO BUTTONS

        private void WyboczenieRadio1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WyboczenieRadio2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void WyboczenieRadio3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WyboczenieRadio4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WyboczenieRadio5_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
