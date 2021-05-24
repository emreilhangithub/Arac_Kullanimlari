using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari //Proje ismimiz burada belirtiriz 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //butona tıklanınca ne olsun
        {
            MessageBox.Show("Merhaba Dünya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Mustafa Emre";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Mustafa Emre";
            label7.Text = "İlhan";
            label8.Text = "Yazılımcı";
        }
    }
}
