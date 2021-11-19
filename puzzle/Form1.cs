using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button1.Text;
                button1.Text = "";
            }
            if (button4.Text == "")
            {
                button4.Text = button1.Text;
                button1.Text = "";
            }

            verifikoFitoren();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button2.Text;
                button2.Text = "";
            }
            if (button3.Text == "")
            {
                button3.Text = button2.Text;
                button2.Text = "";
            }
            if (button5.Text == "")
            {
                button5.Text = button2.Text;
                button2.Text = "";
                    
            }
            verifikoFitoren();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button3.Text;
                button3.Text = "";
            }
            if (button6.Text == "")
            {
                button6.Text = button3.Text;
                button3.Text = "";
            }
            verifikoFitoren();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(button1.Text == "")
            {
                button1.Text = button4.Text;
                button4.Text = "";
            }
            if (button5.Text == "")
            {
                button5.Text = button4.Text;
                button4.Text = "";
            }
            if (button7.Text == "")
            {
                button7.Text = button4.Text;
                button4.Text = "";
            }
            verifikoFitoren();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button5.Text;
                button5.Text = "";
            }
            if (button4.Text == "")
            {
                button4.Text = button5.Text;
                button5.Text = "";
            }
            if (button6.Text == "")
            {
                button6.Text = button5.Text;
                button5.Text = "";
            }
            if (button8.Text == "")
            {
                button8.Text = button5.Text;
                button5.Text = "";
            }
            verifikoFitoren();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = button6.Text;
                button6.Text = "";
            }
            if (button5.Text == "")
            {
                button5.Text = button6.Text;
                button6.Text = ""; 
            }
            if (button9.Text == "")
            {
                button9.Text = button6.Text;
                button6.Text = "";
            }
            verifikoFitoren();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = button7.Text;
                button7.Text = "";
            }
            if (button8.Text == "")
            {
                button8.Text = button7.Text;
                button7.Text = "";
            }
            verifikoFitoren();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = button8.Text;
                button8.Text = "";
            }
            if (button7.Text == "")
            {
                button7.Text = button8.Text;
                button8.Text = "";
            }
            if (button9.Text == "")
            {
                button9.Text = button8.Text;
                button8.Text = "";
            }
            verifikoFitoren();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = button9.Text;
                button9.Text = "";
            }
            if (button8.Text == "")
            {
                button8.Text = button9.Text;
                button9.Text = "";
            }
            verifikoFitoren();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            funcRandomNumbers();
        }

        public void funcRandomNumbers()
        {
            // ki me thirr funksionin random qe ka per qellim me i rendit numrat ne menyr
            // te rastesishme dhe duke i vendosur keta numra ne buttona si text.
            Random rnd = new Random();
            List<int> numbers = new List<int>();
            int nr;
            for (int i = 0; i < 8; ++i) {
                do
                {
                    nr = rnd.Next(1, 9);
                } while (numbers.Contains(nr));
                numbers.Add(nr);
            }

            // Hard coded needed to fix
            button1.Text = numbers[0] + "";
            button2.Text = numbers[1] + "";
            button3.Text = numbers[2] + "";
            button4.Text = numbers[3] + "";
            button5.Text = numbers[4] + "";
            button6.Text = numbers[5] + "";
            button7.Text = numbers[6] + "";
            button8.Text = numbers[7] + "";
            button9.Text = "";

        }
    
        public void verifikoFitoren()
        {
            if (button1.Text == "1" &&
                button2.Text == "2" &&
                button3.Text == "3" &&
                button4.Text == "4" &&
                button5.Text == "5" &&
                button6.Text == "6" &&
                button7.Text == "7" &&
                button8.Text == "8" &&
                button9.Text == ""
                )
            {
                string message = "You won!";
                string title = "Results";
                MessageBox.Show(message, title);
            }
        }
    }
}
