using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh3_Bai2
{
    public partial class DienTu_1 : Form
    {
        List<DienTu> listDienTu = new List<DienTu>();
        public DienTu_1()
        {
            listDienTu = StaticData._DienTus;
            InitializeComponent();
           
        }

        private void DienTu_1_Load(object sender, EventArgs e)
        {
            foreach (DienTu item in listDienTu)
            {
                richTextBox1.Text = item.Debai;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            foreach  (DienTu item in listDienTu)
            {
                richTextBox1.Text = item.Dapan;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (DienTu item in listDienTu)
            {
                if(textBox1.Text == item.Dapantungcau[0])
                {
                    dem++;
                    textBox1.BackColor = Color.Green;
                }
                else
                {
                    textBox1.BackColor = Color.Red;
                }
                if (textBox2.Text == item.Dapantungcau[1])
                {
                    dem++;
                    textBox2.BackColor = Color.Green;
                }
                else
                {
                    textBox2.BackColor = Color.Red;
                }
                if (textBox3.Text == item.Dapantungcau[2])
                {
                    dem++;
                    textBox3.BackColor = Color.Green;
                }
                else
                {
                    textBox3.BackColor = Color.Red;
                }
                if (textBox4.Text == item.Dapantungcau[3])
                {
                    dem++;
                    textBox4.BackColor = Color.Green;
                }
                else
                {
                    textBox4.BackColor = Color.Red;
                }
                if (textBox5.Text == item.Dapantungcau[4])
                {
                    dem++;
                    textBox5.BackColor = Color.Green;
                }
                else
                {
                    textBox5.BackColor = Color.Red;
                }
                if (textBox6.Text == item.Dapantungcau[5])
                {
                    dem++;
                    textBox6.BackColor = Color.Green;
                }
                else
                {
                    textBox6.BackColor = Color.Red;
                }
                if (textBox7.Text == item.Dapantungcau[6])
                {
                    dem++;
                    textBox7.BackColor = Color.Green;
                }
                else
                {
                    textBox7.BackColor = Color.Red;
                }
                if (textBox8.Text == item.Dapantungcau[7])
                {
                    dem++;
                    textBox8.BackColor = Color.Green;
                }
                else
                {
                    textBox8.BackColor = Color.Red;
                }
                if (textBox9.Text == item.Dapantungcau[8])
                {
                    dem++;
                    textBox9.BackColor = Color.Green;
                }
                else
                {
                    textBox9.BackColor = Color.Red;
                }
                if (textBox10.Text == item.Dapantungcau[9])
                {
                    dem++;
                    textBox10.BackColor = Color.Green;
                }
                else
                {
                    textBox10.BackColor = Color.Red;
                }
            }
            MessageBox.Show("Điểm của bạn là: " + dem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DienTu item in listDienTu)
            {
                richTextBox1.Text = item.Debai;
            }
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            textBox7.BackColor = Color.White;
            textBox8.BackColor = Color.White;
            textBox9.BackColor = Color.White;
            textBox10.BackColor = Color.White;
        }
    }
}
