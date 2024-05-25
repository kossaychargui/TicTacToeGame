namespace TicTacToeGame
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTurn = new System.Windows.Forms.Label();
            this.lbWinner = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.btnRestartGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(549, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(117, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(95, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 59);
            this.label3.TabIndex = 2;
            this.label3.Text = "Winner";
            // 
            // lbTurn
            // 
            this.lbTurn.AutoSize = true;
            this.lbTurn.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurn.ForeColor = System.Drawing.SystemColors.Window;
            this.lbTurn.Location = new System.Drawing.Point(103, 189);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(162, 54);
            this.lbTurn.TabIndex = 3;
            this.lbTurn.Text = "Player 1";
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinner.ForeColor = System.Drawing.Color.Lime;
            this.lbWinner.Location = new System.Drawing.Point(88, 339);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(218, 54);
            this.lbWinner.TabIndex = 4;
            this.lbWinner.Text = "In Progress";
            // 
            // pb1
            // 
            this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1.Image = global::TicTacToeGame.Properties.Resources.question_mark_96;
            this.pb1.InitialImage = global::TicTacToeGame.Properties.Resources.question_mark_96;
            this.pb1.Location = new System.Drawing.Point(423, 148);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(169, 60);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 5;
            this.pb1.TabStop = false;
            this.pb1.Tag = "0";
            this.pb1.Click += new System.EventHandler(this.pictureBox_MouseClick);

            // 
            // pb4
            // 
            this.pb4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb4.Image = global::TicTacToeGame.Properties.Resources.question_mark_96;
            this.pb4.InitialImage = global::TicTacToeGame.Properties.Resources.question_mark_96;
            this.pb4.Location = new System.Drawing.Point(423, 281);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(169, 60);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 6;
            this.pb4.TabStop = false;
            this.pb4.Tag = "0";
            this.pb4.Click += new System.EventHandler(this.pictureBox_MouseClick);

            // 
            // pb7
            // 
            this.pb7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb7.Image = global::TicTacToeGame.Properties.Resources.question_mark_96;
            this.pb7.InitialImage = global::TicTacToeGame.Properties.Resources.question_mark_96;
            this.pb7.Location = new System.Drawing.Point(423, 412);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(169, 60);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb7.TabIndex = 7;
            this.pb7.TabStop = false;
            this.pb7.Tag = "0";
            this.pb7.Click += new System.EventHandler(this.pictureBox_MouseClick);

            // 
            // pb2
            // 
            this.pb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb2.Image = global::TicTacToeGame.Properties.Resources.question_mark_96;
            this.pb2.InitialImage = global::TicTacToeGame.Properties.Resources.question_mark_96;
            this.pb2.Location = new System.Drawing.Point(679, 148);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(169, 60);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 8;
            this.pb2.TabStop = false;
            this.pb2.Tag = "0";
            this.pb2.Click += new System.EventHandler(this.pictureBox_MouseClick);

            // 
            // pb5
            // 
            this.pb5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb5.Image = global::TicTacToeGame.Properties.Resources.question_mark_96;
            this.pb5.InitialImage = global::TicTacToeGame.Properties.Resources.question_mark_96;
            this.pb5.Location = new System.Drawing.Point(679, 281);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(169, 60);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 9;
            this.pb5.TabStop = false;
            this.pb5.Tag = "0";
            this.pb5.Click += new System.EventHandler(this.pictureBox_MouseClick);

            // 
            // pb8
            // 
            this.pb8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb8.Image = global::TicTacToeGame.Properties.Resources.question_mark_96;
            this.pb8.InitialImage = global::TicTacToeGame.Properties.Resources.question_mark_96;
            this.pb8.Location = new System.Drawing.Point(679, 412);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(169, 60);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb8.TabIndex = 10;
            this.pb8.TabStop = false;
            this.pb8.Tag = "0";
            this.pb8.Click += new System.EventHandler(this.pictureBox_MouseClick);

            // 
            // pb3
            // 
            this.pb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb3.Image = global::TicTacToeGame.Properties.Resources.question_mark_96;
            this.pb3.InitialImage = global::TicTacToeGame.Properties.Resources.question_mark_96;
            this.pb3.Location = new System.Drawing.Point(934, 148);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(169, 60);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 11;
            this.pb3.TabStop = false;
            this.pb3.Tag = "0";
            this.pb3.Click += new System.EventHandler(this.pictureBox_MouseClick);

            // 
            // pb6
            // 
            this.pb6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb6.Image = global::TicTacToeGame.Properties.Resources.question_mark_96;
            this.pb6.InitialImage = global::TicTacToeGame.Properties.Resources.question_mark_96;
            this.pb6.Location = new System.Drawing.Point(934, 281);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(169, 60);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb6.TabIndex = 12;
            this.pb6.TabStop = false;
            this.pb6.Tag = "0";
            this.pb6.Click += new System.EventHandler(this.pictureBox_MouseClick);

            // 
            // pb9
            // 
            this.pb9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb9.Image = global::TicTacToeGame.Properties.Resources.question_mark_96;
            this.pb9.InitialImage = global::TicTacToeGame.Properties.Resources.question_mark_96;
            this.pb9.Location = new System.Drawing.Point(934, 412);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(169, 60);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb9.TabIndex = 13;
            this.pb9.TabStop = false;
            this.pb9.Tag = "0";
            this.pb9.Click += new System.EventHandler(this.pictureBox_MouseClick);

            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.Black;
            this.btnRestartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartGame.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.White;
            this.btnRestartGame.Location = new System.Drawing.Point(112, 419);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(155, 53);
            this.btnRestartGame.TabIndex = 14;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1286, 554);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lbWinner);
            this.Controls.Add(this.lbTurn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.Button btnRestartGame;
    }
}

