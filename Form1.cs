using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeGame.Properties;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int CurrentPlayerNumber = 0;
       Image CurrentPlayerIm = Resources.X;
        int Count = 0;

        void ResetPictureBox(PictureBox pictureBox)
        {
            pictureBox.Image = Resources.question_mark_96;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Tag = "0";
        }
        void ResetForm()
        {
            // REset the Images 
            ResetPictureBox(pb1);
            ResetPictureBox(pb2);
            ResetPictureBox(pb3);
            ResetPictureBox(pb4);
            ResetPictureBox(pb5);
            ResetPictureBox(pb6);
            ResetPictureBox(pb7);
            ResetPictureBox(pb8);
            ResetPictureBox(pb9);

            Count = 0;
            CurrentPlayerNumber = 1;
            lbTurn.Text = "Player 1";
            lbWinner.Text = "In Progress";
        }
        string PlayerTurn()
        {
            string Name = "";

            if(CurrentPlayerNumber == 1)
            {
                Name = "Player 2";
                CurrentPlayerIm = Resources.X;
                CurrentPlayerNumber = 2;
            }
            else
            {
                Name = "Player 1";
                CurrentPlayerIm = Resources.O;
                CurrentPlayerNumber = 1;
            }
            return Name;
        }
        void NextPlayer()
        {
            Count++;
            lbTurn.Text = PlayerTurn();
        }

        string CheckWinSituation(PictureBox pb1,  PictureBox pb2, PictureBox pb3)
        {
            string Winner = "";
            if (Convert.ToInt32(pb1.Tag) != 0 && (Convert.ToInt32(pb1.Tag) == Convert.ToInt32(pb2.Tag)) && (Convert.ToInt32(pb1.Tag) == Convert.ToInt32(pb3.Tag)))
            {
                if (Convert.ToInt32(pb1.Tag) == 1)
                    Winner = "Player 1";
                else
                    Winner = "Player 2";
                if (Winner != "")
                {
                    pb1.BackColor = Color.Green;
                    pb2.BackColor = Color.Green;
                    pb3.BackColor = Color.Green;
                }
            }
            return Winner;
        }
        string WhoWon()
        {
            string Winner = "";

            // Situation 1
            Winner = CheckWinSituation(pb1, pb2, pb3);
            if (Winner == "Player 1" || Winner == "Player 2")
                return Winner;

            // Situation 2
            Winner = CheckWinSituation(pb4, pb5, pb6);
            if (Winner == "Player 1" || Winner == "Player 2")
                return Winner;

            // Situation 3
            Winner = CheckWinSituation(pb7, pb8, pb9);
            if (Winner == "Player 1" || Winner == "Player 2")
                return Winner;

            // Situation 4
            Winner = CheckWinSituation(pb1, pb4, pb7);
            if (Winner == "Player 1" || Winner == "Player 2")
                return Winner;

            // Situation 5
            Winner = CheckWinSituation(pb2, pb5, pb8);
            if (Winner == "Player 1" || Winner == "Player 2")
                return Winner;

            // Situation 6
            Winner = CheckWinSituation(pb3, pb6, pb9);
            if (Winner == "Player 1" || Winner == "Player 2")
                return Winner;

            // Situation 7
            Winner = CheckWinSituation(pb1, pb5, pb9);
            if (Winner == "Player 1" || Winner == "Player 2")
                return Winner;

            // Situation 8
            Winner = CheckWinSituation(pb3, pb5, pb7);
            if (Winner == "Player 1" || Winner == "Player 2")
                return Winner;


            if (Winner == "")
                return "In Progress";
            else
                return Winner;
        }

 
        
        void Winner()
        {
            string Winner = WhoWon();
            if(Count == 9 && Winner == "In Progress") {
                Winner = "Draw";
            }
            
            lbWinner.Text = Winner;
            if (Winner == "Player 1" || Winner == "Player 2")
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;
            Pen Pen = new Pen(White);
            Pen.Width = 10;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            // Vertical Line
            e.Graphics.DrawLine(Pen, 470, 105, 470, 405);
            e.Graphics.DrawLine(Pen, 670, 105, 670, 405);

            // Horizontal Lines
            e.Graphics.DrawLine(Pen, 300, 200, 850, 200);
            e.Graphics.DrawLine(Pen, 300, 310, 850, 310);
        }

  


        private void Form1_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            ResetForm();
        }



     
        private void pictureBox_MouseClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (lbWinner.Text == "Player 1" || lbWinner.Text == "Player 2")
            {
                MessageBox.Show("Game Over, Restart Another Game", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(pb.Tag) != 0)
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                if (CurrentPlayerNumber == 1)
                    pb.Tag = "1";
                else
                    pb.Tag = "2";
                NextPlayer();
                pb.Image = CurrentPlayerIm;
                Winner();
            }
        }
    }
}
