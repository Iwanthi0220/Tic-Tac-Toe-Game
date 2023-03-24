using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        char who = 'o';
        short movement = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            bt.BackColor = Color.Blue;
            if (who == 'o') 
            {
                bt.Text = "0";
                if ((btn1.Text == btn_2.Text && btn_2.Text == btn3.Text && btn_2.Text != "") ||
                         
                         (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn5.Text != "") ||
                         (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn8.Text != "") ||
                         (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn4.Text != "") ||
                         (btn_2.Text == btn5.Text && btn5.Text == btn8.Text && btn5.Text != "") ||
                         (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn6.Text != "") ||
                         (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn5.Text != "") ||
                         (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn5.Text != "")) 
                         
                {
                    MessageBox.Show(("The Winner is { who.ToString().ToUpper()}  !!!!"));
                    tableLayoutPanel1.Enabled = false;
                }
               else if (movement==8)
                {
                    MessageBox.Show("Draw!!!");
                }
                who = 'x';

            }
            else if (who =='x')
            {
                bt.Text = "x";
                if ((btn1.Text == btn_2.Text && btn_2.Text == btn3.Text && btn_2.Text != "") ||

                        (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn5.Text != "") ||
                        (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn8.Text != "") ||
                        (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn4.Text != "") ||
                        (btn_2.Text == btn5.Text && btn5.Text == btn8.Text && btn5.Text != "") ||
                        (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn6.Text != "") ||
                        (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn5.Text != "") ||
                        (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn5.Text != ""))

                {
                    MessageBox.Show(("The Winner is { who.ToString().ToUpper()}"));
                    tableLayoutPanel1.Enabled = false;
                }

                else if (movement == 8)
                {
                    MessageBox.Show("Draw!!!");
                }
                who = 'o';
              
            }
            movement++;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
         
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Game is Tic Tac Toe");
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            who = 'o';
            movement = 0;

            btn1.Enabled = true; btn1.Text = ""; btn1.BackColor = Color.White;
            btn_2.Enabled = true; btn1.Text = ""; btn_2.BackColor = Color.White;
            btn3.Enabled = true; btn1.Text = ""; btn3.BackColor = Color.White;
            btn4.Enabled = true; btn1.Text = ""; btn4.BackColor = Color.White;
            btn5.Enabled = true; btn1.Text = ""; btn5.BackColor = Color.White;
            btn6.Enabled = true; btn1.Text = ""; btn6.BackColor = Color.White;
            btn7.Enabled = true; btn1.Text = ""; btn7.BackColor = Color.White;
            btn8.Enabled = true; btn1.Text = ""; btn8.BackColor = Color.White;
            btn9.Enabled = true; btn1.Text = ""; btn9.BackColor = Color.White;
            tableLayoutPanel1.Enabled = true;
        }
    }
}
