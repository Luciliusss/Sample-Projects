using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_Oyuncuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void XOX_click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (label1.Text == "X")
            {
                button.Text = "X";
                button.Enabled = false;
                label1.Text = "O";
            }

            else
            {
                button.Text = "O";
                button.Enabled = false;
                label1.Text = "X";
            }


            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("Oyunu kazanan : X");
                GameEnd();
            }

            if (button6.Text == "X" && button5.Text == "X" && button4.Text == "X")
            {
                MessageBox.Show("Oyunu kazanan : X");
                GameEnd();
            }

            if (button9.Text == "X" && button8.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Oyunu kazanan : X");
                GameEnd();
            }

            if (button1.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Oyunu kazanan : X");
                GameEnd();
            }

            if (button5.Text == "X" && button2.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("Oyunu kazanan : X");
                GameEnd();
            }

            if (button4.Text == "X" && button7.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("Oyunu kazanan : X");
                GameEnd();
            }

            if (button9.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("Oyunu kazanan : X");
                GameEnd();
            }

            if (button7.Text == "X" && button5.Text == "X" && button1.Text == "X")
            {
                MessageBox.Show("Oyunu kazanan : X");
                GameEnd();
            }

            //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX//
            //-------------------------------------------------------------------//
            //OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO//

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("Oyunu kazanan : O");
                GameEnd();
            }

            if (button6.Text == "O" && button5.Text == "O" && button4.Text == "O")
            {
                MessageBox.Show("Oyunu kazanan : O");
                GameEnd();
            }

            if (button9.Text == "O" && button8.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Oyunu kazanan : O");
                GameEnd();
            }

            if (button1.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Oyunu kazanan : O");
                GameEnd();
            }

            if (button5.Text == "O" && button2.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("Oyunu kazanan : O");
                GameEnd();
            }

            if (button4.Text == "O" && button7.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("Oyunu kazanan : O");
                GameEnd();
            }

            if (button9.Text == "O" && button5.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("Oyunu kazanan : O");
                GameEnd();
            }

            if (button7.Text == "O" && button5.Text == "O" && button1.Text == "O")
            {
                MessageBox.Show("Oyunu kazanan : O");
                GameEnd();
            }

            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "" )
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Kimse kazanamadı Oyun yeniden başlasınmı", "System", MessageBoxButtons.YesNo , MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    MessageBox.Show("Oyun yeniden başlatılıyor");
                    GameEnd();
                }

                else
                {
                    MessageBox.Show("Oyun kapatılıyor");
                    this.Close();
                }
            }
        }
        private void GameEnd()
        {
            label1.Text = "X";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";                              
        }
    }
}
