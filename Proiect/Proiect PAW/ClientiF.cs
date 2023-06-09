using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class ClientiF : Form
    {
        // Lista clienti
        List<Clienti> listaClienti = new List<Clienti>();
        public ClientiF()
        {
            InitializeComponent();
            incarcaDate();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tb_id.Text == "")
                errorProvider1.SetError(tb_id, "Introduceti ID-ul!");

            try
            {
                int id = Convert.ToInt32(tb_id.Text);
                string prenume = tb_prenume.Text;
                string nume = tb_nume.Text;
                double sold = Convert.ToDouble(tb_sold.Text);
                string sex = cb_sex.Text;
                Clienti c = new Clienti(id, prenume, nume, sold, sex);
                listaClienti.Add(c);
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
            finally
            {
                tb_id.Clear();
                tb_prenume.Clear();
                tb_nume.Clear();
                tb_sold.Clear();
            }

            listView1.Items.Clear();
            foreach (Clienti c in listaClienti)
            {
                ListViewItem itm = new ListViewItem(c.Id.ToString());
                itm.SubItems.Add(c.Prenume.ToString());
                itm.SubItems.Add(c.Nume.ToString());
                itm.SubItems.Add((string)c.Sold.ToString());
                itm.SubItems.Add(c.Sex.ToString()); 
                listView1.Items.Add(itm);
            }

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgv1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
      


        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("fisier.txt");
            foreach (Clienti c in listaClienti)
            {
                sw.Write(c.Id);
                sw.Write(",");
                sw.Write(c.Prenume);
                sw.Write(",");
                sw.Write(c.Nume);
                sw.Write(",");
                sw.Write(c.Sold);
                sw.Write(",");
                sw.Write(c.Sex);
                sw.WriteLine();
            }

            sw.Close();
            MessageBox.Show("Date salvate!");

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void incarcaDate()
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string linie = null;
            while ((linie = sr.ReadLine()) != null)
            {
                int id = Convert.ToInt32(linie.Split(',')[0]);
                string prenume = linie.Split(',')[1];
                string nume = linie.Split(',')[2];
                double sold = Convert.ToDouble(linie.Split(',')[3]);
                string sex = linie.Split(',')[4];   
                Clienti c = new Clienti(id, prenume, nume, sold, sex);
                listaClienti.Add(c);
            }
            sr.Close();
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(Clienti c in listaClienti)
            {
                ListViewItem itm = new ListViewItem(c.Id.ToString());
                itm.SubItems.Add(c.Prenume.ToString());
                itm.SubItems.Add(c.Nume.ToString());
                itm.SubItems.Add((string)c.Sold.ToString());
                itm.SubItems.Add(c.Sex.ToString());
                listView1.Items.Add(itm);
            }
            MessageBox.Show("Date incarcate cu succes!", "Felicitari", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

        }

        private void ClientiF_Load(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            printPreviewDialog.ShowDialog();
        }



        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Segoe UI", 14);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;

            float y = 100;
            float interliniu = 20;

            string title = "Lista completa a CLIENTILOR";

           
            float titleX = e.PageBounds.Width / 2;
            e.Graphics.DrawString(title, new Font("Segoe UI", 35, FontStyle.Bold), Brushes.Black, new PointF(titleX, y), stringFormat);

            y += interliniu * 10;
            
            float columnWidth = e.PageBounds.Width / listView1.Columns.Count;

            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                float columnX = columnWidth * i;
                string columnHeader = listView1.Columns[i].Text;
                float columnHeaderX = columnX + (columnWidth - e.Graphics.MeasureString(columnHeader, font).Width) / 2;
                e.Graphics.DrawString(columnHeader, font, Brushes.Black, new PointF(columnHeaderX, y), stringFormat);
            }

            y += interliniu;
            y += interliniu;

            foreach (ListViewItem item in listView1.Items)
            {
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    float columnX = columnWidth * i;
                    string subItemText = item.SubItems[i].Text;
                    float subItemTextX = columnX + (columnWidth - e.Graphics.MeasureString(subItemText, font).Width) / 2;
                    e.Graphics.DrawString(subItemText, font, Brushes.Black, new PointF(subItemTextX, y), stringFormat);
                }

                y += interliniu;
            }
        }



        private void PrintListView(Graphics graphics, Font font, float y, float interliniu)
        {
            int columnWidth = 150;

            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                graphics.DrawString(listView1.Columns[i].Text, font, Brushes.Black, new PointF(columnWidth * i, y));
            }

            y += interliniu;
            y += interliniu;

            foreach (ListViewItem item in listView1.Items)
            {
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    graphics.DrawString(item.SubItems[i].Text, font, Brushes.Black, new PointF(columnWidth * i, y));
                }

                y += interliniu;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Checked)
                {
                    int id = Convert.ToInt32(itm.SubItems[0].Text);
                    for (int i = 0; i < listaClienti.Count; i++)
                        if (listaClienti[i].Id == id)
                            listaClienti.RemoveAt(i);
                    itm.Remove();
                }
        }

        private void cb_sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
