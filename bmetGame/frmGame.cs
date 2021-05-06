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
using System.Collections;

namespace bmetGame
{   
    public partial class frmGame : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        int musicOk;
        int gmTime = 0;
        int gamLvl = 0;
        bool goleft;
        bool goright;
        int score = 0;
        int missed = 0;
        int speed = 8;
        Random rndY = new Random();
        Random rndX = new Random();
        PictureBox splash = new PictureBox();
        string lvl = "";
        public static string str = "";

        public frmGame(int chkMusic, String playerName, int gmLvl, int gmeTime)
        {
            InitializeComponent();
            player.URL = "bmetMusic.mp3";
            lblPlaer.Text = playerName;
            musicOk = chkMusic;
            gmTime = gmeTime;
            gamLvl = gmLvl;
     
            if (gamLvl == 0)
            {
                lvl = "Beginners";
            }
            else
            {
                lvl = "Expertise";
            }
        }

        private void gameForm_Load(object sender, EventArgs e)
        {
            formLoad();
        }

        private void finishGameTm_Tick(object sender, EventArgs e)
        {
            fnshMainTm();
        }

        private void gameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            hideForm();
        }

        private void hideForm()
        {
            player.controls.stop();
            finishGameTm.Stop();
            gmTm.Stop();

            str = lblPlaer.Text + " , " + "Time = " + gmTime + " , " + "Level: " + lvl + " ,  score = " + label1.Text + "\r\n";
            this.Hide();
        }

        private void gameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void gameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;

            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void reset()
        {
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox && (string)X.Tag == "Apple")
                {
                    X.Top = rndY.Next(80, 300) * -1;
                    X.Left = rndX.Next(5, this.ClientSize.Width - X.Width);
                }
            }
            picBascket.Left = this.ClientSize.Width / 2;
            picBascket.Image = Properties.Resources.bascketEmpty;

            score = 0;
            missed = 0;
            speed = 8;

            goleft = false;
            goright = false;
            finishGameTm.Start();        
        }

        private void gmTm_Tick(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(score);

            if (goleft == true && picBascket.Left > 0)
            {
                picBascket.Left -= 12;            
            }
            if (goright == true && picBascket.Left + picBascket.Width < this.ClientSize.Width)
            {
                picBascket.Left += 12;
            }

            if (lblSeconds.Text == "0" && lblMinutes.Text == "0")
            {
                gmTm.Stop();
            }

            foreach (Control X in this.Controls)
            {
                if (X is PictureBox && (string)X.Tag == "Apple")
                {
                    X.Top += speed;
                    if (X.Top + X.Height > this.ClientSize.Height)
                    {
                        splash.Location = X.Location;
                        splash.Height = 59;
                        splash.Width = 60;
                        splash.BackColor = System.Drawing.Color.Transparent;
                        this.Controls.Add(splash);
                        X.Top = rndY.Next(80, 300) * -1;
                        X.Left = rndX.Next(5, this.ClientSize.Width - X.Width);
                        missed++;
                    }

                    if (X.Bounds.IntersectsWith(picBascket.Bounds))
                    {
                        X.Top = rndY.Next(100, 300) * -1;
                        X.Left = rndX.Next(5, this.ClientSize.Width - X.Width);
                        score++;
                    }

                    if (score > 20)
                    {
                        speed = 16;
                        picBascket.Image = Properties.Resources.cartFull;
                    }
                }

                if (gamLvl == 1)
                {
                    if (X is PictureBox && (string)X.Tag == "bomb")
                    {
                        X.Visible = true;
                        speed = 16;
                        X.Top += speed;
                        if (X.Top + X.Height > this.ClientSize.Height)
                        {
                            splash.Location = X.Location;
                            splash.Height = 30;
                            splash.Width = 30;
                            splash.BackColor = System.Drawing.Color.Transparent;
                            this.Controls.Add(splash);
                            X.Top = rndY.Next(80, 300) * -1;
                            X.Left = rndX.Next(5, this.ClientSize.Width - X.Width);
                            missed++;
                        }

                        if (X.Bounds.IntersectsWith(picBascket.Bounds))
                        {
                            gmTm.Stop();
                            finishGameTm.Stop();
                            picGameOver.Visible = true;

                            if (DialogResult.OK == MessageBox.Show("Game Over..."))
                            {
                                hideForm();
                                frmScores.scores.Add(str);                              
                                frmScores frmScr = new frmScores();
                                frmScr.ShowDialog();
                            }
                        }

                        if (score > 15)
                        {
                            speed = 25;
                            picBascket.Image = Properties.Resources.cartFull;
                        }
                    }
                }    
            }
        }

        private void formLoad()
        {
            lblSeconds.Text = "59";
            lblMinutes.Text = Convert.ToString(gmTime - 1);

            if (musicOk == 1)
            {
                player.controls.play();
            }
            else
            {
                player.controls.stop();
            }
        }

        private void fnshMainTm()
        {
            if (lblMinutes.Text != "0")
            {
                lblSeconds.Text = Convert.ToString((Convert.ToInt32(lblSeconds.Text) - 1));

                if (lblSeconds.Text == "0")
                {
                    lblSeconds.Text = "59";
                    lblMinutes.Text = Convert.ToString(Convert.ToInt32(lblMinutes.Text) - 1);
                }
            }
            else
            {
                if (lblSeconds.Text == "0")
                {
                    finishGameTm.Stop();

                    if (DialogResult.OK == MessageBox.Show("Times Up..."))
                    {
                        hideForm();
                        frmScores.scores.Add(str);
                        frmScores frmScr = new frmScores();
                        frmScr.ShowDialog();
                    }
                }
                else
                {
                    lblSeconds.Text = Convert.ToString((Convert.ToInt32(lblSeconds.Text) - 1));
                }
            }
        }
    }
}
