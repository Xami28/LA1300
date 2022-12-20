namespace LA_1300_C
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuAnimatedBackground = new System.Windows.Forms.PictureBox();
            this.menuGameTitle = new System.Windows.Forms.PictureBox();
            this.menuPlayButton = new System.Windows.Forms.PictureBox();
            this.menuExitButton = new System.Windows.Forms.PictureBox();
            this.menuOptionsButton = new System.Windows.Forms.PictureBox();
            this.menuControlsButton = new System.Windows.Forms.PictureBox();
            this.menuCreditsButton = new System.Windows.Forms.PictureBox();
            this.labelresult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuAnimatedBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuGameTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuPlayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuOptionsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuControlsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuCreditsButton)).BeginInit();
            this.SuspendLayout();
            // 
            // menuAnimatedBackground
            // 
            this.menuAnimatedBackground.Image = global::LA_1300_C.Properties.Resources.menu_animated_background;
            this.menuAnimatedBackground.Location = new System.Drawing.Point(0, 0);
            this.menuAnimatedBackground.Name = "menuAnimatedBackground";
            this.menuAnimatedBackground.Size = new System.Drawing.Size(1073, 661);
            this.menuAnimatedBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuAnimatedBackground.TabIndex = 0;
            this.menuAnimatedBackground.TabStop = false;
            // 
            // menuGameTitle
            // 
            this.menuGameTitle.Image = global::LA_1300_C.Properties.Resources.menu_dino_game_light;
            this.menuGameTitle.Location = new System.Drawing.Point(140, 20);
            this.menuGameTitle.Name = "menuGameTitle";
            this.menuGameTitle.Size = new System.Drawing.Size(800, 150);
            this.menuGameTitle.TabIndex = 1;
            this.menuGameTitle.TabStop = false;
            // 
            // menuPlayButton
            // 
            this.menuPlayButton.Image = global::LA_1300_C.Properties.Resources.menu_play_left;
            this.menuPlayButton.Location = new System.Drawing.Point(420, 280);
            this.menuPlayButton.Name = "menuPlayButton";
            this.menuPlayButton.Size = new System.Drawing.Size(241, 100);
            this.menuPlayButton.TabIndex = 2;
            this.menuPlayButton.TabStop = false;
            // 
            // menuExitButton
            // 
            this.menuExitButton.Image = global::LA_1300_C.Properties.Resources.menu_exit_left;
            this.menuExitButton.Location = new System.Drawing.Point(511, 515);
            this.menuExitButton.Name = "menuExitButton";
            this.menuExitButton.Size = new System.Drawing.Size(66, 33);
            this.menuExitButton.TabIndex = 3;
            this.menuExitButton.TabStop = false;
            // 
            // menuOptionsButton
            // 
            this.menuOptionsButton.Image = global::LA_1300_C.Properties.Resources.menu_options_left;
            this.menuOptionsButton.Location = new System.Drawing.Point(482, 398);
            this.menuOptionsButton.Name = "menuOptionsButton";
            this.menuOptionsButton.Size = new System.Drawing.Size(119, 33);
            this.menuOptionsButton.TabIndex = 4;
            this.menuOptionsButton.TabStop = false;
            // 
            // menuControlsButton
            // 
            this.menuControlsButton.Image = global::LA_1300_C.Properties.Resources.menu_controls_left;
            this.menuControlsButton.Location = new System.Drawing.Point(473, 437);
            this.menuControlsButton.Name = "menuControlsButton";
            this.menuControlsButton.Size = new System.Drawing.Size(143, 33);
            this.menuControlsButton.TabIndex = 5;
            this.menuControlsButton.TabStop = false;
            // 
            // menuCreditsButton
            // 
            this.menuCreditsButton.Image = global::LA_1300_C.Properties.Resources.menu_credits_left;
            this.menuCreditsButton.Location = new System.Drawing.Point(482, 476);
            this.menuCreditsButton.Name = "menuCreditsButton";
            this.menuCreditsButton.Size = new System.Drawing.Size(119, 33);
            this.menuCreditsButton.TabIndex = 6;
            this.menuCreditsButton.TabStop = false;
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Location = new System.Drawing.Point(0, 648);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(233, 15);
            this.labelresult.TabIndex = 7;
            this.labelresult.Text = "Keine Einstellungen vorgenommen (Guest)";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 661);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.menuCreditsButton);
            this.Controls.Add(this.menuControlsButton);
            this.Controls.Add(this.menuOptionsButton);
            this.Controls.Add(this.menuExitButton);
            this.Controls.Add(this.menuPlayButton);
            this.Controls.Add(this.menuGameTitle);
            this.Controls.Add(this.menuAnimatedBackground);
            this.Name = "Menu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.menuAnimatedBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuGameTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuPlayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuOptionsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuControlsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuCreditsButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox menuAnimatedBackground;
        private PictureBox menuGameTitle;
        private PictureBox menuPlayButton;
        private PictureBox menuExitButton;
        private PictureBox menuOptionsButton;
        private PictureBox menuControlsButton;
        private PictureBox menuCreditsButton;
        private Label labelresult;
    }
}