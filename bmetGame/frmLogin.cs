using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace bmetGame
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            copyRTm.Start(); // Copy right text timer 
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int lstnMusic = 0; // variable to store the music filed value
            int gmeLevel = 0;  // variable to store the game level

            if (txtPlayer.Text == "") // Player name mandatory field
            {
                MessageBox.Show("Enter player name!!...");
                txtPlayer.Focus();
            }

            if (checkMusic.Checked) // stored 1 in music variable if checked, else stored 0
            {
                lstnMusic = 1;
            }
            else
            {
                lstnMusic = 0;
            }

            /* I have two games in the project on is called BmetApple game, the index for it = 0
            *  the second game is BmetMaze game, it has index = 1
            *  if index = 0 I have called the BmetApple game else I have called BmetApple game 
            */
            if (gameType.SelectedIndex == 0)
            {
                gmeLevel = gameLevel.FindStringExact(gameLevel.Text);
                frmGame gmForm = new frmGame(lstnMusic, txtPlayer.Text, gmeLevel, Convert.ToInt16(gameTimer.Text));
                gmForm.ShowDialog();
            }
            else
            {
                frmMaze1 fMaze = new frmMaze1(txtPlayer.Text, lstnMusic);
                fMaze.ShowDialog();
            }
            
        }

        // Timer used to change the interface colors randomly
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int frstColor = rnd.Next(0, 255);
            int scndColor = rnd.Next(0, 255);
            int thrdColor = rnd.Next(0, 255);
            int fourColor = rnd.Next(0, 255);

            lblGameName.ForeColor = Color.FromArgb(frstColor, scndColor, thrdColor, fourColor);
            btnStart.ForeColor = Color.FromArgb(frstColor, scndColor, thrdColor, fourColor);
        }

        // Player name length should be between 3 and 8 litters
        private void txtPlayer_Validated(object sender, EventArgs e)
        {
            if (txtPlayer.Text.Length > 8 || txtPlayer.Text.Length < 3)
            {
                MessageBox.Show("The name length should be between 3 to 8 letters!!");
                txtPlayer.Focus();
            }
        }

        // just letters are accepted here, in the player name field, numbers not allowed 
        private void txtPlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if ((char.IsDigit(ch)))
            {
                e.Handled = true;
            }
        }

        // Show initial values in level, timer and game type fields
        private void frmLogin_Load(object sender, EventArgs e)
        {
            gameLevel.SelectedIndex = 0;
            gameTimer.SelectedIndex = 0;
            gameType.SelectedIndex = 0;
        }

        // Timer for moving copyright text
        private void copyRTm_Tick(object sender, EventArgs e)
        {
            if (lblCopyRight.Left < 630)
            {
                lblCopyRight.Left = lblCopyRight.Left + 2;
            }
            else
            {
                lblCopyRight.Left = -450;
            }
        }

        // Disable and enable some fields depends on game type field
        private void gameType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (gameType.SelectedIndex == 1)
            {
                gameLevel.Enabled = false;
                gameTimer.Enabled = false;
            }
            else
            {
                gameLevel.Enabled = true;
                gameTimer.Enabled = true;
            }
        }
    }
}
