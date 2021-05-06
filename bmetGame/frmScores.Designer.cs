namespace bmetGame
{
    partial class frmScores
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
            this.rTxtResults = new System.Windows.Forms.RichTextBox();
            this.richMazeResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rTxtResults
            // 
            this.rTxtResults.Font = new System.Drawing.Font("Tahoma", 16F);
            this.rTxtResults.Location = new System.Drawing.Point(10, 10);
            this.rTxtResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rTxtResults.Name = "rTxtResults";
            this.rTxtResults.ReadOnly = true;
            this.rTxtResults.Size = new System.Drawing.Size(623, 166);
            this.rTxtResults.TabIndex = 1;
            this.rTxtResults.Text = "";
            // 
            // richMazeResult
            // 
            this.richMazeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richMazeResult.Font = new System.Drawing.Font("Tahoma", 16F);
            this.richMazeResult.Location = new System.Drawing.Point(10, 180);
            this.richMazeResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richMazeResult.Name = "richMazeResult";
            this.richMazeResult.ReadOnly = true;
            this.richMazeResult.Size = new System.Drawing.Size(623, 148);
            this.richMazeResult.TabIndex = 2;
            this.richMazeResult.Text = "";
            // 
            // frmScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 336);
            this.Controls.Add(this.richMazeResult);
            this.Controls.Add(this.rTxtResults);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScores";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Players\' Scores";
            this.Load += new System.EventHandler(this.formScores_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rTxtResults;
        private System.Windows.Forms.RichTextBox richMazeResult;
    }
}