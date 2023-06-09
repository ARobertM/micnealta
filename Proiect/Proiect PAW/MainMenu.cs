using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void bt_clienti_Click(object sender, EventArgs e)
        {
            ClientiF form2 = new ClientiF();
            form2.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCalculatorCredit form3 = new frmCalculatorCredit();
            form3.Show();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TipCredite form4 = new TipCredite();
            form4.Show();
        }
    }
}
