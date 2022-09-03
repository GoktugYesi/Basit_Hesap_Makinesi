using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
        double x = 0;
        double y = 0;
        double z = 0;
        bool yeniislem = false;
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnSıfır_Click(object sender, EventArgs e)
        {
            if (yeniislem)
            {
                textBox1.Text = string.Empty;
                yeniislem = false;
            }
            var btn = sender as Button;
            textBox1.Text += btn.Text;

        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            //islem = islemler.topla;
            var btn = sender as Button;

            islemiYap();
            btnSonuc.Tag = btn.Tag;
            //if (x == 0)
            //{
            //    x = Convert.ToDouble(textBox1.Text);

            //    textBox1.Text = y.ToString();
            //}
            //else
            //{
            //    y = Convert.ToDouble(textBox1.Text);
            //}
            //label1.Text = x.ToString();
            //label3.Text = x.ToString();



        }

        private void islemiYap()
        {
            x = double.Parse(textBox1.Text);
            switch (btnSonuc.Tag.ToString())
            {
                case "topla":
                    z = x + y;
                    break;
                case "cikar":
                    z = y - x;
                    break;
                case "carp":
                    z = x * y;
                    break;
                case "bol":
                    z = y / x;
                    break;
                default:
                    z = x;
                    break;
            }
            y = z;
            textBox1.Text = z.ToString();
            yeniislem = true;
        }

        private void btnSıfırla_Click(object sender, EventArgs e)
        {
             x = 0;
             y = 0;
             z = 0;
            textBox1.Text = "0";
        }

        private void btnSıfırla_Click_1(object sender, EventArgs e)
        {
            islemiYap();
            btnSonuc.Tag = "";
        }
    }
}
