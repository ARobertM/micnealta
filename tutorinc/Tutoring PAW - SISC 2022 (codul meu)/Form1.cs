using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutoring_PAW___SISC_2022__codul_meu_
{
    public partial class Form1 : Form
    {
        Job job; // instantiem un obiect de tip Job
                // pentru a adauga interviuri in vector in clasa job

        public Form1()
        {
            InitializeComponent();
            job = new Job(new Interviu[] { }, "IT"); //aici cream obiectul gol (default)
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void adaugareInterviuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();

            if(frm2.DialogResult == DialogResult.OK) // am tratat in Form2 proprietatea DialogResult = OK pentru buton
            {
                //Extragem toate datele introduse in form 2

                DateTime data = frm2.dtpData.Value; //extrag data din date-time-picker
                string nume = frm2.tbNume.Text;
                string specializare = frm2.cbSpecializare.SelectedItem.ToString(); // extragere din COMBO-BOX
                float punctajPractic = float.Parse(frm2.tbPctPractic.Text);
                float punctajTeoretic = float.Parse(frm2.tbPctTeorie.Text); // la float se face musai PARSE

                Interviu i = new Interviu(data,specializare,nume,punctajTeoretic,punctajPractic); //facem obiectul cu datele extrase

                job += i;

                //Adaugam jobul in ListView - aici se pun cu ToString
                ListViewItem itm = new ListViewItem(data.ToString());
                itm.SubItems.Add(nume);
                itm.SubItems.Add(specializare);
                itm.SubItems.Add(i.calculeazaPunctaj().ToString());

                listView1.Items.Add(itm); // adaugare in ListView
                listView1.Refresh();
            }
                
        }

        private void stergeInterviuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0) // cel putin un item este selectat
            {
                listView1.SelectedItems[0].Remove();
                var interviuriNesterse = new Interviu[] { };
                foreach(Interviu i in job.VectorInterviuri)
                {
                    if (!listView1.SelectedItems[0].SubItems["Nume"].ToString().Equals(i.NumeCandidat))
                        interviuriNesterse.Append(i);

                }

                job.VectorInterviuri = interviuriNesterse;
            }
        }

        private void trasareGraficToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //chart1.ChartAreas.Add("Punctaje");
            //chart1.Series.Clear();
            //chart1.Series.Add("Series punctaje");

            //for(int i = 0; i<job.nrInterviuri(); i++)
            //{
            //    chart1.Series[0].Points.AddXY(i + 1, job[i].calculeazaPunctaj());
            //}

          
           
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Trasare grafic
            Graphics g = e.Graphics;

            int margine = 10;
            Rectangle r = new Rectangle(panel1.ClientRectangle.X + margine, panel1.ClientRectangle.Y + 4 * margine,
                panel1.ClientRectangle.Width - 2 * margine, panel1.ClientRectangle.Height - 5 * margine);

            Pen pen = new Pen(Color.Red, 3);
            g.DrawRectangle(pen, r);

            double latime = r.Width / (job.nrInterviuri() / 3);
            double distanta = (r.Width - job.nrInterviuri() * latime) / (job.nrInterviuri() + 1);
            double hmax = 20;

            Brush br = new SolidBrush(Color.Blue);

          //  Rectangle[] rectangles = new Rectangle[job.nrInterviuri()];
            for(int i = 0; i<job.nrInterviuri();i++)
            {
              //  rectangles[i] = new Rectangle((r.Location.X + (i + 1) * distanta + i * latime),
                //    r.Location.Y + r.Height - job.VectorInterviuri[i].PunctajPractic) / hmax * r.Height),);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
