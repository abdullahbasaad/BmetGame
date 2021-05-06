using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace bmetGame
{
    public partial class frmMaze1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer(); // create instance for playing windows media player
        string str;      // variable string to store a result string
        int musicOk = 0; // variable used to store the parameter music from Login form
        int _tech = 0;   // variable used as a counter for timing

        public frmMaze1(string plName, int music)
        {
            InitializeComponent();
            player.URL = "bmetMusic.mp3";
            moveToStartPoint();
            musicOk = music;
            lblPlayerName.Text = plName;
        }

        // Check if music parameter active then playing music, else no playing music
        private void frmMaze1_Load(object sender, EventArgs e)
        {
            if (musicOk == 1)
            {
                player.controls.play();
            }
            else
            {
                player.controls.stop();
            }
        }

        // starting point for player
        private void moveToStartPoint()
        {
            picMan.Location = new Point(80, 10);
        }
        
        // Timer for closing and opening fame gate through increasing and decreasing gate width
        private void tmMaze1_Tick(object sender, EventArgs e)
        {
            if (lblGate.Width > 130)
            {
                lblGate.Width = 2;
            }
            else
            {
                lblGate.Width += 1;   
            }
        }

        // Game timer
        private void tmGame_Tick(object sender, EventArgs e)
        {
            _tech++;
            lblTmGame.Text = _tech.ToString();
        }

        // Stop all timers, add result to global scoreForm variables, hide current form
        private void hideForm()
        {
            player.controls.stop();
            tmMaze1.Stop();
            tmGame.Stop();
            str = lblPlayerName.Text + " , " + "BmetMaze game Level 1" + " ,  Time = " + lblTmGame.Text + "\r\n";
            frmScores.mazeScores.Add(str);
            this.Hide();
        }

        /* function for moving pleaer picMan and check if touched a wall return player to starting point.
           if touched Goal then end current level and go to the next level
        */
        private void frmMaze1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = picMan.Location.X;
            int y = picMan.Location.Y;

            if (e.KeyCode == Keys.Right)
                if (picMan.Right + picMan.Width > ClientSize.Width + 2)
                {
                    x = picMan.Location.X;
                }
                else
                {
                    x += 10;
                }
                                  
            else if (e.KeyCode == Keys.Left)
                if (picMan.Left + picMan.Width <= picMan.Width)
                {
                    x = picMan.Location.X;
                }
                else
                {
                    x -= 10;
                }
        
            else if (e.KeyCode == Keys.Up)
                if (picMan.Top + picMan.Height <= picMan.Height)
                {
                    y = picMan.Location.Y;
                }
                else
                {
                    y -= 10;
                }

            else if (e.KeyCode == Keys.Down)
                if (picMan.Bottom + picMan.Height > ClientSize.Height)
                {
                    y = picMan.Location.Y;
                }
                else
                {
                    y += 10;
                }

            picMan.Location = new Point(x, y);

            foreach (Control X in this.Controls)
            {
                if (X is Label && (string)X.Tag == "wall")
                {
                    if (picMan.Bounds.IntersectsWith(X.Bounds))
                    {
                        moveToStartPoint();
                    }

                    if (picMan.Bounds.IntersectsWith(lblGoal.Bounds))
                    {
                        hideForm();
                        frmMaze2 frmMz2 = new frmMaze2(musicOk, lblPlayerName.Text);
                        frmMz2.ShowDialog();
                        break;
                    }
                }
            }
        }
    }
}
