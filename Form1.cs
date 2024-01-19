using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Filistin;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Filistin2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.horse;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = textBox1.Text;
        }

        private void imgLocBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(textBox2.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex !=-1)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    pictureBox1.Image = Properties.Resources.Filistin;
                }
                else if (listBox1.SelectedIndex == 1)
                {
                    pictureBox1.Image = Properties.Resources.Filistin2;

                }
                else if (listBox1.SelectedIndex == 2)
                {
                    pictureBox1.Image = Properties.Resources.horse;

                }


            }
    }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
                string name = openFileDialog.FileName;
                label3.Text = "Select Image: " + name;
                
                string[] filename = name.Split('\\');
                label3.Text = "Select Image: " + filename[filename.Length-1];

            }
            else
            {
                MessageBox.Show("Seçim İptal Edildi.");
            }
        }












        //empty
    }
}