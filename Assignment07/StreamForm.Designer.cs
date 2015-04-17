namespace Assignment07
{
    partial class StreamForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.ThankYouLabel = new System.Windows.Forms.Label();
            this.ChargedLabel = new System.Windows.Forms.Label();
            this.MovieLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(144, 310);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(92, 45);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // ThankYouLabel
            // 
            this.ThankYouLabel.BackColor = System.Drawing.Color.Black;
            this.ThankYouLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ThankYouLabel.Location = new System.Drawing.Point(12, 9);
            this.ThankYouLabel.Name = "ThankYouLabel";
            this.ThankYouLabel.Size = new System.Drawing.Size(349, 30);
            this.ThankYouLabel.TabIndex = 1;
            this.ThankYouLabel.Text = "Thank you for choosing Movie Bonanza!";
            this.ThankYouLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChargedLabel
            // 
            this.ChargedLabel.BackColor = System.Drawing.Color.Black;
            this.ChargedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargedLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ChargedLabel.Location = new System.Drawing.Point(13, 39);
            this.ChargedLabel.Name = "ChargedLabel";
            this.ChargedLabel.Size = new System.Drawing.Size(348, 24);
            this.ChargedLabel.TabIndex = 2;
            this.ChargedLabel.Text = "Your Credit Card will be charged [X dollars]";
            this.ChargedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MovieLabel
            // 
            this.MovieLabel.BackColor = System.Drawing.Color.Black;
            this.MovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieLabel.ForeColor = System.Drawing.Color.Cyan;
            this.MovieLabel.Location = new System.Drawing.Point(13, 63);
            this.MovieLabel.Name = "MovieLabel";
            this.MovieLabel.Size = new System.Drawing.Size(348, 21);
            this.MovieLabel.TabIndex = 3;
            this.MovieLabel.Text = "[Your Movie] will begin streaming shortly";
            this.MovieLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment07.Properties.Resources.monkey_eating_popcorn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(373, 367);
            this.ControlBox = false;
            this.Controls.Add(this.MovieLabel);
            this.Controls.Add(this.ChargedLabel);
            this.Controls.Add(this.ThankYouLabel);
            this.Controls.Add(this.OKButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your movie is about to start!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label ThankYouLabel;
        private System.Windows.Forms.Label ChargedLabel;
        private System.Windows.Forms.Label MovieLabel;
    }
}