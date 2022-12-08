using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoZahlen
{
    public partial class Form1 : Form
    {
        int[] numbers=new int[6];
        int[] input=new int[6];
        bool treffer;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void zahlButton_Click(object sender, EventArgs e)
        {
            Label[] labels = new Label[6];
            labels[0] = label1;
            labels[1] = label2;
            labels[2] = label3;
            labels[3] = label4;
            labels[4] = label5;
            labels[5] = label6;

            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)//schaut nach ob die random tahl schon vorhanden ist falls ja dann soll er eine nue erstellen und dann in das array speichern
            {
                int pp = random.Next(1, 49);
                if (numbers.Contains(pp))
                    i--;
                else
                    numbers[i] = pp;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                for(int j = 0; j < input.Length; j++)
                {
                    if (numbers[i] == input[j])
                        treffer = true;
                }
                if (treffer == true)
                {
                    labels[i].BackColor = Color.Green;
                    treffer = false;
                }
                else { labels[i].BackColor= Color.White; }
                
            }


            label1.Text = numbers[0].ToString();//zeigt die random zahlen im programm an 
            label2.Text = numbers[1].ToString();
            label3.Text = numbers[2].ToString();
            label4.Text = numbers[3].ToString();
            label5.Text = numbers[4].ToString();
            label6.Text = numbers[5].ToString();
           


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            input[0] = Convert.ToInt32(textBox1.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            input[5] = Convert.ToInt32(textBox6.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            input[4] = Convert.ToInt32(textBox5.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            input[3] = Convert.ToInt32(textBox4.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            input[2] = Convert.ToInt32(textBox3.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            input[1] = Convert.ToInt32(textBox2.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
