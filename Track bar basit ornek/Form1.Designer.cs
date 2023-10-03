namespace Track_bar_basit_ornek
{
    partial class Form1
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
            this.tbSeviye = new System.Windows.Forms.TrackBar();
            this.lblSes = new System.Windows.Forms.Label();
            this.lblBar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbSeviye)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSeviye
            // 
            this.tbSeviye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbSeviye.Location = new System.Drawing.Point(39, 31);
            this.tbSeviye.Maximum = 100;
            this.tbSeviye.Name = "tbSeviye";
            this.tbSeviye.Size = new System.Drawing.Size(398, 45);
            this.tbSeviye.TabIndex = 0;
            this.tbSeviye.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblSes
            // 
            this.lblSes.AutoSize = true;
            this.lblSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSes.Location = new System.Drawing.Point(34, 149);
            this.lblSes.Name = "lblSes";
            this.lblSes.Size = new System.Drawing.Size(133, 25);
            this.lblSes.TabIndex = 1;
            this.lblSes.Text = "Ses seviyesi";
            // 
            // lblBar
            // 
            this.lblBar.AutoSize = true;
            this.lblBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBar.Location = new System.Drawing.Point(436, 13);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(14, 16);
            this.lblBar.TabIndex = 2;
            this.lblBar.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(492, 287);
            this.Controls.Add(this.lblBar);
            this.Controls.Add(this.lblSes);
            this.Controls.Add(this.tbSeviye);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbSeviye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbSeviye;
        private System.Windows.Forms.Label lblSes;
        private System.Windows.Forms.Label lblBar;
    }
}

