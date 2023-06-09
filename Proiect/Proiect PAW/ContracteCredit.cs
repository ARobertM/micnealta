﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_PAW
{
    public partial class frmCalculatorCredit : Form
    {
        public frmCalculatorCredit()
        {
            InitializeComponent();
        }

        private void btnRataLunara_Click(object sender, EventArgs e)
        {
  
        }

        private void txtSumaImprumutata_TextChanged(object sender, EventArgs e)
        {

        }

        private void mnuOptiuniCreditRataLunara_Click(object sender, EventArgs e)
        {
            txtRataLunara.ReadOnly = true;
            txtRataLunara.TabStop = false;
            txtNumarPlati.ReadOnly = false;
            txtNumarPlati.TabStop = true;
            tlsEtichetaOptiuni.Text = "Rata Lunara";
            txtRataLunara.Text = "";
            txtSumaImprumutata.Text = "";
            txtRataDobanda.Text = "";
            txtNumarPlati.Text = "";
            btnCalculeaza.Enabled = true;
            lstAfisare.Items.Clear();
            txtSumaImprumutata.Focus();
        }

        private void mnuOptiuniCreditDurata_Click(object sender, EventArgs e)
        {
            txtNumarPlati.ReadOnly = true;
            txtNumarPlati.TabStop = false;
            txtRataLunara.ReadOnly = false;
            txtRataLunara.TabStop = true;
            tlsEtichetaOptiuni.Text = "Numar de Plati";
            txtRataLunara.Text = "";
            txtSumaImprumutata.Text = "";
            txtRataDobanda.Text = "";
            txtNumarPlati.Text = "";
            btnCalculeaza.Enabled = true;
            lstAfisare.Items.Clear();
            txtSumaImprumutata.Focus();
        }

        public double CalculeazaRataLunara(double sumaImprumutata, double rataDobanda, int numarPlati)
        {
            double rataLunara;

            double dobandaLunara = rataDobanda / 1200;

            if (rataDobanda == 0)
            {
                rataLunara = sumaImprumutata / numarPlati;
            }
            else
            {
                double multiplicator = Math.Pow(1 + dobandaLunara, numarPlati);

                rataLunara = sumaImprumutata * dobandaLunara * multiplicator / (multiplicator - 1);
            }

            return rataLunara;
        }

        public int CalculeazaNumarPlati(double sumaImprumutata, double rataDobanda, double rataLunara)
        {
            int numarPlati;

            double dobandaLunara = rataDobanda / 1200;

            if (rataDobanda == 0)
            {
                numarPlati = (int)(sumaImprumutata / rataLunara);
            }
            else
            {
                numarPlati = (int)((Math.Log(rataLunara) - Math.Log(rataLunara - sumaImprumutata * dobandaLunara))
                    / Math.Log(1 + dobandaLunara));

            }


            return numarPlati;
        }

        public void AfisareAmortizareImprumut(double sumaImprumtata, double rataDobanda, double rataLunara, double plataFinala, int numarPlati)
        {
            lstAfisare.Items.Add("Suma imprumutata: " + String.Format("{0:f2}" + " lei", sumaImprumtata));
            lstAfisare.Items.Add("\r\nRata de dobanda: " + String.Format("{0:f2}", rataDobanda + "%"));
            lstAfisare.Items.Add("\r\nRata lunara: " + String.Format("{0:f2}" + " lei", rataLunara));
            lstAfisare.Items.Add("\r\nAveti " + Convert.ToString(numarPlati - 1) + " plati a cate: " + String.Format("{0:f2}" + " lei", rataLunara));
            lstAfisare.Items.Add("\r\nPlata finala: " + String.Format("{0:f2}" + " lei", plataFinala));
            lstAfisare.Items.Add("\r\nPlata totala: " + String.Format("{0:f2}" + " lei", (numarPlati - 1) * rataLunara + plataFinala));
            lstAfisare.Items.Add("\r\nPlata dobanda de: " + String.Format("{0:f2}" + " lei", (numarPlati - 1) * rataLunara + plataFinala - sumaImprumtata));
        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            double plataFinala, soldImprumut, rataDobanda, sumaImprumutata, rataLunara;
            int numarPlati;

            double.TryParse(txtSumaImprumutata.Text, out sumaImprumutata);
            double.TryParse(txtRataDobanda.Text, out rataDobanda);
            double.TryParse(txtRataLunara.Text, out rataLunara);
            int.TryParse(txtNumarPlati.Text, out numarPlati);

            double rataDobandaLunara = rataDobanda / 1200;

            if (txtSumaImprumutata.Text != "" && txtNumarPlati.Text != "" && txtRataDobanda.Text != "" && txtSumaImprumutata.Text != "0"
                && txtNumarPlati.Text != "0")
            {
                if (!double.TryParse(txtSumaImprumutata.Text, out sumaImprumutata))
                {
                    MessageBox.Show("Trebuie sa introduceti o valoare numerica", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSumaImprumutata.Focus();
                    return;
                }
                else if (!int.TryParse(txtNumarPlati.Text, out numarPlati))
                {
                    MessageBox.Show("Trebuie sa introduceti o valoare numerica", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumarPlati.Focus();
                    return;
                }
                else if (!double.TryParse(txtRataDobanda.Text, out rataDobanda))
                {
                    MessageBox.Show("Trebuie sa introduceti o valoare numerica", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRataDobanda.Focus();
                    return;
                }
                else
                {
                    rataLunara = CalculeazaRataLunara(sumaImprumutata, rataDobanda, numarPlati);
                    txtRataLunara.Text = String.Format("{0:f2}", rataLunara);
                }

            }
            else if (txtSumaImprumutata.Text != "" && txtRataLunara.Text != "" && txtRataDobanda.Text != "" && txtSumaImprumutata.Text != "0")
            {
                if (!double.TryParse(txtSumaImprumutata.Text, out sumaImprumutata))
                {
                    MessageBox.Show("Trebuie sa introduceti o valoare numerica", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSumaImprumutata.Focus();
                    return;
                }
                else if (!double.TryParse(txtRataDobanda.Text, out rataDobanda))
                {
                    MessageBox.Show("Trebuie sa introduceti o valoare numerica", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRataDobanda.Focus();
                    return;
                }
                else if (!double.TryParse(txtRataLunara.Text, out rataLunara))
                {
                    MessageBox.Show("Trebuie sa introduceti o valoare numerica", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRataLunara.Focus();
                    return;
                }
                else if (rataLunara > sumaImprumutata)
                {
                    MessageBox.Show("Rata Lunara trebuie sa fie mai mica sau egala cu suma Imprumutata", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRataLunara.Focus();
                    return;
                }
                else
                {
                    if (rataLunara <= (sumaImprumutata * rataDobandaLunara + 1.0))
                    {
                        if (MessageBox.Show("Plata minima trebuie sa fie Lei " + String.Format("{0:f2}", (int)(sumaImprumutata * rataDobandaLunara + 1.0)) + "\r\n" +
                        "Doriti sa utilzati plata minima?", "Input Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            txtRataLunara.Text = String.Format("{0:f2}", (int)(sumaImprumutata * rataDobandaLunara + 1.0));
                            rataLunara = Convert.ToDouble(txtRataLunara.Text);
                        }
                        else
                        {
                            txtRataLunara.Focus();
                            return;
                        }
                    }

                }

                numarPlati = CalculeazaNumarPlati(sumaImprumutata, rataDobanda, rataLunara);
                txtNumarPlati.Text = String.Format("{0:f2}", numarPlati);
            }
            else
            {
                MessageBox.Show("Trebuie sa introduceti o valoare", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double.TryParse(txtRataLunara.Text, out rataLunara);

            soldImprumut = sumaImprumutata;
            for (int contor = 1; contor <= numarPlati - 1; contor++)
            {
                soldImprumut += soldImprumut * rataDobandaLunara - rataLunara;
            }

            plataFinala = soldImprumut;
            if (plataFinala > rataLunara)
            {
                soldImprumut += soldImprumut * rataDobandaLunara - rataLunara;
                plataFinala = soldImprumut;
                numarPlati++;
                txtNumarPlati.Text = numarPlati.ToString();
            }

            AfisareAmortizareImprumut(sumaImprumutata, rataDobanda, rataLunara, plataFinala, numarPlati);

            btnCalculeaza.Enabled = false;
            btnCalculeaza.Text = "Calculeaza";
            pictureBox1.Visible = true; 

        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstAfisare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mnuOptiuniCreditExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCalculatorCredit_Load(object sender, EventArgs e)
        {

        }

        private void btnNouaCalculatie_Click(object sender, EventArgs e)
        {
            txtSumaImprumutata.Text = "";
            txtNumarPlati.Text = "";
            txtRataDobanda.Text = "";
            txtRataLunara.Text = "";
            btnCalculeaza.Enabled = true;
            lstAfisare.Items.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tlsEtichetaOptiuni_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
