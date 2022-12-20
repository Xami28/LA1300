namespace LA_1300_C
{
    partial class levelOverview
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
            this.enterLevel01 = new System.Windows.Forms.Button();
            this.enterLevel02 = new System.Windows.Forms.Button();
            this.enterLevel03 = new System.Windows.Forms.Button();
            this.enterLevel04 = new System.Windows.Forms.Button();
            this.menuAnimatedBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.menuAnimatedBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // enterLevel01
            // 
            this.enterLevel01.BackColor = System.Drawing.Color.White;
            this.enterLevel01.FlatAppearance.BorderSize = 0;
            this.enterLevel01.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterLevel01.Location = new System.Drawing.Point(105, 178);
            this.enterLevel01.Name = "enterLevel01";
            this.enterLevel01.Size = new System.Drawing.Size(64, 64);
            this.enterLevel01.TabIndex = 4;
            this.enterLevel01.Text = "01";
            this.enterLevel01.UseVisualStyleBackColor = false;
            this.enterLevel01.Click += new System.EventHandler(this.button1_Click);
            // 
            // enterLevel02
            // 
            this.enterLevel02.BackColor = System.Drawing.Color.White;
            this.enterLevel02.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.enterLevel02.FlatAppearance.BorderSize = 0;
            this.enterLevel02.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterLevel02.Location = new System.Drawing.Point(269, 178);
            this.enterLevel02.Name = "enterLevel02";
            this.enterLevel02.Size = new System.Drawing.Size(64, 64);
            this.enterLevel02.TabIndex = 5;
            this.enterLevel02.Text = "02";
            this.enterLevel02.UseVisualStyleBackColor = false;
            this.enterLevel02.Click += new System.EventHandler(this.enterLevel02_Click);
            // 
            // enterLevel03
            // 
            this.enterLevel03.BackColor = System.Drawing.Color.White;
            this.enterLevel03.FlatAppearance.BorderSize = 0;
            this.enterLevel03.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterLevel03.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enterLevel03.Location = new System.Drawing.Point(442, 178);
            this.enterLevel03.Name = "enterLevel03";
            this.enterLevel03.Size = new System.Drawing.Size(64, 64);
            this.enterLevel03.TabIndex = 6;
            this.enterLevel03.Text = "03";
            this.enterLevel03.UseVisualStyleBackColor = false;
            this.enterLevel03.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // enterLevel04
            // 
            this.enterLevel04.BackColor = System.Drawing.Color.White;
            this.enterLevel04.FlatAppearance.BorderSize = 0;
            this.enterLevel04.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterLevel04.Location = new System.Drawing.Point(606, 178);
            this.enterLevel04.Name = "enterLevel04";
            this.enterLevel04.Size = new System.Drawing.Size(64, 64);
            this.enterLevel04.TabIndex = 7;
            this.enterLevel04.Text = "04";
            this.enterLevel04.UseVisualStyleBackColor = false;
            this.enterLevel04.Click += new System.EventHandler(this.enterLevel04_Click);
            // 
            // menuAnimatedBackground
            // 
            this.menuAnimatedBackground.Image = global::LA_1300_C.Properties.Resources.menu_animated_background;
            this.menuAnimatedBackground.Location = new System.Drawing.Point(-5, -27);
            this.menuAnimatedBackground.Name = "menuAnimatedBackground";
            this.menuAnimatedBackground.Size = new System.Drawing.Size(807, 484);
            this.menuAnimatedBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuAnimatedBackground.TabIndex = 8;
            this.menuAnimatedBackground.TabStop = false;
            // 
            // levelOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enterLevel04);
            this.Controls.Add(this.enterLevel03);
            this.Controls.Add(this.enterLevel02);
            this.Controls.Add(this.enterLevel01);
            this.Controls.Add(this.menuAnimatedBackground);
            this.Name = "levelOverview";
            this.Text = "Levelauswahl";
            ((System.ComponentModel.ISupportInitialize)(this.menuAnimatedBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button enterLevel01;
        private Button enterLevel02;
        private Button enterLevel03;
        private Button enterLevel04;
        private PictureBox menuAnimatedBackground;
    }
}