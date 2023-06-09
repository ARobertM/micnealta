using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestiune_produse_firme
{
    public partial class Form1 : Form
    {
        // Instantiem un nou obiect de tip Prod (produs)
        Prod produs;

        // Declaram o noua Lista de produse ce contine obiecte de tip Prod
        List<Prod> listaProduse = new List<Prod>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();   
            frm2.ShowDialog();

            if(frm2.DialogResult == DialogResult.OK)
            {
                // Extragem datele din TextBox-uri si le bagam in obiect
                int cod = int.Parse(frm2.tbCod.Text);
                string denumire = frm2.tbDenumire.Text;
                float pret = float.Parse(frm2.tbPret.Text);
                
                Prod produs = new Prod(cod, denumire, pret);

                // Adaugam produsul in lista de produse
                listaProduse.Add(produs);

                // Adaugam produsul in ListViewItem
                ListViewItem itm = new ListViewItem(cod.ToString());
                itm.SubItems.Add(denumire);
                itm.SubItems.Add(pret.ToString());

                // Adaugam produsul din ListViewItem in ListView si se da REFRESH
                listView1.Items.Add(itm);
                listView1.Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Extrage item-ul selectat
                ListViewItem produsSelectat = listView1.SelectedItems[0];

                // Extrage valorile produsului selectat din ListBox
                int cod = int.Parse(produsSelectat.SubItems[0].Text);
                string denumire = produsSelectat.SubItems[1].Text;
                float pret = float.Parse(produsSelectat.SubItems[2].Text);

                // Deschide din nou Form2 pentru a modifica produsul selectat anterior
                Form2 frm2 = new Form2();

                frm2.tbCod.Text = cod.ToString();
                frm2.tbDenumire.Text = denumire;
                frm2.tbPret.Text = pret.ToString();

                frm2.ShowDialog();

                if (frm2.DialogResult == DialogResult.OK)
                {
                    // Modifica valorile produsului selectat
                    produsSelectat.SubItems[0].Text = frm2.tbCod.Text;
                    produsSelectat.SubItems[1].Text = frm2.tbDenumire.Text;
                    produsSelectat.SubItems[2].Text = frm2.tbPret.Text;

                    // Modifica valorile produsului selectat si in List (lista de produse)
                    int selectedIndex = listView1.Items.IndexOf(produsSelectat);

                    listaProduse[selectedIndex].Cod = int.Parse(frm2.tbCod.Text);
                    listaProduse[selectedIndex].Denumire = frm2.tbDenumire.Text;
                    listaProduse[selectedIndex].Pret = float.Parse(frm2.tbPret.Text);
                }
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Serializare

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat",FileMode.Create,FileAccess.Write);
            bf.Serialize(fs, listaProduse);
            fs.Close();
            MessageBox.Show("Serializarea dateolor s-a realizat cu succes!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // Deserializare - important: se pune [Serializable] in clasa Prod.cs sus de tot

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat",FileMode.Open,FileAccess.Read);
            listaProduse = (List<Prod>)bf.Deserialize(fs);
            fs.Close();

            listView1.Items.Clear();

            // Repopulam ListView-ul cu datele deserializate
            foreach (Prod prod in listaProduse)
            {
                ListViewItem itm = new ListViewItem(prod.Cod.ToString());
                itm.SubItems.Add(prod.Denumire.ToString());
                itm.SubItems.Add(prod.Pret.ToString());

                listView1.Items.Add(itm);
               
            }
            MessageBox.Show("Deserializarea datelor s-a realizat cu succes!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPretMin_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                Prod produsMinim = listaProduse[0];

                foreach (Prod prod in listaProduse)
                {
                    if (prod < produsMinim)
                        produsMinim = prod;
                }
                MessageBox.Show("Produsul cel mai ieftin costa " + produsMinim.Pret.ToString() + " lei.");
            }

            else MessageBox.Show("Trebuie sa aveti minim doua produse inserate in lista!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }
    }
}
