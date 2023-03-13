using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BufeKasaUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatoplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, kola, cips, bilet, toplam;
            misir = Convert.ToInt16(textBox1.Text);
            kola = Convert.ToInt16(textBox2.Text);
            cips = Convert.ToInt16(textBox3.Text);
            bilet = Convert.ToInt16(textBox4.Text);

            toplam = misir*5 + kola*7 + cips*3 + bilet*10;
            label14.Text = toplam.ToString() + " TL";

            kasatoplam = kasatoplam + toplam;
            label16.Text = kasatoplam.ToString()+" TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
