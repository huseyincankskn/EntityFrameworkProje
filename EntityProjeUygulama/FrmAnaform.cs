using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class FrmAnaform : Form
    {
        public FrmAnaform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 FR = new Form1();
            FR.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUrun fr1 = new FrmUrun();
            fr1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frmistatistik fr2 = new Frmistatistik();
            fr2.Show();
        }
    }
}
