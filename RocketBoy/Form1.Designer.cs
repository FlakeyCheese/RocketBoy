
namespace RocketBoy
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
            this.BackWall = new System.Windows.Forms.Label();
            this.ScoreLbl = new System.Windows.Forms.Label();
            this.TopWall = new System.Windows.Forms.Label();
            this.BottomWall = new System.Windows.Forms.Label();
            this.RocketBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RocketBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BackWall
            // 
            this.BackWall.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackWall.Location = new System.Drawing.Point(-1, 0);
            this.BackWall.Name = "BackWall";
            this.BackWall.Size = new System.Drawing.Size(11, 464);
            this.BackWall.TabIndex = 0;
            // 
            // ScoreLbl
            // 
            this.ScoreLbl.AutoSize = true;
            this.ScoreLbl.Font = new System.Drawing.Font("GrilledCheese BTN", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLbl.Location = new System.Drawing.Point(38, 13);
            this.ScoreLbl.Name = "ScoreLbl";
            this.ScoreLbl.Size = new System.Drawing.Size(76, 33);
            this.ScoreLbl.TabIndex = 1;
            this.ScoreLbl.Text = "0 Km";
            // 
            // TopWall
            // 
            this.TopWall.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopWall.Location = new System.Drawing.Point(2, 0);
            this.TopWall.Name = "TopWall";
            this.TopWall.Size = new System.Drawing.Size(981, 11);
            this.TopWall.TabIndex = 0;
            // 
            // BottomWall
            // 
            this.BottomWall.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BottomWall.Location = new System.Drawing.Point(2, 453);
            this.BottomWall.Name = "BottomWall";
            this.BottomWall.Size = new System.Drawing.Size(981, 11);
            this.BottomWall.TabIndex = 0;
            // 
            // RocketBox
            // 
            this.RocketBox.Image = global::RocketBoy.Properties.Resources.rocket;
            this.RocketBox.Location = new System.Drawing.Point(469, 187);
            this.RocketBox.Name = "RocketBox";
            this.RocketBox.Size = new System.Drawing.Size(101, 90);
            this.RocketBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RocketBox.TabIndex = 2;
            this.RocketBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 457);
            this.Controls.Add(this.RocketBox);
            this.Controls.Add(this.ScoreLbl);
            this.Controls.Add(this.BottomWall);
            this.Controls.Add(this.TopWall);
            this.Controls.Add(this.BackWall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Rocket Boy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.RocketBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BackWall;
        private System.Windows.Forms.Label ScoreLbl;
        private System.Windows.Forms.Label TopWall;
        private System.Windows.Forms.Label BottomWall;
        private System.Windows.Forms.PictureBox RocketBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

