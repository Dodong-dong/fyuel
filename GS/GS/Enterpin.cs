using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GS
{
    public partial class Enterpin : Form
    {
        private void ClearTextBox()
        {
            textBox1.Clear();
        }
        public Enterpin()
        {
            InitializeComponent();
        }



        private void button12_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "3001")
            {
                this.Hide();
                Selectform selectForm = new Selectform();
                selectForm.Show();
                MessageBox.Show("Log in Successfully!");
            }
             else
            {
                MessageBox.Show("Incorrect Pin Code!");
                textBox1.Text = "";
            
            }
            
        }
            
        

        Control ActiveControl;
        private void button1_Click(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            //ActiveControl.Focus();
            //SendKeys.Send(btn.Text);
            int number = 1;
            textBox1.Text += number;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0930")
            {
                this.Hide();
                Selectform selectForm = new Selectform();
                selectForm.Show();
                MessageBox.Show("Log in Successfully!");
            }
            else
            {
                MessageBox.Show("Incorrect Pin Code");
                textBox1.Text = "";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = 1;
            textBox1.Text += number;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number = 2;
            textBox1.Text += number;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int number = 3;
            textBox1.Text += number;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int number = 4;
            textBox1.Text += number;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int number = 5;
            textBox1.Text += number;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int number = 6;
            textBox1.Text += number;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int number = 7;
            textBox1.Text += number;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            int number = 8;
            textBox1.Text += number;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int number = 9;
            textBox1.Text += number;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            int number = 0;
            textBox1.Text += number;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

