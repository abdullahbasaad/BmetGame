namespace bmetGame
{
    partial class frmLogin
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
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.lblGameName = new System.Windows.Forms.Label();
            this.checkMusic = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameLevel = new System.Windows.Forms.ComboBox();
            this.gameTimer = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.copyRTm = new System.Windows.Forms.Timer(this.components);
            this.gameType = new System.Windows.Forms.ComboBox();
            this.lblGameType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlayer
            // 
            this.txtPlayer.Font = new System.Drawing.Font("Britannic Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer.Location = new System.Drawing.Point(214, 127);
            this.txtPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(315, 60);
            this.txtPlayer.TabIndex = 0;
            this.txtPlayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayer_KeyPress);
            this.txtPlayer.Validated += new System.EventHandler(this.txtPlayer_Validated);
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Brush Script MT", 50F);
            this.lblGameName.ForeColor = System.Drawing.Color.Yellow;
            this.lblGameName.Location = new System.Drawing.Point(205, 9);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(334, 103);
            this.lblGameName.TabIndex = 1;
            this.lblGameName.Text = "BmetGame";
            // 
            // checkMusic
            // 
            this.checkMusic.AutoSize = true;
            this.checkMusic.BackColor = System.Drawing.Color.Transparent;
            this.checkMusic.Font = new System.Drawing.Font("Tahoma", 14F);
            this.checkMusic.ForeColor = System.Drawing.Color.Black;
            this.checkMusic.Location = new System.Drawing.Point(214, 369);
            this.checkMusic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkMusic.Name = "checkMusic";
            this.checkMusic.Size = new System.Drawing.Size(94, 33);
            this.checkMusic.TabIndex = 4;
            this.checkMusic.Text = "Music";
            this.checkMusic.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Trebuchet MS", 26F);
            this.btnStart.Location = new System.Drawing.Point(214, 411);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(315, 104);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameLevel
            // 
            this.gameLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameLevel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gameLevel.FormattingEnabled = true;
            this.gameLevel.Items.AddRange(new object[] {
            "Beginners",
            "Expertise"});
            this.gameLevel.Location = new System.Drawing.Point(214, 279);
            this.gameLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameLevel.Name = "gameLevel";
            this.gameLevel.Size = new System.Drawing.Size(315, 36);
            this.gameLevel.TabIndex = 2;
            // 
            // gameTimer
            // 
            this.gameTimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameTimer.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gameTimer.FormattingEnabled = true;
            this.gameTimer.Items.AddRange(new object[] {
            "2",
            "5",
            "10"});
            this.gameTimer.Location = new System.Drawing.Point(214, 324);
            this.gameTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameTimer.Name = "gameTimer";
            this.gameTimer.Size = new System.Drawing.Size(315, 36);
            this.gameTimer.TabIndex = 3;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(122, 279);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(68, 29);
            this.lblLevel.TabIndex = 6;
            this.lblLevel.Text = "Level";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(122, 324);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(65, 29);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(112, 149);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 29);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Player";
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblCopyRight.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCopyRight.Location = new System.Drawing.Point(245, 560);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(495, 18);
            this.lblCopyRight.TabIndex = 9;
            this.lblCopyRight.Text = "Copy Right@Matthew Boulton College 2017(BmetGame) - Basaad";
            // 
            // copyRTm
            // 
            this.copyRTm.Interval = 20;
            this.copyRTm.Tick += new System.EventHandler(this.copyRTm_Tick);
            // 
            // gameType
            // 
            this.gameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameType.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gameType.FormattingEnabled = true;
            this.gameType.Items.AddRange(new object[] {
            "BmetApple Game",
            "BmetMaze Game"});
            this.gameType.Location = new System.Drawing.Point(214, 232);
            this.gameType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameType.Name = "gameType";
            this.gameType.Size = new System.Drawing.Size(315, 36);
            this.gameType.TabIndex = 1;
            this.gameType.SelectedValueChanged += new System.EventHandler(this.gameType_SelectedValueChanged);
            // 
            // lblGameType
            // 
            this.lblGameType.AutoSize = true;
            this.lblGameType.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameType.Location = new System.Drawing.Point(119, 239);
            this.lblGameType.Name = "lblGameType";
            this.lblGameType.Size = new System.Drawing.Size(83, 29);
            this.lblGameType.TabIndex = 11;
            this.lblGameType.Text = "Game ";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::bmetGame.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(746, 586);
            this.Controls.Add(this.lblGameType);
            this.Controls.Add(this.gameType);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.gameTimer);
            this.Controls.Add(this.gameLevel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.checkMusic);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.txtPlayer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.Text = "Config Game";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.CheckBox checkMusic;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox gameLevel;
        private System.Windows.Forms.ComboBox gameTimer;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.Timer copyRTm;
        private System.Windows.Forms.ComboBox gameType;
        private System.Windows.Forms.Label lblGameType;
    }
}

