namespace bmetGame
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.finishGameTm = new System.Windows.Forms.Timer(this.components);
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.gmTm = new System.Windows.Forms.Timer(this.components);
            this.lblPlaer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBomb2 = new System.Windows.Forms.PictureBox();
            this.picBomb = new System.Windows.Forms.PictureBox();
            this.picApple4 = new System.Windows.Forms.PictureBox();
            this.picApple3 = new System.Windows.Forms.PictureBox();
            this.picApple2 = new System.Windows.Forms.PictureBox();
            this.picApple1 = new System.Windows.Forms.PictureBox();
            this.picBascket = new System.Windows.Forms.PictureBox();
            this.picGameOver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBomb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBascket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // finishGameTm
            // 
            this.finishGameTm.Enabled = true;
            this.finishGameTm.Interval = 500;
            this.finishGameTm.Tick += new System.EventHandler(this.finishGameTm_Tick);
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.BackColor = System.Drawing.Color.Transparent;
            this.lblSeconds.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblSeconds.ForeColor = System.Drawing.Color.Indigo;
            this.lblSeconds.Location = new System.Drawing.Point(773, 9);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(45, 33);
            this.lblSeconds.TabIndex = 1;
            this.lblSeconds.Text = "00";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.BackColor = System.Drawing.Color.Transparent;
            this.lblMinutes.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblMinutes.ForeColor = System.Drawing.Color.Indigo;
            this.lblMinutes.Location = new System.Drawing.Point(735, 9);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(45, 33);
            this.lblMinutes.TabIndex = 2;
            this.lblMinutes.Text = "00";
            // 
            // gmTm
            // 
            this.gmTm.Enabled = true;
            this.gmTm.Interval = 20;
            this.gmTm.Tick += new System.EventHandler(this.gmTm_Tick);
            // 
            // lblPlaer
            // 
            this.lblPlaer.AutoSize = true;
            this.lblPlaer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaer.ForeColor = System.Drawing.Color.Indigo;
            this.lblPlaer.Location = new System.Drawing.Point(12, 9);
            this.lblPlaer.Name = "lblPlaer";
            this.lblPlaer.Size = new System.Drawing.Size(66, 24);
            this.lblPlaer.TabIndex = 0;
            this.lblPlaer.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "score";
            // 
            // picBomb2
            // 
            this.picBomb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBomb2.Image = global::bmetGame.Properties.Resources.bomb;
            this.picBomb2.Location = new System.Drawing.Point(568, 105);
            this.picBomb2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBomb2.Name = "picBomb2";
            this.picBomb2.Size = new System.Drawing.Size(61, 50);
            this.picBomb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBomb2.TabIndex = 9;
            this.picBomb2.TabStop = false;
            this.picBomb2.Tag = "bomb";
            this.picBomb2.Visible = false;
            // 
            // picBomb
            // 
            this.picBomb.Image = global::bmetGame.Properties.Resources.bomb;
            this.picBomb.Location = new System.Drawing.Point(204, 105);
            this.picBomb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBomb.Name = "picBomb";
            this.picBomb.Size = new System.Drawing.Size(61, 50);
            this.picBomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBomb.TabIndex = 8;
            this.picBomb.TabStop = false;
            this.picBomb.Tag = "bomb";
            this.picBomb.Visible = false;
            // 
            // picApple4
            // 
            this.picApple4.Image = ((System.Drawing.Image)(resources.GetObject("picApple4.Image")));
            this.picApple4.Location = new System.Drawing.Point(659, 105);
            this.picApple4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picApple4.Name = "picApple4";
            this.picApple4.Size = new System.Drawing.Size(69, 50);
            this.picApple4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picApple4.TabIndex = 7;
            this.picApple4.TabStop = false;
            this.picApple4.Tag = "Apple";
            // 
            // picApple3
            // 
            this.picApple3.Image = ((System.Drawing.Image)(resources.GetObject("picApple3.Image")));
            this.picApple3.Location = new System.Drawing.Point(476, 105);
            this.picApple3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picApple3.Name = "picApple3";
            this.picApple3.Size = new System.Drawing.Size(61, 50);
            this.picApple3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picApple3.TabIndex = 6;
            this.picApple3.TabStop = false;
            this.picApple3.Tag = "Apple";
            // 
            // picApple2
            // 
            this.picApple2.Image = ((System.Drawing.Image)(resources.GetObject("picApple2.Image")));
            this.picApple2.Location = new System.Drawing.Point(306, 105);
            this.picApple2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picApple2.Name = "picApple2";
            this.picApple2.Size = new System.Drawing.Size(71, 50);
            this.picApple2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picApple2.TabIndex = 5;
            this.picApple2.TabStop = false;
            this.picApple2.Tag = "Apple";
            // 
            // picApple1
            // 
            this.picApple1.Image = global::bmetGame.Properties.Resources.apple3;
            this.picApple1.Location = new System.Drawing.Point(115, 105);
            this.picApple1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picApple1.Name = "picApple1";
            this.picApple1.Size = new System.Drawing.Size(55, 50);
            this.picApple1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picApple1.TabIndex = 4;
            this.picApple1.TabStop = false;
            this.picApple1.Tag = "Apple";
            // 
            // picBascket
            // 
            this.picBascket.Image = global::bmetGame.Properties.Resources.cart;
            this.picBascket.Location = new System.Drawing.Point(357, 551);
            this.picBascket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBascket.Name = "picBascket";
            this.picBascket.Size = new System.Drawing.Size(111, 75);
            this.picBascket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBascket.TabIndex = 3;
            this.picBascket.TabStop = false;
            this.picBascket.Tag = "basket";
            // 
            // picGameOver
            // 
            this.picGameOver.Image = global::bmetGame.Properties.Resources.gameOver;
            this.picGameOver.Location = new System.Drawing.Point(324, 238);
            this.picGameOver.Name = "picGameOver";
            this.picGameOver.Size = new System.Drawing.Size(194, 154);
            this.picGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGameOver.TabIndex = 10;
            this.picGameOver.TabStop = false;
            this.picGameOver.Visible = false;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(831, 665);
            this.Controls.Add(this.picGameOver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBomb2);
            this.Controls.Add(this.picBomb);
            this.Controls.Add(this.lblPlaer);
            this.Controls.Add(this.picApple4);
            this.Controls.Add(this.picApple3);
            this.Controls.Add(this.picApple2);
            this.Controls.Add(this.picApple1);
            this.Controls.Add(this.picBascket);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblSeconds);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGame";
            this.ShowIcon = false;
            this.Text = "Bmet\'s Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gameForm_FormClosed);
            this.Load += new System.EventHandler(this.gameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picBomb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApple1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBascket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer finishGameTm;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.PictureBox picBascket;
        private System.Windows.Forms.Timer gmTm;
        private System.Windows.Forms.PictureBox picApple1;
        private System.Windows.Forms.PictureBox picApple2;
        private System.Windows.Forms.PictureBox picApple3;
        private System.Windows.Forms.PictureBox picApple4;
        private System.Windows.Forms.PictureBox picBomb;
        private System.Windows.Forms.PictureBox picBomb2;
        private System.Windows.Forms.Label lblPlaer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picGameOver;
    }
}