using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roulette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("lütfen sayı giriniz" , "System" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
            else
            {
                //System.Threading.Thread.Sleep(5000);

                int color = 0;
                int input1, input2, prediction, green = 0, cons = 0;
                int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
                int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
                
                input1 = Convert.ToInt32(textBox1.Text);
                input2 = Convert.ToInt32(textBox2.Text);
                prediction = Convert.ToInt32(textBox4.Text);

                Random random = new Random();
                int number = random.Next(0, 37);
                textBox3.Text = number.ToString();

                if (number == green)
                {
                    color = 1;
                }
                else
                {
                    if (comboBox1.SelectedIndex == 3 || comboBox1.SelectedIndex == 4 || comboBox1.SelectedIndex == 5)
                    {
                        if (comboBox1.SelectedIndex == 3)
                        {
                            foreach (int i in red)
                            {
                                if (number == i)
                                {
                                    color = 2;
                                }
                            }
                        }
                        else if (comboBox1.SelectedIndex == 4)
                        {
                            foreach (int j in black)
                            {
                                if (number == j)
                                {
                                    color = 3;
                                }
                            }
                        }
                    }                   
                }

                if (textBox1.Text != "" || textBox2.Text != "" && textBox4.Text != "")                
                {       
                    if (comboBox1.SelectedIndex == 0 && number < 13)
                    {
                        if (prediction == number)
                        {
                            cons = input1 * 7;
                            MessageBox.Show("tebrikler kazandınız");
                            textBox5.Text = ("tebrikler " + cons + " $ kazandınız");
                        }                   
                        else if (prediction < 13 && prediction > 0 && prediction == number)
                        {
                            cons = (input1 + input2) * 7;
                            MessageBox.Show("tebrikler kazandınız");
                            textBox5.Text = ("tebrikler " + cons + " $ kazandınız");
                        }
                        else if (prediction < 13 && prediction > 0)
                        {
                            cons = input2 * 5;
                            MessageBox.Show("tebrikler kazandınız");
                            textBox5.Text = ("tebrikler " + cons + " $ kazandınız");
                        }
                        else
                        {
                            MessageBox.Show("Kazanamadınız");
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                        }
                    }
                    else if (comboBox1.SelectedIndex == 1 && number > 12 && number < 25)
                    {
                        if (prediction == number)
                        {
                            cons = input1 * 7;
                            MessageBox.Show("tebrikler kazandınız");
                            textBox5.Text = ("tebrikler " + cons + " $ kazandınız");
                        }
                        else if (prediction < 25 && prediction > 12 && prediction == number)
                        {
                            cons = (input1 + input2) * 7;
                            MessageBox.Show("tebrikler kazandınız");
                            textBox5.Text = ("tebrikler " + cons + " $ kazandınız");
                        }
                        else if (prediction < 25 && prediction > 12)
                        {
                            cons = input2 * 5;
                            MessageBox.Show("tebrikler kazandınız");
                            textBox5.Text = ("tebrikler " + cons + " $ kazandınız");
                        }
                        else
                        {
                            MessageBox.Show("Kazanamadınız");
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                        }
                    }
                    else if (comboBox1.SelectedIndex == 2 && number > 24 && number < 37)
                    {
                        if (prediction == number)
                        {
                            cons = input1 * 7;
                            MessageBox.Show("tebrikler kazandınız");
                            textBox5.Text = ("tebrikler " + cons + " $ kazandınız");
                        }
                        else if (prediction < 37 && prediction > 25 && prediction == number)
                        {
                            cons = (input1 + input2) * 7;
                            MessageBox.Show("tebrikler kazandınız");
                            textBox5.Text = ("tebrikler " + cons + " $ kazandınız");
                        }
                        else if (prediction < 37 && prediction > 25)
                        {
                            cons = input2 * 5;
                            MessageBox.Show("tebrikler kazandınız");
                            textBox5.Text = ("tebrikler " + cons + " $ kazandınız");
                        }
                        else
                        {
                            MessageBox.Show("Kazanamadınız");
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                        }
                    }
                    else if (comboBox1.SelectedIndex == 5 || comboBox1.SelectedIndex == 4 || comboBox1.SelectedIndex == 3 || color != 0)
                    {
                        if (number == prediction)
                        {
                            if (comboBox1.SelectedIndex == 5 && color == 1)
                            {
                                cons = (input1 + input2) * 10;
                                MessageBox.Show("tebrikler kazandınız");
                                textBox5.Text = ("tebrikler " + cons + " $ kazandınız");
                            }
                            else if (comboBox1.SelectedIndex == 3 && color == 2)
                            {
                                cons = (input1 + input2) * 4;
                                MessageBox.Show("tebrikler kazandınız");
                                textBox5.Text = ("tebrikler " + cons + " $ kazandınız");
                            }
                            else if (comboBox1.SelectedIndex == 4 && color == 3)
                            {
                                cons = (input1 + input2) * 4;
                                MessageBox.Show("tebrikler kazandınız");
                                textBox5.Text = ("tebrikler " + cons + " $ kazandınız");
                            }
                            else
                            {
                                MessageBox.Show("Kazanamadınız");
                                textBox1.Clear();
                                textBox2.Clear();
                                textBox3.Clear();
                                textBox4.Clear();
                                textBox5.Clear();
                            }
                        }
                        else
                        {
                           if (comboBox1.SelectedIndex == 5 && color == 1)
                           {
                               cons = input2 * 10;
                               MessageBox.Show("tebrikler kazandınız");
                               textBox5.Text = ("tebrikler " + cons + " $ kazandınız");
                           }
                           else if (comboBox1.SelectedIndex == 3 && color == 2)
                           {
                               cons = input2 * 4;
                               MessageBox.Show("tebrikler kazandınız");
                               textBox5.Text = ("tebrikler " + cons + " $ kazandınız");
                           }
                           else if (comboBox1.SelectedIndex == 4 && color == 3)
                           {
                               cons = input2 * 4;
                               MessageBox.Show("tebrikler kazandınız");
                               textBox5.Text = ("tebrikler " + cons + " $ kazandınız");
                           }
                           else
                           {
                               MessageBox.Show("Kazanamadınız");
                               textBox1.Clear();
                               textBox2.Clear();
                               textBox3.Clear();
                               textBox4.Clear();
                               textBox5.Clear();
                           }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kazanamadınız", "System" , MessageBoxButtons.OK, MessageBoxIcon.Information);                                            
                    }
                }
                else
                {
                    MessageBox.Show("Kazanamadınız");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

