using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace typing
{
    public partial class Form1 : Form
    {
        double resultValue = 0f;  
        string operation = "" ;
        bool isOperation = false;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((display.Text =="0" )|| (isOperation))
                display.Text="";

            isOperation = false;
            
            if (button.Text == ",")
            {
                if (!display.Text.Contains(","))

                    display.Text = display.Text+ button.Text;
            }
            else
            {
                display.Text = display.Text + button.Text;
            }
            
            
        }

        private void operatorClick(object sender, EventArgs e)
        {  
            Button button = (Button)sender;
            operation = button.Text;
            resultValue = Double.Parse(display.Text);
            isOperation = true;
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            resultValue = 0;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            

            switch (operation)
            {
                case "+":
                    display.Text = (resultValue + Convert.ToDouble(display.Text)).ToString();
                    break;
                case "-":
                    display.Text = (resultValue - Convert.ToDouble(display.Text)).ToString();
                    break;
                case "*":
                    display.Text = (resultValue * Convert.ToDouble(display.Text)).ToString();
                    break;
                case "/":
                    if (display.Text =="0")
                    {
                        display.Text = "upps  ;)";
                    }
                    else
                    {
                        display.Text = (resultValue / Convert.ToDouble(display.Text)).ToString();
                    }
                    break;
                default:
                    break;
            };
           

           
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (display.Text.Length >0)
            {
                display.Text = display.Text.Remove(display.Text.Length-1,1);
            }
            if (display.Text == "")
            {
                display.Text = "0";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
            
        }

        private void display_TextChanged(object sender, EventArgs e)
        {
            
        }

      
    }
}
