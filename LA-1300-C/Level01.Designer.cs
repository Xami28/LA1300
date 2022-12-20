namespace movement
{
    partial class Level01
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
            this.components = new System.ComponentModel.Container();
            this.floor = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.object2 = new System.Windows.Forms.PictureBox();
            this.movementTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.object1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tutorial1 = new System.Windows.Forms.Label();
            this.object3 = new System.Windows.Forms.PictureBox();
            this.tutorial2 = new System.Windows.Forms.Label();
            this.object4 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.object5 = new System.Windows.Forms.PictureBox();
            this.finish = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.object6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.object2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.object1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.object3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.object4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.object5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.object6)).BeginInit();
            this.SuspendLayout();
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.floor.BackgroundImage = global::LA_1300_C.Properties.Resources.level1_stone2;
            this.floor.Location = new System.Drawing.Point(0, 551);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(1068, 112);
            this.floor.TabIndex = 0;
            this.floor.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::LA_1300_C.Properties.Resources.player1;
            this.player.Location = new System.Drawing.Point(167, 492);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(60, 60);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // object2
            // 
            this.object2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.object2.BackgroundImage = global::LA_1300_C.Properties.Resources.level1_stone6;
            this.object2.Location = new System.Drawing.Point(825, 254);
            this.object2.Name = "object2";
            this.object2.Size = new System.Drawing.Size(243, 298);
            this.object2.TabIndex = 2;
            this.object2.TabStop = false;
            this.object2.Click += new System.EventHandler(this.object2_Click);
            // 
            // movementTimer
            // 
            this.movementTimer.Tick += new System.EventHandler(this.movementTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 637);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // object1
            // 
            this.object1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.object1.BackgroundImage = global::LA_1300_C.Properties.Resources.level1_stone3;
            this.object1.Location = new System.Drawing.Point(337, 391);
            this.object1.Name = "object1";
            this.object1.Size = new System.Drawing.Size(315, 66);
            this.object1.TabIndex = 4;
            this.object1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(909, 637);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // tutorial1
            // 
            this.tutorial1.AutoSize = true;
            this.tutorial1.BackColor = System.Drawing.Color.Transparent;
            this.tutorial1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tutorial1.ForeColor = System.Drawing.Color.White;
            this.tutorial1.Location = new System.Drawing.Point(115, 9);
            this.tutorial1.Name = "tutorial1";
            this.tutorial1.Size = new System.Drawing.Size(255, 32);
            this.tutorial1.TabIndex = 6;
            this.tutorial1.Text = "Use A and D to move";
            // 
            // object3
            // 
            this.object3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.object3.BackgroundImage = global::LA_1300_C.Properties.Resources.level1_stone3;
            this.object3.Location = new System.Drawing.Point(337, 254);
            this.object3.Name = "object3";
            this.object3.Size = new System.Drawing.Size(109, 144);
            this.object3.TabIndex = 7;
            this.object3.TabStop = false;
            // 
            // tutorial2
            // 
            this.tutorial2.AutoSize = true;
            this.tutorial2.BackColor = System.Drawing.Color.Transparent;
            this.tutorial2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tutorial2.ForeColor = System.Drawing.Color.White;
            this.tutorial2.Location = new System.Drawing.Point(115, 41);
            this.tutorial2.Name = "tutorial2";
            this.tutorial2.Size = new System.Drawing.Size(174, 32);
            this.tutorial2.TabIndex = 6;
            this.tutorial2.Text = "Space = Jump";
            // 
            // object4
            // 
            this.object4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.object4.BackgroundImage = global::LA_1300_C.Properties.Resources.level1_stone2;
            this.object4.Location = new System.Drawing.Point(0, 189);
            this.object4.Name = "object4";
            this.object4.Size = new System.Drawing.Size(446, 66);
            this.object4.TabIndex = 8;
            this.object4.TabStop = false;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Pink;
            this.background.BackgroundImage = global::LA_1300_C.Properties.Resources.background1;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1068, 663);
            this.background.TabIndex = 9;
            this.background.TabStop = false;
            // 
            // object5
            // 
            this.object5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.object5.BackgroundImage = global::LA_1300_C.Properties.Resources.level1_stone3;
            this.object5.Location = new System.Drawing.Point(647, 189);
            this.object5.Name = "object5";
            this.object5.Size = new System.Drawing.Size(421, 66);
            this.object5.TabIndex = 10;
            this.object5.TabStop = false;
            // 
            // finish
            // 
            this.finish.BackColor = System.Drawing.Color.Lime;
            this.finish.Location = new System.Drawing.Point(1063, 0);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(1, 700);
            this.finish.TabIndex = 11;
            this.finish.TabStop = false;
            this.finish.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(841, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "-->";
            // 
            // object6
            // 
            this.object6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.object6.BackgroundImage = global::LA_1300_C.Properties.Resources.level1_stone1;
            this.object6.Location = new System.Drawing.Point(0, 0);
            this.object6.Name = "object6";
            this.object6.Size = new System.Drawing.Size(109, 552);
            this.object6.TabIndex = 13;
            this.object6.TabStop = false;
            // 
            // Level01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 661);
            this.Controls.Add(this.object6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.object5);
            this.Controls.Add(this.object4);
            this.Controls.Add(this.object3);
            this.Controls.Add(this.tutorial2);
            this.Controls.Add(this.tutorial1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.object2);
            this.Controls.Add(this.object1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.player);
            this.Controls.Add(this.background);
            this.Name = "Level01";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.object2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.object1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.object3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.object4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.object5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.object6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox floor;
        private PictureBox player;
        private PictureBox object2;
        private System.Windows.Forms.Timer movementTimer;
        private Label label1;
        private PictureBox object1;
        private Label label2;
        private Label tutorial1;
        private PictureBox object3;
        private Label tutorial2;
        private PictureBox object4;
        private PictureBox background;
        private PictureBox object5;
        private PictureBox finish;
        private Label label3;
        private PictureBox object6;
    }
}