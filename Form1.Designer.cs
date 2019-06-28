namespace pong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.points1 = new System.Windows.Forms.Label();
            this.points2 = new System.Windows.Forms.Label();
            this.pause_txt = new System.Windows.Forms.Label();
            this.paddle = new System.Windows.Forms.PictureBox();
            this.paddle2 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.moveBall);
            // 
            // points1
            // 
            this.points1.AutoSize = true;
            this.points1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points1.ForeColor = System.Drawing.Color.White;
            this.points1.Location = new System.Drawing.Point(2, -1);
            this.points1.Name = "points1";
            this.points1.Size = new System.Drawing.Size(98, 26);
            this.points1.TabIndex = 3;
            this.points1.Text = "Player: 0";
            // 
            // points2
            // 
            this.points2.AutoSize = true;
            this.points2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points2.ForeColor = System.Drawing.Color.White;
            this.points2.Location = new System.Drawing.Point(2, 37);
            this.points2.Name = "points2";
            this.points2.Size = new System.Drawing.Size(83, 26);
            this.points2.TabIndex = 4;
            this.points2.Text = "CPU: 0";
            // 
            // pause_txt
            // 
            this.pause_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pause_txt.AutoSize = true;
            this.pause_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause_txt.ForeColor = System.Drawing.Color.White;
            this.pause_txt.Location = new System.Drawing.Point(144, 149);
            this.pause_txt.Name = "pause_txt";
            this.pause_txt.Size = new System.Drawing.Size(74, 24);
            this.pause_txt.TabIndex = 5;
            this.pause_txt.Text = "Paused";
            // 
            // paddle
            // 
            this.paddle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.paddle.Image = ((System.Drawing.Image)(resources.GetObject("paddle.Image")));
            this.paddle.Location = new System.Drawing.Point(128, 283);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(75, 23);
            this.paddle.TabIndex = 6;
            this.paddle.TabStop = false;
            // 
            // paddle2
            // 
            this.paddle2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.paddle2.Image = ((System.Drawing.Image)(resources.GetObject("paddle2.Image")));
            this.paddle2.Location = new System.Drawing.Point(91, 16);
            this.paddle2.Name = "paddle2";
            this.paddle2.Size = new System.Drawing.Size(75, 23);
            this.paddle2.TabIndex = 7;
            this.paddle2.TabStop = false;
            // 
            // ball
            // 
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(124, 105);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(23, 23);
            this.ball.TabIndex = 8;
            this.ball.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(351, 318);
            this.Controls.Add(this.paddle2);
            this.Controls.Add(this.paddle);
            this.Controls.Add(this.pause_txt);
            this.Controls.Add(this.points2);
            this.Controls.Add(this.points1);
            this.Controls.Add(this.ball);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Pong #";
            this.ResizeEnd += new System.EventHandler(this.movePaddles);
            this.Click += new System.EventHandler(this.pause);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label points1;
        private System.Windows.Forms.Label points2;
        private System.Windows.Forms.Label pause_txt;
        private System.Windows.Forms.PictureBox paddle;
        private System.Windows.Forms.PictureBox paddle2;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer2;
    }
}

