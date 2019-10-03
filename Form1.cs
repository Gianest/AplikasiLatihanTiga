using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLatihanTiga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nama = textBox1.Text;
            var pend = comboBox1.Text;
            var peker = listBox1.Text;

            textBox2.Text = string.Format("Piye Kabare {0}", nama);
            textBox3.Text = string.Format("Sekolah {0}", pend);
            textBox4.Text = string.Format("Pekerjaan {0}", peker);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.Width < 489 || this.Height<301) {
                this.Width = 489;
                this.Height = 301;
            }
        }
    }
}
//489; 301