using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GS
{
    public partial class Selectform : Form
    {
        
        private void ClearTextBox()
        {
            //TotalPriceTextBox.Text = string.Empty;
            //literspumpedTextBox.Text = string.Empty ;
            //textBox1.Text = string.Empty;
            //radioButton1.Checked = false;
            //radioButton2.Checked = false;
            //radioButton3.Checked = false;
        }

        public Selectform()
        {
            InitializeComponent();
        }

       
        private void button13_Click(object sender, EventArgs e)
        {
            double balance = 3000;

            double totalPrice = double.Parse(TotalPriceTextBox.Text);
            double litersPumped = double.Parse(literspumpedTextBox.Text);

          double pricePerLiter = totalPrice / litersPumped;

            balance -= totalPrice;

          textBox1.Text = $"{pricePerLiter:0.00}";
            
            MessageBox.Show("Your balance is: " + balance);
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double number = 62.40;
            literspumpedTextBox.Text += number;
       }


        private void button1_Click(object sender, EventArgs e)
        {
            int number = 1;
            TotalPriceTextBox.Text += number;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = 2;
            TotalPriceTextBox.Text += number;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = 3;
            TotalPriceTextBox.Text += number;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number = 4;
            TotalPriceTextBox.Text += number;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int number = 5;
            TotalPriceTextBox.Text += number;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int number = 6;
            TotalPriceTextBox.Text += number;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int number = 7;
            TotalPriceTextBox.Text += number;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int number = 8;
            TotalPriceTextBox.Text += number;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int number = 9;
            TotalPriceTextBox.Text += number;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int number = 0;
            TotalPriceTextBox.Text += number;
        }

       
        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
         
            
        //    comboBox1.Items.Add("Premium");
        //    comboBox1.Items.Add("Unleaded");
        //    comboBox1.Items.Add("Diesel");

        //    Dictionary<string, double> itemPrices = new Dictionary<string, double>();
        //    itemPrices.Add("Premium", 62.40);
        //    itemPrices.Add("Unleaded", 60.20);
        //    itemPrices.Add("Diesel", 61.30);

        //    string selectedItem = comboBox1.SelectedItem.ToString();
        //    double itemPrice = itemPrices[selectedItem];
        //    textBox1.Text = " " + itemPrice.ToString();
        //}

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            double number = 62.40;
            literspumpedTextBox.Text += number;
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            double number = 60.20;
            literspumpedTextBox.Text += number;
            
        }
    

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            double number = 61.30;
            literspumpedTextBox.Text += number;
           
        }


        private void button10_Click(object sender, EventArgs e)
        {

            TotalPriceTextBox.Text = string.Empty;
            literspumpedTextBox.Text = string.Empty;
            textBox1.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

        }

        private void literspumpedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Receipt client = new Receipt();
            client.Show();
           
        }
    }
    }


    

