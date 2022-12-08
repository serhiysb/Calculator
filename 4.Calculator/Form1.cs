using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Calculator
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        string action;
        bool check = true;
        private void CreateButtons()
        {
            Button button1 = new Button() { Name = "7", Text = "7", Location = new Point(28, 87), Size = new Size(58, 46), TabIndex = 1,  };
            Button button2 = new Button() { Name = "4", Text = "4", Location = new Point(28, 139), Size = new Size(58, 46), TabIndex = 2 };
            Button button3 = new Button() { Name = "1", Text = "1", Location = new Point(28, 191), Size = new Size(58, 46), TabIndex = 3 };
            Button button4 = new Button() { Name = "0", Text = "0", Location = new Point(28, 243), Size = new Size(58, 46), TabIndex = 4 };
            Button button5 = new Button() { Name = "8", Text = "8", Location = new Point(92, 87), Size = new Size(58, 46), TabIndex = 5 };
            Button button6 = new Button() { Name = "5", Text = "5", Location = new Point(92, 139), Size = new Size(58, 46), TabIndex = 6 };
            Button button7 = new Button() { Name = "2", Text = "2", Location = new Point(92, 191), Size = new Size(58, 46), TabIndex = 7 };
            Button button8 = new Button() { Name = ",", Text = ",", Location = new Point(92, 243), Size = new Size(58, 46), TabIndex = 8 };
            Button button9 = new Button() { Name = "9", Text = "9", Location = new Point(156, 87), Size = new Size(58, 46), TabIndex = 9 };
            Button button10 = new Button() { Name = "6", Text = "6", Location = new Point(156, 139), Size = new Size(58, 46), TabIndex = 10 };
            Button button11 = new Button() { Name = "3", Text = "3", Location = new Point(156, 191), Size = new Size(58, 46), TabIndex = 11 };
            Button button12 = new Button() { Name = "C", Text = "C", Location = new Point(156, 243), Size = new Size(58, 46), TabIndex = 12 };
            Button button13 = new Button() { Name = "+", Text = "+", Location = new Point(220, 87), Size = new Size(58, 46), TabIndex = 13 };
            Button button14 = new Button() { Name = "-", Text = "-", Location = new Point(220, 139), Size = new Size(58, 46), TabIndex = 14 };
            Button button15 = new Button() { Name = "*", Text = "*", Location = new Point(220, 191), Size = new Size(58, 46), TabIndex = 15 };
            Button button16 = new Button() { Name = "=", Text = "=", Location = new Point(220, 243), Size = new Size(58, 46), TabIndex = 16 };

            

            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);
            this.Controls.Add(button4);
            this.Controls.Add(button5);
            this.Controls.Add(button6);
            this.Controls.Add(button7);
            this.Controls.Add(button8);
            this.Controls.Add(button9);
            this.Controls.Add(button10);
            this.Controls.Add(button11);
            this.Controls.Add(button12);
            this.Controls.Add(button13);
            this.Controls.Add(button14);
            this.Controls.Add(button15);
            this.Controls.Add(button16);

            button1.Font = new Font("btn1", 15);
            button2.Font = new Font("btn2", 15);
            button3.Font = new Font("btn3", 15);
            button4.Font = new Font("btn4", 15);
            button5.Font = new Font("btn5", 15);
            button6.Font = new Font("btn6", 15);
            button7.Font = new Font("btn7", 15);
            button8.Font = new Font("btn8", 15);
            button9.Font = new Font("btn9", 15);
            button10.Font = new Font("btn10", 15);
            button11.Font = new Font("btn11", 15);
            button12.Font = new Font("btn12", 15);
            button13.Font = new Font("btn13", 15);
            button14.Font = new Font("btn14", 15);
            button15.Font = new Font("btn15", 15);
            button16.Font = new Font("btn16", 15);

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;
            button5.Click += Button5_Click;
            button6.Click += Button6_Click;
            button7.Click += Button7_Click;
            button8.Click += Button8_Click;
            button9.Click += Button9_Click;
            button10.Click += Button10_Click;
            button11.Click += Button11_Click;
            button12.Click += Button12_Click;
            button13.Click += Button13_Click;
            button14.Click += Button14_Click;
            button15.Click += Button15_Click;
            button16.Click += Button16_Click;
        }
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            CreateButtons();
        }
        private void Button16_Click(object sender, EventArgs e)
        {
            if(action == "+")
            {
                textBox1.Text = (a + Convert.ToDouble(textBox1.Text)).ToString();
            }
            if(action=="-")
            {
                textBox1.Text = (a - Convert.ToDouble(textBox1.Text)).ToString();
            }
            if (action == "*")
            {
                textBox1.Text = (a * Convert.ToDouble(textBox1.Text)).ToString();
            }
            action = null;
            check = true;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            try
            {
                action = "*";
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                action = "-";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                action = "+";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (check == true)
                textBox1.Text = "";
            check = false;
            textBox1.Text = "";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (check == true)
                textBox1.Text = "";
            check = false;
            textBox1.Text += "3";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (check == true)
                textBox1.Text = "";
            check = false;
            textBox1.Text += "6";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (check == true)
                textBox1.Text = "";
            check = false;
            textBox1.Text += "9";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (check == true)
                textBox1.Text = "";
            check = false;
            textBox1.Text += ",";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (check == true)
                textBox1.Text = "";
            check = false;
            textBox1.Text += "2";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (check == true)
                textBox1.Text = "";
            check = false;
            textBox1.Text += "5";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (check == true)
                textBox1.Text = "";
            check = false;
            textBox1.Text += "8";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (check == true)
                textBox1.Text = "";
            check = false;
            textBox1.Text += "0";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (check == true)
                textBox1.Text = "";
            check = false;
            textBox1.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (check == true)
                textBox1.Text = "";
            check = false;
            textBox1.Text += "4";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (check == true)
                textBox1.Text = "";
            check = false;
            textBox1.Text += "7";
        }
    }
}
