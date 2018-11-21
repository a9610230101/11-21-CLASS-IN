using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardsWindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Create a Random object.
        Random rand= new Random();
        //比大小的method
        private bool game()
        {

            bool win = false;//預設玩家是輸家
            //Create a Random object.
            Random rand = new Random();

            //Get a random index.
            int playerindex = rand.Next(cardsImageList.Images.Count);
            int dealerIndex = rand.Next(cardsImageList.Images.Count);
            //Display a card
            pictureBox1.Image = cardsImageList.Images[playerindex];
            pictureBox2.Visible = false;
            pictureBox2.Image = cardsImageList.Images[dealerIndex];

            DialogResult answer;
            string result = "";
            //玩家比大小
            answer = MessageBox.Show("請問要賭比莊家大嗎", "比大小", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (answer == DialogResult.Yes)
            {
                if (playerindex > dealerIndex)
                {
                    result = "你贏了";
                }
                else
                {
                    result = "你輸了";
                }
            }//end of if answer = DialogResult.Yes
            else //選擇比小
            {
                if (playerindex < dealerIndex)
                {
                    result = "你贏了";
                }
                else
                {
                    result = "你輸了";
                }
            }//End of else
            //揭曉莊家的
            pictureBox2.Visible = true;
            if (result == "你贏了")
            {
                win = true;//玩家贏了
            }
            return win;//回傳玩家的輸贏
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool result;
            result = game();
            if (result == true)
            {
                MessageBox.Show("你贏了");
                progressBar1.PerformStep();
            }
            else
            {
                MessageBox.Show("你輸了");
            }
            result = game();
            if (result == true)
            {
                MessageBox.Show("你贏了");
                progressBar1.PerformStep();
            }
            else
            {
                MessageBox.Show("你輸了");
            }
            MessageBox.Show("兩次遊戲已經結束 如果要繼續請按一次發牌");
            button1.Enabled = true;
            progressBar1.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
