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
    public partial class frmMaze3 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer(); // create instance for playing windows media player
        string str;      // variable string to store a result string
        int musicOk = 0; // variable used to store the parameter music from Login form
        int _tech = 0;   // variable used as a counter for timing

        public frmMaze3(int music, string plName)
        {
            InitializeComponent();
            player.URL = "bmetMusic.mp3";
            moveToStartPoint();
            musicOk = music;
            lblPlayerName.Text = plName;
        }

        // Check if music parameter active then playing music, else no playing music
        private void frmMaze3_Load(object sender, EventArgs e)
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

        // Call scores form to display results 
        private void callScores()
        {
            frmScores frmScr = new frmScores();
            frmScr.ShowDialog();
        }

        // starting point for player
        private void moveToStartPoint()
        {
            picMan.Location = new Point(80, 10);
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
            tmGame.Stop();
            str = lblPlayerName.Text + " , " + "BmetMaze game Level 3" + " ,  Time = " + lblTmGame.Text + "\r\n";
            frmScores.mazeScores.Add(str);
            this.Hide();
        }

        // Stop playing music, stop timer tmGame, hide current level
        private void frmMaze3_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.controls.stop();
            tmGame.Stop();
            this.Hide();
        }

        /* function for moving pleaer picMan and check if touched a wall return player to starting point.
           if touched Goal then end current level and go to results screen
        */
        private void frmMaze3_KeyDown(object sender, KeyEventArgs e)
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
                        break;
                    }

                    if (picMan.Bounds.IntersectsWith(lblGoal.Bounds))
                    {  
                        hideForm();
                        callScores();
                        break;
                    }  
                }
            }
        }
    }
}
