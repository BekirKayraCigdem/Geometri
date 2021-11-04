using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geometry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Double x =0, y=0, z=0, x1=0, y1=0, z1=0 ;

        private void button3_Click(object sender, EventArgs e)
        {
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            alanLabel.Text = "0";
            cevreLabel.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox8.Text=="" || textBox7.Text=="" || textBox9.Text=="")
            {
                MessageBox.Show("Do not leave it blank.", "Error");
            }

            x = Convert.ToDouble(textBox7.Text);
            y = Convert.ToDouble(textBox8.Text);
            z = Convert.ToDouble(textBox9.Text);

            double cevreUcgen = x + y + z;
            cevreLabel.Text = cevreUcgen.ToString();

            double u = cevreUcgen / 2;
            double alanUcgen = Math.Sqrt(u * (u - x) * (u - y) * (u - z));
            alanLabel.Text = alanUcgen.ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text=="")
            {
                textBox1.Text = "0";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
            }
            if (textBox5.Text == "")
            {
                textBox5.Text = "0";
            }
            if (textBox6.Text == "")
            {
                textBox6.Text = "0";
            }

            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            z = Convert.ToDouble(textBox3.Text);
            x1 = Convert.ToDouble(textBox4.Text);
            y1 = Convert.ToDouble(textBox5.Text);
            z1 = Convert.ToDouble(textBox6.Text);

            if (x==0 && y==0 && z==0)
            {
                if (x1==0 && y1==0 && z1==0)
                {
                    MessageBox.Show("Do not leave it blank.", "Error");
                }
                else if (x1==0)
                {
                    x1 = 360 - (y1 + z1);
                    x = 180 - x1;
                    y = 180 - y1;
                    z = 180 - z1;
                }
                else if (y1==0)
                {
                    y1 = 360 - (x1 + z1);
                    x = 180 - x1;
                    y = 180 - y1;
                    z = 180 - z1;
                }
                else if (z1==0)
                {
                    z1 = 360 - (y1 + x1);
                    x = 180 - x1;
                    y = 180 - y1;
                    z = 180 - z1;
                }
                else
                {
                    MessageBox.Show("Do not leave it blank.", "Error");
                }

            }

            else if (x==0 && y==0)
            {
                z1 = 180 - z;

                if (x1==0)
                {
                    x1 = 360 - (y1 + z1);
                    x = 180 - x1;
                    y = 180 - (x + z);
                }

                else if (y1==0)
                {
                    y1 = 360 - (x1 + y1);
                    y = 180 - y1;
                    x = 180 - (y + z);
                }
                

            }
            else if (x == 0 && z == 0)
            {
                y1 = 180 - y;

                if (x1 == 0)
                {
                    x1 = 360 - (y1 + z1);
                    x = 180 - x1;
                    z = 180 - (x + y);
                }

                else if (z1 == 0)
                {
                    z1 = 360 - (x1 + y1);
                    z = 180 - z1;
                    x = 180 - (y + z);
                }


            }
            else if (z == 0 && y == 0)
            {
                x1 = 180 - x;

                if (z1 == 0)
                {
                    z1 = 360 - (y1 + x1);
                    z = 180 - z1;
                    y = 180 - (z + x);
                }

                else if (y1 == 0)
                {
                    y1 = 360 - (x1 + z1);
                    y = 180 - y1;
                    z = 180 - (x + y);
                }


            }

            else if (x==0)
            {
                x = 180 - (y + z);
                x1 = 180 - x;
                y1 = 180 - y;
                z1 = 180 - z;
            }
            else if (y == 0)
            {
                y = 180 - (x + z);
                x1 = 180 - x;
                y1 = 180 - y;
                z1 = 180 - z;
            }
            else if (z == 0)
            {
                z = 180 - (y + x);
                x1 = 180 - x;
                y1 = 180 - y;
                z1 = 180 - z;
            }


            if (x >=179 || y >= 179 || z >= 179 || x1 >= 179 || y1 >= 179 || z1 >= 179)
            {
                MessageBox.Show("It cannot be greater than 180.", "Error");
            }
            else
            {
                textBox1.Text = x.ToString();
                textBox2.Text = y.ToString();
                textBox3.Text = z.ToString();
                textBox4.Text = x1.ToString();
                textBox5.Text = y1.ToString();
                textBox6.Text = z1.ToString();
            }
            
        }


    }
}
