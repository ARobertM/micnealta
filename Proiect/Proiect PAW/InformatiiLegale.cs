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

namespace Proiect_PAW
{
    public partial class InformatiiLegale : Form
    {
        public InformatiiLegale()
        {
            InitializeComponent();
        }

        private void salvareInFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(textBox1.Text);
                sw.Close();
                textBox1.Clear();
            }
        }

        private void citireDinFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

            private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
                bf.Serialize(fs, textBox1.Text);
                fs.Close();
                textBox1.Clear();
            }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            textBox1.Text = (string)bf.Deserialize(fs);
            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "InformatiiLegale.txt";
            string filePath = Path.Combine(Application.StartupPath, fileName);

            try
            {
                StreamReader sr = new StreamReader(filePath);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A aparut o eraoare la incarcarea datelor: " + ex.Message);
            }

        }

        private void InformatiiLegale_Load(object sender, EventArgs e)
        {

        }
    }
}

