using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pong
{
    public partial class MainForm : Form
    {
        bool clicked = false;
        int ballXSpeed = 2;
        int ballYSpeed = 2;
        Level l = new Level();
        int player2Score = 0;
        int player1Score = 0;
        bool ballMoveUp,ballMoveDown,ballMoveLeft,ballMoveRight;


        public enum Level
        {
            Normal,
            Impossible
        }
        private void ball_move_timer1_Tick(object sender, EventArgs e)
        {
           

             checkBallBounds();

         
            if (ballMoveLeft && ballMoveDown)
            {
                balll_pictureBox1.Location = new Point(balll_pictureBox1.Location.X - ballXSpeed,
                                                       balll_pictureBox1.Location.Y -ballYSpeed);

            }
            if (ballMoveLeft && ballMoveUp)
            {
                balll_pictureBox1.Location = new Point(balll_pictureBox1.Location.X - ballXSpeed,
                                                       balll_pictureBox1.Location.Y + ballYSpeed);

            }
            if (ballMoveRight && ballMoveDown)
            {
                balll_pictureBox1.Location = new Point(balll_pictureBox1.Location.X + ballXSpeed,
                                                       balll_pictureBox1.Location.Y - ballYSpeed);

            }
            if (ballMoveRight && ballMoveUp)
            {
                balll_pictureBox1.Location = new Point(balll_pictureBox1.Location.X + ballXSpeed,
                                                       balll_pictureBox1.Location.Y + ballYSpeed);

            }
            player1_front.Location = new Point(player1_front.Location.X, player1_label1.Location.Y);

        }

        private void player1_label1_Click(object sender, EventArgs e)
        {

        }

        public MainForm()
        {

           
            InitializeComponent();
            ballMoveDown = true;
            ballMoveLeft = true;
        }

        private void gameOver_timer1_Tick(object sender, EventArgs e)
        {
            if(player1Score >= 10 || player2Score >= 10)
            {
                ball_move_timer1.Enabled = false;
                menu_panel1.Visible = true;
                AI_move_timer1.Enabled = false;
                gameOver_timer1.Enabled = false;
               
            }
        }

        private void balll_pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void start_game_label1_Click(object sender, EventArgs e)
        {
            menu_panel1.Visible = false;
            player2Score = 0;
            player1Score = 0;
            player1_score_label1.Text = "0";
            player2_score_label1.Text = "0";
            ball_move_timer1.Start();
            gameOver_timer1.Start();
            AI_move_timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pause_menu_panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pause_button1_Click(object sender, EventArgs e)
        {
            if (!clicked)
            {
                back_to_menu_label1.Visible = true;
                paused_label1.Visible = true;
                ball_move_timer1.Stop();
                gameOver_timer1.Stop();
                AI_move_timer1.Stop();
                clicked = true;
            }
            else
            {
                back_to_menu_label1.Visible = false;
                paused_label1.Visible = false;
                ball_move_timer1.Start();
                gameOver_timer1.Start();
                AI_move_timer1.Start();
                clicked = false;
            }

        }

        private void AI_move_timer1_Tick(object sender, EventArgs e)
        {
            if(l == Level.Normal)
            {
                if (AI_label1.Location.Y < 322)
                    if (ballMoveUp)
                    {
                        AI_label1.Location = new Point(AI_label1.Location.X,AI_label1.Location.Y + 1);
                    }
                if (ballMoveDown)
                {
                    AI_label1.Location = new Point(AI_label1.Location.X, AI_label1.Location.Y - 1);
                }
            }

            if (l == Level.Impossible)
            {
                if (balll_pictureBox1.Location.Y < 322)
                    AI_label1.Location = new Point(AI_label1.Location.X, balll_pictureBox1.Location.Y);
            }
            AI_front.Location = new Point(AI_front.Location.X, AI_label1.Location.Y);

        }

        private void normal_label1_Click(object sender, EventArgs e)
        {
            
            l = Level.Normal;
        }

        private void impossible_label1_Click(object sender, EventArgs e)
        {
          
            l = Level.Impossible;
        }

        private void back_to_menu_label1_Click(object sender, EventArgs e)
        {
            paused_label1.Visible = false;
            back_to_menu_label1.Visible = false;
            menu_panel1.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            menu_panel1.Dock =  DockStyle.Fill;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Move player1 Up ------------------------------------------
            if(e.KeyCode == Keys.W)

            {
                if (player1_label1.Bounds.IntersectsWith(top_border_panel1.Bounds)) return;
                player1_label1.Top -= 10;

            }
            //-----------------------------------------------------------

            // Move player1 down ----------------------------------------
            if (e.KeyCode == Keys.S)
            {
                if (player1_label1.Bounds.IntersectsWith(down_border_panel1.Bounds)) return;
                player1_label1.Top += 10;
            }
            //-----------------------------------------------------------

           
        }

        #region Methoden
        void checkBallBounds()
        {
            // Ball bounds Up or Down panel-------------------------------
            if (balll_pictureBox1.Bounds.IntersectsWith(down_border_panel1.Bounds) || balll_pictureBox1.Bounds.IntersectsWith(top_border_panel1.Bounds))
            {
                ballXSpeed = 2;
                ballYSpeed = 3;
                ballMoveUp = !ballMoveUp;
                ballMoveDown = !ballMoveDown;
            }
            //-----------------------------------------------------------

            // Ball bounds Player1 or Player2----------------------------
            if (balll_pictureBox1.Bounds.IntersectsWith(player1_front.Bounds) || balll_pictureBox1.Bounds.IntersectsWith(AI_label1.Bounds))
            {
                ballXSpeed = 3;
                ballYSpeed = 2;
                ballMoveLeft = !ballMoveLeft;
                ballMoveRight = !ballMoveRight;
            }
            //-----------------------------------------------------------

            // Ball in player1 Goal--------------------------------------
            if (balll_pictureBox1.Bounds.IntersectsWith(player1_goal_panel1.Bounds))
            {
                player2Score++;
                player2_score_label1.Text = player2Score.ToString();
                balll_pictureBox1.Location = new Point(395, 199);
            }
            //-----------------------------------------------------------

            // Ball in player2 Goal--------------------------------------
            if (balll_pictureBox1.Bounds.IntersectsWith(player2_goal_panel1.Bounds))
            {
                player1Score++;
                player1_score_label1.Text = player1Score.ToString();
                balll_pictureBox1.Location = new Point(395, 199);
            }
            //-----------------------------------------------------------

        }
        #endregion
    }
}
