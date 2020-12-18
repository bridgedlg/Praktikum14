using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textboxinput.Text != "")
            {
              
                string kata = textboxinput.Text.ToLower();
                string urutan = string.Empty;
                char[] charkata = kata.ToCharArray();
                Array.Sort(charkata);
                labeloutput.Text = kata;
              
                for (int i = 0; i < charkata.Length; i++)
                {
                    urutan += Convert.ToString(charkata[i]);
                    labeloutput.Text = urutan; 
                
                }

            }
            else if(textboxinput.Text == "")
            {
                MessageBox.Show("Tolong isi textbox terlebih dahulu!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonreverse_Click(object sender, EventArgs e)
        {
            string reversestr = string.Empty;
            if (textboxinput.Text != "")
            {
                for (int i = textboxinput.TextLength - 1; i >= 0; i--)
                {
                    reversestr += textboxinput.Text[i].ToString();

                }

                if (reversestr == textboxinput.Text)
                {
                    labeloutput.Text = reversestr;
                }
                else
                {
                    labeloutput.Text = reversestr;

                }

            }

            else if (textboxinput.Text == "")
            { MessageBox.Show("Tolong isi textbox terlebih dahulu!"); }
        }
    }
}
