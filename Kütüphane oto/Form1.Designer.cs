namespace Kütüphane_oto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdGiristxt = new System.Windows.Forms.TextBox();
            this.sifreGiristxt = new System.Windows.Forms.TextBox();
            this.GirisButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(87, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(90, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // AdGiristxt
            // 
            this.AdGiristxt.Location = new System.Drawing.Point(142, 109);
            this.AdGiristxt.Name = "AdGiristxt";
            this.AdGiristxt.Size = new System.Drawing.Size(174, 20);
            this.AdGiristxt.TabIndex = 2;
            // 
            // sifreGiristxt
            // 
            this.sifreGiristxt.Location = new System.Drawing.Point(141, 147);
            this.sifreGiristxt.Name = "sifreGiristxt";
            this.sifreGiristxt.Size = new System.Drawing.Size(175, 20);
            this.sifreGiristxt.TabIndex = 3;
            // 
            // GirisButton
            // 
            this.GirisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GirisButton.Location = new System.Drawing.Point(182, 194);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(75, 23);
            this.GirisButton.TabIndex = 4;
            this.GirisButton.Text = "Giriş";
            this.GirisButton.UseVisualStyleBackColor = true;
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(468, 317);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GirisButton);
            this.Controls.Add(this.sifreGiristxt);
            this.Controls.Add(this.AdGiristxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdGiristxt;
        private System.Windows.Forms.TextBox sifreGiristxt;
        private System.Windows.Forms.Button GirisButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

