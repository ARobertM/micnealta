using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Data.SqlClient;

namespace Proiect_PAW
{
    public partial class TipCredite : Form
    {
        public TipCredite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("nbrfxrates.xml");
            string str = sr.ReadToEnd();
            sr.Close();

            XmlReader reader = XmlReader.Create(
                new StringReader(str));
            while (reader.Read())
            {
                if (reader.Name == "PublishingDate" &&
                    reader.NodeType == XmlNodeType.Element)
                {
                    reader.Read();
                    tbData.Text = reader.Value;
                }
                if (reader.Name == "Rate" && reader.NodeType ==
                    XmlNodeType.Element)
                {
                    string atribut = reader["currency"];
                    if (atribut == "EUR")
                    {
                        reader.Read();
                        tbEUR.Text = reader.Value;
                    }
                    else
                        if (atribut == "USD")
                    {
                        reader.Read();
                        tbUSD.Text = reader.Value;
                    }
                    else
                        if (atribut == "GBP")
                    {
                        reader.Read();
                        tbGBP.Text = reader.Value;
                    }
                    else
                        if (atribut == "XAU")
                    {
                        reader.Read();
                        tbXAU.Text = reader.Value;
                    }
                }
            }
        }

        private void TipCredite_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TipuriCrediteBD.mdf;Integrated Security=True;Connect Timeout=30");

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = "SELECT * FROM TipuriCredite;";
                SqlCommand cmd = new SqlCommand(query, conn);

           
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                MessageBox.Show("Informatiile tipurilor de credite au fost afisate cu succes!", "Super!", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

                conn.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void rereToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            InformatiiLegale inf = new InformatiiLegale();
            inf.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
