using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_20211109
{
    public partial class Form1 : Form
    {
        private List<ucet> ucty;
        private ucet ucticek;
        public Form1()
        {
            InitializeComponent();
            numStav.Maximum = int.MaxValue;
            numVklad.Maximum = 200000;
            numVyber.Maximum = 100000; 
            numPlatba.Maximum = 15000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucty = new List<ucet>();
            if (ucticek == null)
            {
                groupBox1.Enabled = false;
            }
        }
        private void Ukazucet(ucet ucticek)
        {
            lblJmeno.Text = ucticek.Jmeno;
            lblStav.Text = $"{ucticek.Aktualneucet} Kč";
            lblAktualne.Text = $"{ucticek.Vlozeno} Kč";
        }

        private void btnVklad_Click(object sender, EventArgs e)
        {
            var vklad = ucticek.Vlozit(Convert.ToInt32(numVklad.Value));
            MessageBox.Show($"Vloženo {vklad} Kč");
            Ukazucet(ucticek);
        }

        private void btnVyber_Click(object sender, EventArgs e)
        {
            var vklad = ucticek.Vyber(Convert.ToInt32(numVyber.Value));
            MessageBox.Show($"Vybráno {vklad} Kč");
            Ukazucet(ucticek);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            txtjmeno.Text = "";
            numStav.Value = 0;
        }

        private void btnstorno_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void btnVytvorucet_Click(object sender, EventArgs e)
        {
            ucty.Add(new ucet(txtjmeno.Text, Convert.ToInt32(numStav.Value)));
            groupBox2.Visible = false;
            Ukazucty();
        }
        private void Ukazucty()
        {
            listBox1.Items.Clear();
            foreach (var u in ucty)
            {
                listBox1.Items.Add($"{u.Jmeno} ({u.Aktualneucet} Kč");
            }
        }

        private void txtjmeno_TextChanged(object sender, EventArgs e)
        {
            btnVytvorucet.Enabled = txtjmeno.Text.Trim().Length > 0 && numStav.Value > 0;
        }

        private void numStav_ValueChanged(object sender, EventArgs e)
        {
            btnVytvorucet.Enabled = txtjmeno.Text.Trim().Length > 0 && numStav.Value > 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucticek = ucty[listBox1.SelectedIndex];
            Ukazucet(ucticek);
            groupBox1.Enabled = true;
        }

        private void numPlatba_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPlatba_Click(object sender, EventArgs e)
        {
            var vklad = ucticek.Platba(Convert.ToInt32(numPlatba.Value));
            MessageBox.Show($"Zaplaceno {vklad} Kč");
            Ukazucet(ucticek);
        }
    }
}
