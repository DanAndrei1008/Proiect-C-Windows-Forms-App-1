using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Proiect_Csharp_Dosius_Dan_Andrei_609
{
    public partial class Form1 : Form
    {
        ArrayList lastGames = new ArrayList();
        public int randomNumber;
        Random rnd = new Random();
        int x;
        int y = 0;
        int[] number = new int[3];
        public Form1()
        {
           
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("Date.txt").Length;
            List<string> loglist = File.ReadAllLines("Date.txt").ToList();

            if (lines >= 5)
            {
                loglist.RemoveAt(0);
                File.WriteAllLines("Date.txt", loglist.ToArray());
            }

            File.AppendAllText("Date.txt", label4.Text + "-" + label5.Text + "\r\n");
            label4.Text = "0";
            label5.Text = "0";
            label1.Text = "Choose your weapon:";
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            randomNumber = rnd.Next(1, 4);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;

            if (pictureBox4.Visible && randomNumber == 1)
            {
                randomNumber = rnd.Next(1, 4);
                x = Convert.ToInt32(label4.Text);
                y = Convert.ToInt32(label5.Text);
                label1.Text = "Equality";
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;

                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
            }
            else if (pictureBox4.Visible && randomNumber == 2)
            {
                randomNumber = rnd.Next(1, 4);
                x = Convert.ToInt32(label4.Text);
                label5.Text = (int.Parse(label5.Text) + 1).ToString();
                y = Convert.ToInt32(label5.Text);
                label1.Text = "You lose!!!";
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;

                pictureBox4.Visible = true;
                pictureBox7.Visible = true;
            }
            else if (pictureBox4.Visible && randomNumber == 3)
            {
                randomNumber = rnd.Next(1, 4);
                label4.Text = (int.Parse(label4.Text) + 1).ToString();
                x = Convert.ToInt32(label4.Text);
                y = Convert.ToInt32(label5.Text);
                label1.Text = "You win!!!";
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;

                pictureBox4.Visible = true;
                pictureBox9.Visible = true;
            }
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;

            if (pictureBox6.Visible && randomNumber == 1)
            {
                randomNumber = rnd.Next(1, 4);
                label4.Text = (int.Parse(label4.Text) + 1).ToString();
                x = Convert.ToInt32(label4.Text);
                y = Convert.ToInt32(label5.Text);
                label1.Text = "You win!!!";
                pictureBox4.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;

                pictureBox6.Visible = true;
                pictureBox5.Visible = true;

            }
            else if (pictureBox6.Visible && randomNumber == 2)
            {
                randomNumber = rnd.Next(1, 4);
                x = Convert.ToInt32(label4.Text);
                y = Convert.ToInt32(label5.Text);
                label1.Text = "Equality";
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;

                pictureBox6.Visible = true;
                pictureBox7.Visible = true;

            }
            else if (pictureBox6.Visible && randomNumber == 3)
            {
                randomNumber = rnd.Next(1, 4);
                label5.Text = (int.Parse(label5.Text) + 1).ToString();
                x = Convert.ToInt32(label4.Text);
                y = Convert.ToInt32(label5.Text);
                label1.Text = "You lose!!!";
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;

                pictureBox6.Visible = true;
                pictureBox9.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;

            if (pictureBox8.Visible && randomNumber == 1)
            {
                randomNumber = rnd.Next(1, 4);
                x = Convert.ToInt32(label4.Text);
                label5.Text = (int.Parse(label5.Text) + 1).ToString();
                y = Convert.ToInt32(label5.Text);
                label1.Text = "You lose!!!";
                pictureBox4.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox9.Visible = false;

                pictureBox8.Visible = true;
                pictureBox5.Visible = true;

            }
            else if (pictureBox8.Visible && randomNumber == 2)
            {
                randomNumber = rnd.Next(1, 4);
                x = Convert.ToInt32(label4.Text);
                label4.Text = (int.Parse(label4.Text) + 1).ToString();
                y = Convert.ToInt32(label5.Text);
                label1.Text = "You win!!!";
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox9.Visible = false;

                pictureBox8.Visible = true;
                pictureBox7.Visible = true;

            }
            else if (pictureBox8.Visible && randomNumber == 3)
            {
                randomNumber = rnd.Next(1, 4);
                x = Convert.ToInt32(label4.Text);
                y = Convert.ToInt32(label5.Text);
                label1.Text = "Equality";
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;

                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            randomNumber = rnd.Next(1, 4);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form2 f = new Form2();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String[] logcontent = File.ReadAllLines("Date.txt");
            string log = string.Join("", logcontent);
            listBox1.Items.Clear();
            if (log == "")
            {
                listBox1.Items.Add("There are no matches.");
            } 
            else
            {
                foreach (string s in logcontent)
                {
                    string result = s;
                    listBox1.Items.Add(result);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            StreamWriter Matchlog = File.CreateText("Date.txt") ;
            Matchlog.Flush();
            Matchlog.Close();
            listBox1.Items.Clear();
        }
    }
}
