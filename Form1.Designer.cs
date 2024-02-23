
namespace CarGame
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
            this.Score = new System.Windows.Forms.Label();
            this.panalGame = new System.Windows.Forms.Panel();
            this.labelgame = new System.Windows.Forms.Label();
            this.Car2 = new System.Windows.Forms.PictureBox();
            this.Car1 = new System.Windows.Forms.PictureBox();
            this.Car = new System.Windows.Forms.PictureBox();
            this.Line3 = new System.Windows.Forms.PictureBox();
            this.Line2 = new System.Windows.Forms.PictureBox();
            this.Line6 = new System.Windows.Forms.PictureBox();
            this.Line4 = new System.Windows.Forms.PictureBox();
            this.Line5 = new System.Windows.Forms.PictureBox();
            this.Line1 = new System.Windows.Forms.PictureBox();
            this.TimerGame = new System.Windows.Forms.Timer(this.components);
            this.panalGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line1)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Score.Location = new System.Drawing.Point(193, 13);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(88, 24);
            this.Score.TabIndex = 1;
            this.Score.Text = "Score: 0";
            // 
            // panalGame
            // 
            this.panalGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panalGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panalGame.Controls.Add(this.Score);
            this.panalGame.Controls.Add(this.labelgame);
            this.panalGame.Controls.Add(this.Car2);
            this.panalGame.Controls.Add(this.Car1);
            this.panalGame.Controls.Add(this.Car);
            this.panalGame.Controls.Add(this.Line3);
            this.panalGame.Controls.Add(this.Line2);
            this.panalGame.Controls.Add(this.Line6);
            this.panalGame.Controls.Add(this.Line4);
            this.panalGame.Controls.Add(this.Line5);
            this.panalGame.Controls.Add(this.Line1);
            this.panalGame.Location = new System.Drawing.Point(5, 5);
            this.panalGame.Name = "panalGame";
            this.panalGame.Size = new System.Drawing.Size(472, 507);
            this.panalGame.TabIndex = 0;
            this.panalGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelgame
            // 
            this.labelgame.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgame.Location = new System.Drawing.Point(160, 222);
            this.labelgame.Name = "labelgame";
            this.labelgame.Size = new System.Drawing.Size(146, 80);
            this.labelgame.TabIndex = 11;
            this.labelgame.Text = "Game Over";
            this.labelgame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelgame.Visible = false;
            // 
            // Car2
            // 
            this.Car2.BackColor = System.Drawing.Color.Transparent;
            this.Car2.Image = ((System.Drawing.Image)(resources.GetObject("Car2.Image")));
            this.Car2.Location = new System.Drawing.Point(355, 222);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(46, 99);
            this.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car2.TabIndex = 10;
            this.Car2.TabStop = false;
            this.Car2.WaitOnLoad = true;
            // 
            // Car1
            // 
            this.Car1.BackColor = System.Drawing.Color.Transparent;
            this.Car1.Image = ((System.Drawing.Image)(resources.GetObject("Car1.Image")));
            this.Car1.Location = new System.Drawing.Point(66, 165);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(46, 99);
            this.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car1.TabIndex = 9;
            this.Car1.TabStop = false;
            this.Car1.WaitOnLoad = true;
            // 
            // Car
            // 
            this.Car.BackColor = System.Drawing.Color.Transparent;
            this.Car.Image = global::CarGame.Properties.Resources.car;
            this.Car.Location = new System.Drawing.Point(213, 387);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(46, 99);
            this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car.TabIndex = 8;
            this.Car.TabStop = false;
            this.Car.WaitOnLoad = true;
            // 
            // Line3
            // 
            this.Line3.BackColor = System.Drawing.SystemColors.Control;
            this.Line3.Location = new System.Drawing.Point(355, 76);
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.Size(14, 146);
            this.Line3.TabIndex = 7;
            this.Line3.TabStop = false;
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.SystemColors.Control;
            this.Line2.Location = new System.Drawing.Point(231, 73);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(14, 146);
            this.Line2.TabIndex = 6;
            this.Line2.TabStop = false;
            // 
            // Line6
            // 
            this.Line6.BackColor = System.Drawing.SystemColors.Control;
            this.Line6.Location = new System.Drawing.Point(355, 316);
            this.Line6.Name = "Line6";
            this.Line6.Size = new System.Drawing.Size(14, 144);
            this.Line6.TabIndex = 5;
            this.Line6.TabStop = false;
            // 
            // Line4
            // 
            this.Line4.BackColor = System.Drawing.SystemColors.Control;
            this.Line4.Location = new System.Drawing.Point(98, 316);
            this.Line4.Name = "Line4";
            this.Line4.Size = new System.Drawing.Size(14, 144);
            this.Line4.TabIndex = 4;
            this.Line4.TabStop = false;
            // 
            // Line5
            // 
            this.Line5.BackColor = System.Drawing.SystemColors.Control;
            this.Line5.Location = new System.Drawing.Point(231, 316);
            this.Line5.Name = "Line5";
            this.Line5.Size = new System.Drawing.Size(14, 144);
            this.Line5.TabIndex = 3;
            this.Line5.TabStop = false;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.SystemColors.Control;
            this.Line1.Location = new System.Drawing.Point(98, 73);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(14, 146);
            this.Line1.TabIndex = 2;
            this.Line1.TabStop = false;
            // 
            // TimerGame
            // 
            this.TimerGame.Enabled = true;
            this.TimerGame.Interval = 1;
            this.TimerGame.Tick += new System.EventHandler(this.TimerGame_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 514);
            this.Controls.Add(this.panalGame);
            this.Name = "Form1";
            this.Text = "Car Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panalGame.ResumeLayout(false);
            this.panalGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Panel panalGame;
        private System.Windows.Forms.Timer TimerGame;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.Label labelgame;
        private System.Windows.Forms.PictureBox Line3;
        private System.Windows.Forms.PictureBox Line2;
        private System.Windows.Forms.PictureBox Line6;
        private System.Windows.Forms.PictureBox Line4;
        private System.Windows.Forms.PictureBox Line5;
        private System.Windows.Forms.PictureBox Line1;
        private System.Windows.Forms.PictureBox Car2;
    }
}

