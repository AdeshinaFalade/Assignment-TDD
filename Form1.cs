using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_TDD
{
    /// <summary>
    /// Main Class
    /// </summary>
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent(); ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string romanNumeral = textBox1.Text;

                textBox2.Text = (Roman(romanNumeral)).ToString();
            }
            catch (Exception)
            {

                textBox2.Text = "Error";
            }
        }

        /// <summary>
        /// This method converts roman numeral to integers
        /// </summary>
        /// <param name="rom"></param>
        /// <returns></returns>
        public static int Roman(string rom)
        {
            var ro = rom.ToLower();             //convert parameter to lower case
            char[] roman = ro.ToCharArray();        //convert string to an array of characters
            int total = 0;


            try
            {
                for (int i = 0; i < roman.Length; i++)      //loops through the array
                {
                    if (roman[i].ToString() == "i")
                    {
                        total += 1;
                    }
                    if (roman[i].ToString() == "v")
                    {
                        total += 5;
                    }
                    if (roman[i].ToString() == "x")
                    {
                        total += 10;
                    }
                    if (roman[i].ToString() == "l")
                    {
                        total += 50;
                    }
                    if (roman[i].ToString() == "c")
                    {
                        total += 100;
                    }
                    if (roman[i].ToString() == "d")
                    {
                        total += 500;
                    }
                    if (roman[i].ToString() == "m")
                    {
                        total += 1000;
                    }
                    //This part helps with numbers like '4' that have 'i' before 'v'
                    if (roman[i].ToString() == "i" && roman[i + 1].ToString() == "v" && roman.Length >= 2)
                    {
                        total -= 2;
                    }
                    if (roman[i].ToString() == "i" && roman[i + 1].ToString() == "x" && roman.Length >= 2)
                    {
                        total -= 2;
                    }
                    if (roman[i].ToString() == "x" && roman[i + 1].ToString() == "l" && roman.Length >= 2)
                    {
                        total -= 20;
                    }
                    if (roman[i].ToString() == "x" && roman[i + 1].ToString() == "c" && roman.Length >= 2)
                    {
                        total -= 20;
                    }
                    if (roman[i].ToString() == "c" && roman[i + 1].ToString() == "d" && roman.Length >= 2)
                    {
                        total -= 200;
                    }
                    if (roman[i].ToString() == "c" && roman[i + 1].ToString() == "m" && roman.Length >= 2)
                    {
                        total -= 200;
                    }


                }
            }
            catch (Exception e)
            {

                var error = e.Message;
            }
            return total;

        }
    }
}
    

