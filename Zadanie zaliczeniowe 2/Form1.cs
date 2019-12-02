using System;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace Zadanie_zaliczeniowe_3
{
    public partial class Form1 : Form
    {

        #region ZALADOWANIE PROGRAMU
        //na starcie Form1 lista z parametramy betonow sie zaladuje 
        public Form1()
        {
            InitializeComponent();
            fillComboboxFcd();
            fillComboboxFyd();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        #endregion


        #region WYPELNIENIE COMBOBOXOW Z BAZY DANYCH

        //wypelnienie comboboxow wartosciami z bazy danych
        public void fillComboboxFcd()
        {
            string path = Path.GetFullPath(Environment.CurrentDirectory);
            string databaseName = "LocalTabBet.mdf";
            SqlConnection connectFcd = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="+path+@"\"+databaseName+";Integrated Security=True");


            string sql = "select * from TablicaBet";
            SqlCommand cmd = new SqlCommand(sql, connectFcd);
            SqlDataReader myReader;
                try
            {
                connectFcd.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sname = myReader.GetString(1);
                    FcdComB.Items.Add(sname);
                }
            }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

        }

 

        public void fillComboboxFyd()
        {
            string path = Path.GetFullPath(Environment.CurrentDirectory);
            string databaseName = "LocalMetTab.mdf";
            SqlConnection connectFyd = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="+path+@"\"+databaseName+";Integrated Security=True");


            string sql = "select * from TablicaStali";
            SqlCommand cmd = new SqlCommand(sql, connectFyd);
            SqlDataReader myReader;
            try
            {
                connectFyd.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sname = myReader.GetString(1);
                    FydComB.Items.Add(sname);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #endregion


        # region Wymiary i wlasciwosci geometryczne KEY_PRESS

        private void DlugoscTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TylkoDouble(sender, e, DlugoscTB);
        }

        private void SzerokoscTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TylkoDouble(sender, e, SzerokoscTB);
        }

        private void Fi_zbrojTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TylkoDouble(sender, e, Fi_zbrojTB);
        }

        private void OtulinaTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TylkoDouble(sender, e, OtulinaTB);
        }

        private void Fi_strzemTB_KeyPress(object sender, KeyPressEventArgs e)
        {
           //TylkoDouble(sender, e);
        }

        private void WysTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TylkoDouble(sender, e, WysTB);
        }

        private void betaTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TylkoDouble(sender, e, betaTB);
        }
        #endregion


        #region Wymiary i wlasciwosci do wyboru z listy COMBOBOX

        private void FcdComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = Path.GetFullPath(Environment.CurrentDirectory);
            string databaseName = "LocalTabBet.mdf";
            SqlConnection connectFcd = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");


            string sql = "select * from TablicaBet where NazwaBetonu = '" + FcdComB.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, connectFcd);
            SqlDataReader myReader;

            try
            {
                connectFcd.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    //pobieranie wartosci string z sql i wpisanie jej to textboxa odpowiadajacego za fcd
                    string fcd_property = myReader.GetString(2);
                    fcdTB.Text = fcd_property;
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void FydComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = Path.GetFullPath(Environment.CurrentDirectory);
            string databaseName = "LocalMetTab.mdf";
            SqlConnection connectFyd = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");


            string sql = "select * from TablicaStali where NawaSta = '" + FydComB.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, connectFyd);
            SqlDataReader myReader;

            try
            {
                connectFyd.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string fyd_property = myReader.GetString(2);
                    fydTB.Text = fyd_property;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }


        private void FcdComBTest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Fi_zbrojComB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Fi_strzemComB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion


        #region Sily Zewnetrzne KEY_PRESS

        private void MEd1TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TylkoDouble(sender, e, MEd1TB);
        }

        private void MEd2TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TylkoDouble(sender, e, MEd2TB);
        }

        private void NEdTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TylkoDouble(sender, e, NEdTB);
        }

        #endregion


        #region Materialy  dla KEY_PRESS

        private void fcdTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            TylkoDouble(sender, e, fcdTB);

        }

        private void fydTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TylkoDouble(sender, e, fydTB);
        }
        #endregion


        #region Wybor wspolczynnika beta

        WyboczenieWybor OknoWyboczenie = new WyboczenieWybor();


        private void WyborBetaButton_Click(object sender, EventArgs e)
        {
            WyboczenieWybor Wybor = new WyboczenieWybor();
            if(Wybor.ShowDialog() == DialogResult.OK)
            {
                betaTB.Text = Wybor.MyVal_public;
            } 
        }


        #endregion


        #region Funkcje Pomocnicze i konwersje na double

        private void TylkoDouble(object sender, KeyPressEventArgs e, TextBox name)
        {
            char ch = e.KeyChar;

            //zabronione jest wprowadzenie wielu prtzecinkow (kod ASCII dla  ',' wynosi 44)
            if (ch == 44 && (name.Text.IndexOf(',') != -1) )
            {
                e.Handled = true;
                return;
            }

            //spr czy text nie jest liczbą lub backspacem lub kropką wtedy sie nic nie wpisze to boxa
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44 )
            {
                e.Handled = true;
            }

        }

        // funkcja sprawdzajaca czy liczby sa > od 0 i wyswietla gdzie sie popelnilo blad
        private void Dodatnie(double x, TextBox name, string nazwa_bledu)
        {
            if (x <= 0)
            {
                name.Text = "0,01";
                MessageBox.Show("Proszę wprowadzić liczbę większą od zera dla wartości: " + nazwa_bledu);
            }
        }
  

        /// <summary>
        /// te funkcje konwertuja textboxy na double tak zeby za kazdym razem nie trzeba bylo ich kowertowac
        /// </summary>
        /// <returns></returns>
        private double Dlug()
        {
            double dlug = Convert.ToDouble(DlugoscTB.Text);
            Dodatnie(dlug, DlugoscTB, "h");
            return dlug;
        }

        private double Szer()
        {
            double szer = Convert.ToDouble(SzerokoscTB.Text);
            Dodatnie(szer, SzerokoscTB, "b");
            return szer;
        }

        private double Wys()
        {
            double wys = Convert.ToDouble(WysTB.Text);
            Dodatnie(wys, WysTB, "H");
            return wys;
        }

        private double Otulina()
        {
            double otulina = Convert.ToDouble(OtulinaTB.Text);
            Dodatnie(otulina, OtulinaTB, "a");
            return otulina;
        }

        private double Beta()
        {
            double beta = Convert.ToDouble(betaTB.Text);
            Dodatnie(beta, betaTB, "beta");
            return beta;
        }

        private double Fcd()
        {
            double fcd = Convert.ToDouble(betaTB.Text);
            Dodatnie(fcd, fcdTB, "fcd");
            return fcd;
        }

        private double Fyd()
        {
            double fyd = Convert.ToDouble(fydTB.Text);
            Dodatnie(fyd, fydTB, "fyd");
            return fyd;
        }

        private double MEd1_conv()
        {
            double med1 = Convert.ToDouble(MEd1TB.Text);
            Dodatnie(med1, MEd1TB, "MEd1");
            return med1;
        }

        private double MEd2_conv()
        {
            double med2 = Convert.ToDouble(MEd2TB.Text);
            Dodatnie(med2, MEd2TB, "MEd2");
            return med2;
        }

        private double NEd_conv()
        {
            double ned = Convert.ToDouble(NEdTB.Text);
            Dodatnie(ned, NEdTB, "NEd");
            return ned;
        }

        //konwersja zbrojenie na double oraz zamiana [mm] na [m]
        private double Fi_zbroj_CB_conv()
        {
            double Fi_zbroj = Convert.ToDouble(Fi_zbrojComB.Text) * 0.001;
            return Fi_zbroj;
        }

        private double Fi_strzem_CB_conv()
        {
            double Fi_strzem = Convert.ToDouble(Fi_strzemComB.Text) * 0.001;
            return Fi_strzem;
        }

        #endregion


        #region Wymiary geometryczne obliczone

        //Obliczenie a1
        private double oblicz_a_1()
        {
            return Otulina()+ 0.5* Fi_zbroj_CB_conv();
        }

        //a2
        public double oblicz_a_2()
        {
            return Otulina() + Fi_strzem_CB_conv() + (0.5 * Fi_zbroj_CB_conv() );
        }

        //d
        public double oblicz_d()
        {
            return Dlug() - oblicz_a_1();
        }

        //xeff - zasieg efektywnej strefy sciskania
        public double oblicz_x_eff_lim()
        {
            return 0.5 * oblicz_d();
        }

        //Iy - moment bezwladnosci
        public double oblicz_I_y()
        {
            return (Szer() * Math.Pow(Dlug(), 3)) / 12;
        }

        //A - pole powierzchni
        public double oblicz_A()
        {
            return Szer() * Dlug();
        }

        //i - promien bezwladnosci
        public double oblicz_i()
        {
            return Math.Sqrt(oblicz_I_y() / oblicz_A() );
        }
        
         //L0
        public double oblicz_L_0()
        {
            return Wys() * Beta();
        }
        
        #endregion


        #region Obliczenia statyczne - etap 1
        
        //e0
        public double oblicz_e_0()
        {
            double e_0 = ( MEd1_conv() / NEd_conv() ) + oblicz_L_0() / 400;

            if (e_0 <= Math.Max(Wys() / 30, 0.02))
            {
                return Math.Max(Wys() / 30, 0.02);
            }
            else
            {
                return e_0;
            }
        }


        //es1
        public double oblicz_e_s1()
        {
            return 0.5 * Dlug() - oblicz_a_1() + oblicz_e_0();
        }


        //es2
        public double oblicz_e_s2()
        {
            if (oblicz_e_s1() >= ( oblicz_d() - oblicz_a_1() ))
            {
                return oblicz_e_s1() - oblicz_d() + oblicz_a_2();
            }
            return oblicz_d() - oblicz_e_s1() - oblicz_a_2();
        }

        //As min
        public double oblicz_A_smin()
        {
            return Math.Max(5 * NEd_conv() / Fyd(), 10 * oblicz_A() );
        }


        //porownanie etap 1
        public bool porownanie1()
        {
            double A_s2 = (NEd_conv() * oblicz_e_s1() - 1000 * Fcd() * Szer() * oblicz_x_eff_lim() * 
                        (oblicz_d() - 0.5 * oblicz_x_eff_lim() )) / (1000 * Fyd() * (oblicz_d() - oblicz_a_2() )) * 10000;

            double A_smin = Math.Max(5 * NEd_conv() / Fyd(), 10 * oblicz_A() );

            if (A_s2 <= A_smin)
            {
                return true;
            }
            return false;
        }


        //porownanie etap 2
        public bool porownanie2(double x_eff)
        {
            if (x_eff <= 2 * oblicz_a_2() )
            {
                return true;
            }
            return false;
        }


        //porownanie etap 3
        public bool porownanie3(double A_s1)
        {
            if (A_s1 < oblicz_A_smin() )
            {
                return true;
            }
            return false;
        }
        #endregion


        #region Obliczenia statyczne - etap 2

        private double[] GlownaFunkcja()
        {
            double [] wyniki =  {0, 0};

            //punkt algorytmu 6.
            double oblicz_A_s1;
            double oblicz_A_s2;


            oblicz_A_s2 = ( NEd_conv() * oblicz_e_s1()  - 1000 * Fcd() * Szer() * oblicz_x_eff_lim()  * ( oblicz_d() - 0.5 * oblicz_x_eff_lim()) )
                           / (1000 * Fyd() * (oblicz_d() - oblicz_a_2()) ) * 10000;
        
 
            double x_eff = oblicz_d() - Math.Sqrt(Math.Pow(oblicz_d(), 2) - ((2 * (NEd_conv() * oblicz_e_s1() - 0.1 * Fyd() * oblicz_A_s2 * (oblicz_d() - oblicz_a_2()))) /
                            (Fcd() * Szer() * 1000)));
            

            if ( oblicz_A_s2 <= oblicz_A_smin() )
            {
             
                //obliczenie porownianie2
                bool bool_porown_2 = porownanie2(x_eff);


                //punkt algorytmu 6.A
                if (bool_porown_2 == false )
                {
                    oblicz_A_s1 =  (Fcd() * 1000 * Szer() * x_eff - NEd_conv() ) / (1000 * Fyd()) * 10000 + oblicz_A_s2;

                    //obliczenie porownianie3
                    bool bool_porown_3 = porownanie3(oblicz_A_s1);

                    if (bool_porown_3 == true)
                    {
                        wyniki[0] = oblicz_A_smin();
                        wyniki[1] = oblicz_A_smin();
                    }
                    else
                    {
                        wyniki[0] = oblicz_A_s1;
                        wyniki[1] = oblicz_A_smin();
                    }
                }


                //punkt algorytmu 6.B
                else if (bool_porown_2 == true)
                {
                    oblicz_A_s1 =  ((NEd_conv() / (1000 * Fyd())) * (oblicz_e_s1()/ (oblicz_d() - oblicz_a_2() ) - 1)) * 10000;

                    bool bool_porown_3 = porownanie3(oblicz_A_s1);
                    if (bool_porown_3 == true)
                    {
                        wyniki[0] = oblicz_A_smin();
                        wyniki[1] = oblicz_A_smin();
                    }
                    else
                    {
                        wyniki[0] = oblicz_A_s1;
                        wyniki[1] = oblicz_A_smin();
                    }
                }
                
            }

            if (oblicz_A_s2 > oblicz_A_smin())
            {
                oblicz_A_s1 = (((1000 * Fcd() * Szer() * x_eff - NEd_conv()) / (Fyd() * 1000)) * 10000) + oblicz_A_s2;

                // punkt 7.A
                if (oblicz_A_s1 >= 0)
                {
                    wyniki[0] = Math.Max(oblicz_A_s1, oblicz_A_smin() );
                    wyniki[1] = oblicz_A_smin();
                }

                //punkt 7.B
                if (oblicz_A_s1 < 0)
                {
                    oblicz_A_s1 = oblicz_A_smin();

                    x_eff = oblicz_a_2() + Math.Sqrt(Math.Pow(oblicz_a_2(), 2) + (2 * NEd_conv() * oblicz_e_s2() ) / (1000 * Fcd() * Szer() ));

                    if (x_eff > oblicz_d() )
                    {
                        x_eff = oblicz_d();

                        oblicz_A_s2 = ((NEd_conv() * oblicz_e_s1() - 0.5 * 1000 * Fcd() * Szer() * oblicz_d() * oblicz_d() )
                            / (1000 * Fyd() * (oblicz_d() - oblicz_a_2() ))) * 10000;

                        oblicz_A_s1 = (((NEd_conv() - 1000 * Fcd() * Szer() * oblicz_d() ) / (1000 * Fyd() ))) * 10000 - oblicz_A_s2;

                        wyniki[0] = oblicz_A_s1;
                        wyniki[1] = oblicz_A_s2;

                    }
                    else if (x_eff <= oblicz_d() )
                    {
                        oblicz_A_s2 = ( (NEd_conv() * oblicz_e_s1() - 1000 * Fcd() * Szer() * x_eff * (oblicz_d() - 0.5 * x_eff) )/ (1000 * Fyd() * ( oblicz_d() - oblicz_a_2() )) ) * 10000;

                        wyniki [0] = oblicz_A_smin();
                        wyniki [1] = oblicz_A_s2;
                    }
                }
            }


            return wyniki;
        }

        #endregion


        #region Wyniki

        private void As1WynikLabel_Click(object sender, EventArgs e)
        {

        }

        private void As2WynikLabel_Click(object sender, EventArgs e)
        {

        }



        private void ObliczButton_Click(object sender, EventArgs e)
        {
            double As1 = Math.Round(GlownaFunkcja()[0], 2);
            double As2 = Math.Round(GlownaFunkcja()[1], 2);


            As1WynikLabel.Text = Convert.ToString(As1);
            As2WynikLabel.Text = Convert.ToString(As2);

        }

        #endregion





        #region PUSTE FUNKCJE

        #region LABELE - PUSTE

        private void As1Label_Click(object sender, EventArgs e)
        {

        }

        private void As2Label_Click(object sender, EventArgs e)
        {

        }

        private void As2LabelUnit_Click(object sender, EventArgs e)
        {

        }

        private void As1LabelUnit_Click(object sender, EventArgs e)
        {

        }

        private void WyborKlasyBetonuLabel_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Wymiary i wlasciwosci geometryczne dla TEXT_CHANGED

        private void DlugoscTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void SzerokoscTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void OtulinaTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fi_zbrojTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fi_strzemTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void betaTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void WysTB_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Sily Zewnetrzne  dla TEXT_CHANGED

        private void MEd1TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void MEd2TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void NEdTB_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Materialy  dla TEXT_CHANGED

        private void fcdTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void fydTB_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion


        #endregion

    }
}
