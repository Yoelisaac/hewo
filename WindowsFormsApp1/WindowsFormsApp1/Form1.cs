using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string jawaban;
        private string[] word = new string[5];
        private string clicked;
        int menang = 0;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void HurufJawaban()
        {
            if (clicked == word[0])
            {
                jawaban1.Text = clicked;
                menang = menang + 1;
            }
            if (clicked == word[1])
            {
                jawaban2.Text = clicked;
                menang = menang + 1;
            }
            if (clicked == word[2])
            {
                jawaban3.Text = clicked;
                menang = menang + 1;
            }
            if (clicked == word[3])
            {
                jawaban4.Text = clicked;
                menang = menang + 1;
            }
            if (clicked == word[4])
            {
                jawaban5.Text = clicked;
                menang = menang + 1;
            }

            if (menang == 5)
            {
                MessageBox.Show("Selamat! Anda menang");
                Close();

            }
        }

        private void btn_cek_Click_1(object sender, EventArgs e)
        {
            string box1 = tb1.Text;
            string box2 = tb2.Text;
            string box3 = tb3.Text;
            string box4 = tb4.Text;
            string box5 = tb5.Text;
            int jmlh_box1 = box1.Length;
            int jmlh_box2 = box2.Length;
            int jmlh_box3 = box3.Length;
            int jmlh_box4 = box4.Length;
            int jmlh_box5 = box5.Length;


            if (box1 == box2 || box1 == box3 || box1 == box4 || box1 == box5)
            {
                MessageBox.Show("Error, ada kata yg sama");
            }
            else if (box2 == box1 || box2 == box3 || box2 == box4 || box2 == box5)
            {
                MessageBox.Show("Error, ada kata yg sama");
            }
            else if (box3 == box1 || box3 == box2 || box3 == box4 || box3 == box5)
            {
                MessageBox.Show("Error, ada kata yg sama");
            }
            else if (box4 == box1 || box4 == box3 || box4 == box2 || box4 == box5)
            {
                MessageBox.Show("Error, ada kata yg sama");
            }
            else if (box5 == box1 || box5 == box3 || box5 == box4 || box5 == box2)
            {
                MessageBox.Show("Error, ada kata yg sama");
            }
            else
            {
                if (jmlh_box1 != 5 || jmlh_box2 != 5 || jmlh_box3 != 5 || jmlh_box4 != 5 || jmlh_box5 != 5)
                {
                    MessageBox.Show("Error, kata harus 5");
                }

                else
                {
                    MessageBox.Show("Mari bermain");
                    page2.Visible = true;


                    Random rnd = new Random();
                    int huruf = rnd.Next(0, 5);

                    if (huruf == 0)
                    {
                        jawaban = tb1.Text;
                    }
                    if (huruf == 1)
                    {
                        jawaban = tb2.Text;
                    }
                    if (huruf == 2)
                    {
                        jawaban = tb3.Text;
                    }
                    if (huruf == 3)
                    {
                        jawaban = tb4.Text;
                    }
                    if (huruf == 4)
                    {
                        jawaban = tb5.Text;
                    }
                    int i = 0;
                    foreach (char alphabet in jawaban)
                    {
                        string alfabet = alphabet.ToString();
                        word[i] = alfabet;
                        i++;
                    }




                }

            }



        }

        private void buttonE_Click_1(object sender, EventArgs e)
        {
            clicked = "E";
            HurufJawaban();
        }

        private void buttonQ_Click_1(object sender, EventArgs e)
        {
            clicked = "Q";
            HurufJawaban();
        }

        private void buttonW_Click_1(object sender, EventArgs e)
        {
            clicked = "W";
            HurufJawaban();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            clicked = "R";
            HurufJawaban();
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            clicked = "T";
            HurufJawaban();
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            clicked = "Y";
            HurufJawaban();
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            clicked = "U";
            HurufJawaban();
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            clicked = "I";
            HurufJawaban();
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            clicked = "O";
            HurufJawaban();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            clicked = "P";
            HurufJawaban();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            clicked = "A";
            HurufJawaban();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            clicked = "S";
            HurufJawaban();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            clicked = "D";
            HurufJawaban();
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            clicked = "F";
            HurufJawaban();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            clicked = "G";
            HurufJawaban();
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            clicked = "H";
            HurufJawaban();
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            clicked = "J";
            HurufJawaban();
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            clicked = "K";
            HurufJawaban();
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            clicked = "L";
            HurufJawaban();
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            clicked = "Z";
            HurufJawaban();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            clicked = "X";
            HurufJawaban();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            clicked = "C";
            HurufJawaban();
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            clicked = "V";
            HurufJawaban();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            clicked = "B";
            HurufJawaban();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            clicked = "N";
            HurufJawaban();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            clicked = "M";
            HurufJawaban();
        }
    }
    }
