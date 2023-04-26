using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public enum Player
        {
            X, O
        }
        Player currentplayer;
        Random random = new Random();
        int playerwincount = 0;
        int CpuWincount = 0;
        List<Button> buttons;
        public Form1()
        {
            InitializeComponent();
            Reset();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CPUMove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentplayer = Player.O;
                buttons[index].Text = currentplayer.ToString();
                buttons[index].BackColor = Color.Orange;
                buttons.RemoveAt(index);
                Checkgame();
                CPUTimer.Stop();
            }
        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentplayer = Player.X;
            button.Text = currentplayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Blue;
            buttons.Remove(button);
            Checkgame();
            CPUTimer.Start();

        }

        private void RestartGame(object sender, EventArgs e)
        {
            Reset();
        }
        private void Checkgame()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                   || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                   || button7.Text == "X" && button9.Text == "X" && button8.Text == "X"
                   || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                   || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                   || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                   || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                   || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                CPUTimer.Stop();
                MessageBox.Show("Player Wins!");
                playerwincount++;
                label1.Text = "Player Wins" + playerwincount;
                Reset();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
           || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
           || button7.Text == "O" && button9.Text == "O" && button8.Text == "O"
           || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
           || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
           || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
           || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
           || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                CPUTimer.Stop();
                MessageBox.Show("CPU Wins!");
                CpuWincount++;
                label1.Text = "CPU Wins" + CpuWincount;
                Reset();
            }
        }
                private void Reset()
                {
                    buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
                    foreach (Button x in buttons)
                    {
                        x.Enabled = true;
                        x.Text = "?";
                        x.BackColor = Color.White;
                    }
                }
            }
        }
    

