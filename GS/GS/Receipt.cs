using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GS
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

     public class ReceiptPrinter
        {
            public ReceiptPrinter(Receipt receipt) 
            { 
                receipt = receipt;
            }

            public void Print()
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                pd.Print();
            }


            public void pd_PrintPage(object sender, PrintPageEventArgs e) 
            { 
                Graphics g= e.Graphics;
                Font font = new Font("Arial", 12);

            }
        }
        

    }

 
}
