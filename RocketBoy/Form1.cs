using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketBoy
{
    public partial class Form1 : Form
    {
        Label[] rocks = new Label[20];
        int rockCount = 0;
        int score = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch ( e.KeyCode)
                {
                case Keys.Up:
                    RocketBox.Top = RocketBox.Top - 5;
                    break;
                case Keys.Down:
                    RocketBox.Top = RocketBox.Top + 5;
                    break;
                case Keys.Left:
                    RocketBox.Left = RocketBox.Left - 5;
                    break;
                case Keys.Right:
                    RocketBox.Left = RocketBox.Left + 5;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int rockSize = rnd.Next(5, 30);            
            score = score + 10;
            ScoreLbl.Text = score.ToString() + "Km";
            rocks[rockCount] = new Label()
            {
                Location = new Point(1000, rnd.Next(25,475)),                
                AutoSize =false,
                Size = new Size(rockSize, rockSize),
                BackColor = Color.Crimson
             };
            this.Controls.Add(rocks[rockCount]);
            timer2.Enabled = true;
            rockCount++;
            if (rockCount == 20)
            { rockCount = 0; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int n = 0; n < 20; n++)
            {
                if (rocks[n] is null)
                { continue; }
                rocks[n].Left = rocks[n].Left - 5;
                
                if (rocks[n].Bounds.IntersectsWith(RocketBox.Bounds))
                {
                    RocketBox.Image = RocketBoy.Properties.Resources.boom;
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                }
                if (rocks[n].Bounds.IntersectsWith(BackWall.Bounds))
                {
                    this.Controls.Remove(rocks[n]);
                    rocks[n] = null;
                }
            }
        }
    }
}
