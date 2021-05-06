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
    public partial class frmMaze2 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer(); // create instance for playing windows media player
        string str;      // variable string to store a result string
        int musicOk = 0; // variable used to store the parameter music from Login form
        int _tech = 0;   // variable used as a counter for timing

        public frmMaze2(int music, string plrName)
        {
            InitializeComponent();
            player.URL = "bmetMusic.mp3";
            moveToStartPoint();
            lblPlayerName.Text = plrName;
            musicOk = music;
        }

        // Check if music parameter active then playing music, else no playing music
        private void frmMaze2_Load(object sender, EventArgs e)
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

        // Stop all timers, add result to global scoreForm variables, hide current form
        private void hideForm()
        {
            player.controls.stop();
            tmGame.Stop();
            str = lblPlayerName.Text + " , " + "BmetMaze game Level 2" + " ,  Time = " + lblTmGame.Text + "\r\n";
            frmScores.mazeScores.Add(str);
            this.Hide();
        }

        // Game timer
        private void tmGame_Tick(object sender, EventArgs e)
        {
            _tech++;
            lblTmGame.Text = _tech.ToString();
        }

        // Stop playing music, stop timer tmGame, hide current level
        private void frmMaze2_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.controls.stop();
            tmGame.Stop();
            this.Hide();
        }

        /* function for moving pleaer picMan and check if touched a wall return player to starting point.
           if touched Goal then end current level and go to the next level
        */
        private void frmMaze2_KeyDown(object sender, KeyEventArgs e)
        {
            int x = picMan.Location.X;
            int y = picMan.Location.Y;

            if (e.KeyCode == Keys.Right)
                if (picMan.Right + picMan.Width >= ClientSize.Width)
                {
                    x = picMan.Location.X;
                }
                else
                {
                    x += 6;
                }

            else if (e.KeyCode == Keys.Left)
                if (picMan.Left + picMan.Width <= picMan.Width + 5)
                {
                    x = picMan.Location.X;
                }
                else
                {
                    x -= 6;
                }

            else if (e.KeyCode == Keys.Up)
                if (picMan.Top + picMan.Height <= picMan.Height + 5)
                {
                    y = picMan.Location.Y;
                }
                else
                {
                    y -= 6;
                }

            else if (e.KeyCode == Keys.Down)
                if (picMan.Bottom + picMan.Height > ClientSize.Height)
                {
                    y = picMan.Location.Y;
                }
                else
                {
                    y += 6;
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
                        frmMaze3 frmMz3 = new frmMaze3(musicOk, lblPlayerName.Text);
                        frmMz3.ShowDialog();
                        break;
                    }
                }
            }
        }
    }
}
