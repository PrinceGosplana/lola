namespace BuildGirl
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
            this.cb_dress = new System.Windows.Forms.ComboBox();
            this.btn_dress = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_dress
            // 
            this.cb_dress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_dress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_dress.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cb_dress.FormattingEnabled = true;
            this.cb_dress.Items.AddRange(new object[] {
            "Bride",
            "Home",
            "Work",
            "Waitress",
            "BatGirl",
            "Merry Christmas",
            "Party",
            "Playgirl",
            "Protect",
            "Sex"});
            this.cb_dress.Location = new System.Drawing.Point(13, 13);
            this.cb_dress.Name = "cb_dress";
            this.cb_dress.Size = new System.Drawing.Size(121, 23);
            this.cb_dress.TabIndex = 3;
            // 
            // btn_dress
            // 
            this.btn_dress.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_dress.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_dress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_dress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dress.Image = ((System.Drawing.Image)(resources.GetObject("btn_dress.Image")));
            this.btn_dress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dress.Location = new System.Drawing.Point(33, 93);
            this.btn_dress.Margin = new System.Windows.Forms.Padding(1);
            this.btn_dress.Name = "btn_dress";
            this.btn_dress.Size = new System.Drawing.Size(85, 30);
            this.btn_dress.TabIndex = 1;
            this.btn_dress.Text = "Dress";
            this.btn_dress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dress.UseVisualStyleBackColor = false;
            this.btn_dress.Click += new System.EventHandler(this.btn_dress_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 709);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 734);
            this.Controls.Add(this.cb_dress);
            this.Controls.Add(this.btn_dress);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Girl";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_dress;
        //private ExtendAero.ExtendAero extendAero1;
        private System.Windows.Forms.ComboBox cb_dress;
    }
}

