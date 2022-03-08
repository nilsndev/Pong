namespace Pong
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AI_label1 = new System.Windows.Forms.Label();
            this.player1_label1 = new System.Windows.Forms.Label();
            this.balll_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ball_move_timer1 = new System.Windows.Forms.Timer(this.components);
            this.top_border_panel1 = new System.Windows.Forms.Panel();
            this.down_border_panel1 = new System.Windows.Forms.Panel();
            this.player2_goal_panel1 = new System.Windows.Forms.Panel();
            this.player1_goal_panel1 = new System.Windows.Forms.Panel();
            this.player1_score_label1 = new System.Windows.Forms.Label();
            this.player2_score_label1 = new System.Windows.Forms.Label();
            this.gameOver_timer1 = new System.Windows.Forms.Timer(this.components);
            this.middle_line_panel1 = new System.Windows.Forms.Panel();
            this.pause_button1 = new System.Windows.Forms.Label();
            this.menu_panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.start_game_label1 = new System.Windows.Forms.Label();
            this.AI_move_timer1 = new System.Windows.Forms.Timer(this.components);
            this.player1_front = new System.Windows.Forms.PictureBox();
            this.AI_front = new System.Windows.Forms.PictureBox();
            this.impossible_label1 = new System.Windows.Forms.Label();
            this.normal_label1 = new System.Windows.Forms.Label();
            this.paused_label1 = new System.Windows.Forms.Label();
            this.back_to_menu_label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.balll_pictureBox1)).BeginInit();
            this.menu_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1_front)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI_front)).BeginInit();
            this.SuspendLayout();
            // 
            // AI_label1
            // 
            this.AI_label1.BackColor = System.Drawing.Color.White;
            this.AI_label1.Location = new System.Drawing.Point(686, 168);
            this.AI_label1.Name = "AI_label1";
            this.AI_label1.Size = new System.Drawing.Size(30, 108);
            this.AI_label1.TabIndex = 0;
            // 
            // player1_label1
            // 
            this.player1_label1.BackColor = System.Drawing.Color.White;
            this.player1_label1.Location = new System.Drawing.Point(125, 168);
            this.player1_label1.Name = "player1_label1";
            this.player1_label1.Size = new System.Drawing.Size(30, 108);
            this.player1_label1.TabIndex = 1;
            this.player1_label1.Click += new System.EventHandler(this.player1_label1_Click);
            // 
            // balll_pictureBox1
            // 
            this.balll_pictureBox1.BackColor = System.Drawing.Color.White;
            this.balll_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balll_pictureBox1.Location = new System.Drawing.Point(398, 211);
            this.balll_pictureBox1.Name = "balll_pictureBox1";
            this.balll_pictureBox1.Size = new System.Drawing.Size(21, 22);
            this.balll_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balll_pictureBox1.TabIndex = 2;
            this.balll_pictureBox1.TabStop = false;
            this.balll_pictureBox1.Click += new System.EventHandler(this.balll_pictureBox1_Click);
            // 
            // ball_move_timer1
            // 
            this.ball_move_timer1.Interval = 10;
            this.ball_move_timer1.Tick += new System.EventHandler(this.ball_move_timer1_Tick);
            // 
            // top_border_panel1
            // 
            this.top_border_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_border_panel1.Location = new System.Drawing.Point(0, 0);
            this.top_border_panel1.Name = "top_border_panel1";
            this.top_border_panel1.Size = new System.Drawing.Size(800, 10);
            this.top_border_panel1.TabIndex = 3;
            // 
            // down_border_panel1
            // 
            this.down_border_panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.down_border_panel1.Location = new System.Drawing.Point(0, 440);
            this.down_border_panel1.Name = "down_border_panel1";
            this.down_border_panel1.Size = new System.Drawing.Size(800, 10);
            this.down_border_panel1.TabIndex = 4;
            // 
            // player2_goal_panel1
            // 
            this.player2_goal_panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.player2_goal_panel1.Location = new System.Drawing.Point(790, 10);
            this.player2_goal_panel1.Name = "player2_goal_panel1";
            this.player2_goal_panel1.Size = new System.Drawing.Size(10, 430);
            this.player2_goal_panel1.TabIndex = 5;
            // 
            // player1_goal_panel1
            // 
            this.player1_goal_panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.player1_goal_panel1.Location = new System.Drawing.Point(0, 10);
            this.player1_goal_panel1.Name = "player1_goal_panel1";
            this.player1_goal_panel1.Size = new System.Drawing.Size(10, 430);
            this.player1_goal_panel1.TabIndex = 6;
            // 
            // player1_score_label1
            // 
            this.player1_score_label1.AutoSize = true;
            this.player1_score_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1_score_label1.Location = new System.Drawing.Point(262, 72);
            this.player1_score_label1.Name = "player1_score_label1";
            this.player1_score_label1.Size = new System.Drawing.Size(50, 54);
            this.player1_score_label1.TabIndex = 7;
            this.player1_score_label1.Text = "0";
            this.player1_score_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2_score_label1
            // 
            this.player2_score_label1.AutoSize = true;
            this.player2_score_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2_score_label1.Location = new System.Drawing.Point(506, 72);
            this.player2_score_label1.Name = "player2_score_label1";
            this.player2_score_label1.Size = new System.Drawing.Size(50, 54);
            this.player2_score_label1.TabIndex = 8;
            this.player2_score_label1.Text = "0";
            this.player2_score_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameOver_timer1
            // 
            this.gameOver_timer1.Interval = 10;
            this.gameOver_timer1.Tick += new System.EventHandler(this.gameOver_timer1_Tick);
            // 
            // middle_line_panel1
            // 
            this.middle_line_panel1.BackColor = System.Drawing.Color.White;
            this.middle_line_panel1.Location = new System.Drawing.Point(403, 11);
            this.middle_line_panel1.Name = "middle_line_panel1";
            this.middle_line_panel1.Size = new System.Drawing.Size(10, 431);
            this.middle_line_panel1.TabIndex = 9;
            // 
            // pause_button1
            // 
            this.pause_button1.AutoSize = true;
            this.pause_button1.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause_button1.Location = new System.Drawing.Point(212, 339);
            this.pause_button1.Name = "pause_button1";
            this.pause_button1.Size = new System.Drawing.Size(58, 51);
            this.pause_button1.TabIndex = 10;
            this.pause_button1.Text = "| |";
            this.pause_button1.Click += new System.EventHandler(this.pause_button1_Click);
            // 
            // menu_panel1
            // 
            this.menu_panel1.Controls.Add(this.normal_label1);
            this.menu_panel1.Controls.Add(this.impossible_label1);
            this.menu_panel1.Controls.Add(this.label2);
            this.menu_panel1.Controls.Add(this.start_game_label1);
            this.menu_panel1.Location = new System.Drawing.Point(710, 375);
            this.menu_panel1.Name = "menu_panel1";
            this.menu_panel1.Size = new System.Drawing.Size(74, 45);
            this.menu_panel1.TabIndex = 11;
            this.menu_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.pause_menu_panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "EXIT GAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // start_game_label1
            // 
            this.start_game_label1.AutoSize = true;
            this.start_game_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_game_label1.Location = new System.Drawing.Point(223, 62);
            this.start_game_label1.Name = "start_game_label1";
            this.start_game_label1.Size = new System.Drawing.Size(301, 54);
            this.start_game_label1.TabIndex = 0;
            this.start_game_label1.Text = "PLAY GAME";
            this.start_game_label1.Click += new System.EventHandler(this.start_game_label1_Click);
            // 
            // AI_move_timer1
            // 
            this.AI_move_timer1.Interval = 1;
            this.AI_move_timer1.Tick += new System.EventHandler(this.AI_move_timer1_Tick);
            // 
            // player1_front
            // 
            this.player1_front.BackColor = System.Drawing.Color.White;
            this.player1_front.Location = new System.Drawing.Point(145, 168);
            this.player1_front.Name = "player1_front";
            this.player1_front.Size = new System.Drawing.Size(10, 108);
            this.player1_front.TabIndex = 12;
            this.player1_front.TabStop = false;
            this.player1_front.Visible = false;
            // 
            // AI_front
            // 
            this.AI_front.BackColor = System.Drawing.Color.White;
            this.AI_front.Location = new System.Drawing.Point(687, 168);
            this.AI_front.Name = "AI_front";
            this.AI_front.Size = new System.Drawing.Size(10, 108);
            this.AI_front.TabIndex = 13;
            this.AI_front.TabStop = false;
            this.AI_front.Visible = false;
            // 
            // impossible_label1
            // 
            this.impossible_label1.AutoSize = true;
            this.impossible_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impossible_label1.Location = new System.Drawing.Point(312, 251);
            this.impossible_label1.Name = "impossible_label1";
            this.impossible_label1.Size = new System.Drawing.Size(115, 25);
            this.impossible_label1.TabIndex = 2;
            this.impossible_label1.Text = "Impossible";
            this.impossible_label1.Click += new System.EventHandler(this.impossible_label1_Click);
            // 
            // normal_label1
            // 
            this.normal_label1.AutoSize = true;
            this.normal_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normal_label1.Location = new System.Drawing.Point(329, 173);
            this.normal_label1.Name = "normal_label1";
            this.normal_label1.Size = new System.Drawing.Size(80, 25);
            this.normal_label1.TabIndex = 3;
            this.normal_label1.Text = "Normal";
            this.normal_label1.Click += new System.EventHandler(this.normal_label1_Click);
            // 
            // paused_label1
            // 
            this.paused_label1.AutoSize = true;
            this.paused_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paused_label1.Location = new System.Drawing.Point(168, 11);
            this.paused_label1.Name = "paused_label1";
            this.paused_label1.Size = new System.Drawing.Size(471, 135);
            this.paused_label1.TabIndex = 14;
            this.paused_label1.Text = "Paused";
            this.paused_label1.Visible = false;
            // 
            // back_to_menu_label1
            // 
            this.back_to_menu_label1.AutoSize = true;
            this.back_to_menu_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_to_menu_label1.Location = new System.Drawing.Point(282, 269);
            this.back_to_menu_label1.Name = "back_to_menu_label1";
            this.back_to_menu_label1.Size = new System.Drawing.Size(259, 42);
            this.back_to_menu_label1.TabIndex = 15;
            this.back_to_menu_label1.Text = "Back to Menu";
            this.back_to_menu_label1.Visible = false;
            this.back_to_menu_label1.Click += new System.EventHandler(this.back_to_menu_label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu_panel1);
            this.Controls.Add(this.paused_label1);
            this.Controls.Add(this.AI_front);
            this.Controls.Add(this.player1_front);
            this.Controls.Add(this.back_to_menu_label1);
            this.Controls.Add(this.pause_button1);
            this.Controls.Add(this.balll_pictureBox1);
            this.Controls.Add(this.middle_line_panel1);
            this.Controls.Add(this.player1_goal_panel1);
            this.Controls.Add(this.player2_goal_panel1);
            this.Controls.Add(this.down_border_panel1);
            this.Controls.Add(this.top_border_panel1);
            this.Controls.Add(this.player1_label1);
            this.Controls.Add(this.AI_label1);
            this.Controls.Add(this.player2_score_label1);
            this.Controls.Add(this.player1_score_label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.balll_pictureBox1)).EndInit();
            this.menu_panel1.ResumeLayout(false);
            this.menu_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1_front)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI_front)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AI_label1;
        private System.Windows.Forms.Label player1_label1;
        private System.Windows.Forms.PictureBox balll_pictureBox1;
        private System.Windows.Forms.Timer ball_move_timer1;
        private System.Windows.Forms.Panel top_border_panel1;
        private System.Windows.Forms.Panel down_border_panel1;
        private System.Windows.Forms.Panel player2_goal_panel1;
        private System.Windows.Forms.Panel player1_goal_panel1;
        private System.Windows.Forms.Label player1_score_label1;
        private System.Windows.Forms.Label player2_score_label1;
        private System.Windows.Forms.Timer gameOver_timer1;
        private System.Windows.Forms.Panel middle_line_panel1;
        private System.Windows.Forms.Label pause_button1;
        private System.Windows.Forms.Panel menu_panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label start_game_label1;
        private System.Windows.Forms.Timer AI_move_timer1;
        private System.Windows.Forms.PictureBox player1_front;
        private System.Windows.Forms.PictureBox AI_front;
        private System.Windows.Forms.Label impossible_label1;
        private System.Windows.Forms.Label normal_label1;
        private System.Windows.Forms.Label paused_label1;
        private System.Windows.Forms.Label back_to_menu_label1;
    }
}