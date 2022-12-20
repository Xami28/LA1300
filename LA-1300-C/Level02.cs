using LA_1300_C;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace movement
{
    public partial class Level02 : Form
    {
        public Level02()
        {
            InitializeComponent();
            hitboxes();
            player.Parent = background;
            player.BackColor = Color.Transparent;
            label3.Parent = background;
            label3.BackColor = Color.Transparent;
            tutorial1.Parent = background;
            tutorial1.BackColor = Color.Transparent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup);
            movementTimer.Enabled = true;
            movementTimer.Interval = 10;
            finished = false;
        }
        static PictureBox object2_left = new PictureBox();
        static PictureBox object2_right = new PictureBox();
        static PictureBox object2_top = new PictureBox();
        static PictureBox object2_bottom = new PictureBox();

        static PictureBox object1_left = new PictureBox();
        static PictureBox object1_right = new PictureBox();
        static PictureBox object1_top = new PictureBox();
        static PictureBox object1_bottom = new PictureBox();

        static PictureBox object3_left = new PictureBox();
        static PictureBox object3_right = new PictureBox();
        static PictureBox object3_top = new PictureBox();
        static PictureBox object3_bottom = new PictureBox();

        static PictureBox object4_left = new PictureBox();
        static PictureBox object4_right = new PictureBox();
        static PictureBox object4_top = new PictureBox();
        static PictureBox object4_bottom = new PictureBox();

        static PictureBox object5_left = new PictureBox();
        static PictureBox object5_right = new PictureBox();
        static PictureBox object5_top = new PictureBox();
        static PictureBox object5_bottom = new PictureBox();

        static PictureBox object6_left = new PictureBox();
        static PictureBox object6_right = new PictureBox();
        static PictureBox object6_top = new PictureBox();
        static PictureBox object6_bottom = new PictureBox();

        static bool jump, left, right, airtime, onground, finished;
        static int speed = 10;
        static int jumpHeight = 200;
        static int estimatedJumpCoordinates;
        

        public void hitboxes()
        {
            ///-OBJECT2-\\\

            object2_left.Location = new System.Drawing.Point(object2.Location.X, object2.Location.Y + 14);
            object2_left.Size = new System.Drawing.Size(1, object2.Height - 28);
            object2_left.Visible = false;
            object2_left.BackColor = Color.Red;
            this.Controls.Add(object2_left);

            object2_right.Location = new Point(object2.Location.X + object2.Width - 1, object2.Location.Y + 14);
            object2_right.Size = new System.Drawing.Size(1, object2.Height - 28);
            object2_right.Visible = false;
            object2_right.BackColor = Color.Red;
            this.Controls.Add(object2_right);

            object2_top.Location = new Point(object2.Location.X, object2.Location.Y);
            object2_top.Size = new System.Drawing.Size(object2.Width, 1);
            object2_top.Visible = false;
            object2_top.BackColor = Color.Red;
            this.Controls.Add(object2_top);

            object2_bottom.Location = new Point(object2.Location.X, object2.Location.Y + object2.Height);
            object2_bottom.Size = new System.Drawing.Size(object2.Width, 1);
            object2_bottom.Visible = false;
            object2_bottom.BackColor = Color.Red;
            this.Controls.Add(object2_bottom);

            ///-OBJECT1-\\\

            object1_left.Location = new System.Drawing.Point(object1.Location.X, object1.Location.Y + 14);
            object1_left.Size = new System.Drawing.Size(1, object1.Height - 28);
            object1_left.Visible = false;
            object1_left.BackColor = Color.Red;
            this.Controls.Add(object1_left);

            object1_right.Location = new Point(object1.Location.X + object1.Width - 1, object1.Location.Y + 14);
            object1_right.Size = new System.Drawing.Size(1, object1.Height - 28);
            object1_right.Visible = false;
            object1_right.BackColor = Color.Red;
            this.Controls.Add(object1_right);

            object1_top.Location = new Point(object1.Location.X, object1.Location.Y);
            object1_top.Size = new System.Drawing.Size(object1.Width, 1);
            object1_top.Visible = false;
            object1_top.BackColor = Color.Red;
            this.Controls.Add(object1_top);

            object1_bottom.Location = new Point(object1.Location.X, object1.Location.Y + object1.Height);
            object1_bottom.Size = new System.Drawing.Size(object1.Width, 1);
            object1_bottom.Visible = false;
            object1_bottom.BackColor = Color.Red;
            this.Controls.Add(object1_bottom);

            ///-OBJECT3-\\\

            object3_left.Location = new System.Drawing.Point(object3.Location.X, object3.Location.Y + 14);
            object3_left.Size = new System.Drawing.Size(1, object3.Height - 28);
            object3_left.Visible = false;
            object3_left.BackColor = Color.Red;
            this.Controls.Add(object3_left);

            object3_right.Location = new Point(object3.Location.X + object3.Width - 1, object3.Location.Y + 14);
            object3_right.Size = new System.Drawing.Size(1, object3.Height - 28);
            object3_right.Visible = false;
            object3_right.BackColor = Color.Red;
            this.Controls.Add(object3_right);

            object3_top.Location = new Point(object3.Location.X, object3.Location.Y);
            object3_top.Size = new System.Drawing.Size(object3.Width, 1);
            object3_top.Visible = false;
            object3_top.BackColor = Color.Red;
            this.Controls.Add(object3_top);

            object3_bottom.Location = new Point(object3.Location.X, object3.Location.Y + object3.Height);
            object3_bottom.Size = new System.Drawing.Size(object3.Width, 1);
            object3_bottom.Visible = false;
            object3_bottom.BackColor = Color.Red;
            this.Controls.Add(object3_bottom);

            ///-OBJECT4-\\\

            object4_left.Location = new System.Drawing.Point(object4.Location.X, object4.Location.Y + 14);
            object4_left.Size = new System.Drawing.Size(1, object4.Height - 28);
            object4_left.Visible = false;
            object4_left.BackColor = Color.Red;
            this.Controls.Add(object4_left);

            object4_right.Location = new Point(object4.Location.X + object4.Width - 1, object4.Location.Y + 14);
            object4_right.Size = new System.Drawing.Size(1, object4.Height - 28);
            object4_right.Visible = false;
            object4_right.BackColor = Color.Red;
            this.Controls.Add(object4_right);

            object4_top.Location = new Point(object4.Location.X, object4.Location.Y);
            object4_top.Size = new System.Drawing.Size(object4.Width, 1);
            object4_top.Visible = false;
            object4_top.BackColor = Color.Red;
            this.Controls.Add(object4_top);

            object4_bottom.Location = new Point(object4.Location.X, object4.Location.Y + object4.Height);
            object4_bottom.Size = new System.Drawing.Size(object4.Width, 1);
            object4_bottom.Visible = false;
            object4_bottom.BackColor = Color.Red;
            this.Controls.Add(object4_bottom);

            ///-OBJECT5-\\\

            object5_left.Location = new System.Drawing.Point(object5.Location.X, object5.Location.Y + 14);
            object5_left.Size = new System.Drawing.Size(1, object5.Height - 28);
            object5_left.Visible = false;
            object5_left.BackColor = Color.Red;
            this.Controls.Add(object5_left);

            object5_right.Location = new Point(object5.Location.X + object5.Width - 1, object5.Location.Y + 14);
            object5_right.Size = new System.Drawing.Size(1, object5.Height - 28);
            object5_right.Visible = false;
            object5_right.BackColor = Color.Red;
            this.Controls.Add(object5_right);

            object5_top.Location = new Point(object5.Location.X, object5.Location.Y);
            object5_top.Size = new System.Drawing.Size(object5.Width, 1);
            object5_top.Visible = false;
            object5_top.BackColor = Color.Red;
            this.Controls.Add(object5_top);

            object5_bottom.Location = new Point(object5.Location.X, object5.Location.Y + object5.Height);
            object5_bottom.Size = new System.Drawing.Size(object5.Width, 1);
            object5_bottom.Visible = false;
            object5_bottom.BackColor = Color.Red;
            this.Controls.Add(object5_bottom);

            ///-OBJECT6-\\\

            object6_left.Location = new System.Drawing.Point(object6.Location.X, object6.Location.Y + 14);
            object6_left.Size = new System.Drawing.Size(1, object6.Height - 28);
            object6_left.Visible = false;
            object6_left.BackColor = Color.Red;
            this.Controls.Add(object6_left);

            object6_right.Location = new Point(object6.Location.X + object6.Width - 1, object6.Location.Y + 14);
            object6_right.Size = new System.Drawing.Size(1, object6.Height - 28);
            object6_right.Visible = false;
            object6_right.BackColor = Color.Red;
            this.Controls.Add(object6_right);

            object6_top.Location = new Point(object6.Location.X, object6.Location.Y);
            object6_top.Size = new System.Drawing.Size(object6.Width, 1);
            object6_top.Visible = false;
            object6_top.BackColor = Color.Red;
            this.Controls.Add(object6_top);

            object6_bottom.Location = new Point(object6.Location.X, object6.Location.Y + object6.Height);
            object6_bottom.Size = new System.Drawing.Size(object6.Width, 1);
            object6_bottom.Visible = false;
            object6_bottom.BackColor = Color.Red;
            this.Controls.Add(object6_bottom);
        }
        private void movementTimer_Tick(object sender, EventArgs e)
        {
            if (left == true) { player.Left -= speed; }
            if (right == true) { player.Left += speed; }
            if (jump == true)
            {
                if (onground == true && airtime == false) { estimatedJumpCoordinates = player.Location.Y - jumpHeight; airtime = true; }

                if (player.Location.Y >= estimatedJumpCoordinates && airtime == true)
                {
                    player.Top -= 15;
                    onground = false;
                }
                if (player.Location.Y <= estimatedJumpCoordinates)
                {
                    label1.Text = "reached";
                    airtime = false;
                }
            }

            //HITBOX FINISH
            if (player.Bounds.IntersectsWith(finish.Bounds))
            {
                if (finished == false)
                {
                    finished = true;
                    left = false;
                    right = false;
                    jump = false;
                    new Level03().Show();
                    this.Close();
                }
                label1.Text = "finish";
            }

            //HITBOX FLOOR
            if (player.Bounds.IntersectsWith(floor.Bounds))
            {
                speed = 10;
                player.Location = new Point(player.Location.X, floor.Location.Y - player.Height +1);
                label1.Text = "floor";
            }

            //HITBOXES OBJECT 2
            if (player.Bounds.IntersectsWith(object2_left.Bounds))
            {
                player.Location = new Point(object2.Location.X - player.Width, player.Location.Y);
                label1.Text = "left boundaries (object 2)";
            }
            if (player.Bounds.IntersectsWith(object2_right.Bounds))
            {
                player.Location = new Point(object2.Location.X + object2.Width, player.Location.Y);
                label1.Text = "right boundaries (object 2)";
            }
            if (player.Bounds.IntersectsWith(object2_top.Bounds))
            {
                player.Location = new Point(player.Location.X, object2.Location.Y - player.Height + 1);
                label1.Text = "top boundaries (object 2)";
            }
            if (player.Bounds.IntersectsWith(object2_bottom.Bounds))
            {
                player.Location = new Point(player.Location.X, object2.Location.Y + object2.Height);
                label1.Text = "bottom boundaries (object 2)";
                airtime = false;
            }

            //HITBOXES OBJECT 1
            if (player.Bounds.IntersectsWith(object1_left.Bounds))
            {
                player.Location = new Point(object1.Location.X - player.Width, player.Location.Y);
                label1.Text = "left boundaries (object 1)";
            }
            if (player.Bounds.IntersectsWith(object1_right.Bounds))
            {
                player.Location = new Point(object1.Location.X + object1.Width, player.Location.Y);
                label1.Text = "right boundaries (object 1)";
            }
            if (player.Bounds.IntersectsWith(object1_top.Bounds))
            {
                player.Location = new Point(player.Location.X, object1.Location.Y - player.Height + 1);
                label1.Text = "top boundaries (object 1)";
            }
            if (player.Bounds.IntersectsWith(object1_bottom.Bounds))
            {
                player.Location = new Point(player.Location.X, object1.Location.Y + object1.Height);
                label1.Text = "bottom boundaries (object 1)";
                airtime = false;
            }

            //HITBOXES OBJECT 3
            if (player.Bounds.IntersectsWith(object3_left.Bounds))
            {
                player.Location = new Point(object3.Location.X - player.Width, player.Location.Y);
                label1.Text = "left boundaries (object 3)";
            }
            if (player.Bounds.IntersectsWith(object3_right.Bounds))
            {
                player.Location = new Point(object3.Location.X + object3.Width, player.Location.Y);
                label1.Text = "right boundaries (object 3)";
            }
            if (player.Bounds.IntersectsWith(object3_top.Bounds))
            {
                player.Location = new Point(player.Location.X, object3.Location.Y - player.Height + 1);
                label1.Text = "top boundaries (object 3)";
            }
            if (player.Bounds.IntersectsWith(object3_bottom.Bounds))
            {
                player.Location = new Point(player.Location.X, object3.Location.Y + object3.Height);
                label1.Text = "bottom boundaries (object 3)";
                airtime = false;
            }

            //HITBOXES OBJECT 4
            if (player.Bounds.IntersectsWith(object4_left.Bounds))
            {
                player.Location = new Point(object4.Location.X - player.Width, player.Location.Y);
                label1.Text = "left boundaries (object 4)";
            }
            if (player.Bounds.IntersectsWith(object4_right.Bounds))
            {
                player.Location = new Point(object4.Location.X + object4.Width, player.Location.Y);
                label1.Text = "right boundaries (object 4)";
            }
            if (player.Bounds.IntersectsWith(object4_top.Bounds))
            {
                player.Location = new Point(player.Location.X, object4.Location.Y - player.Height + 1);
                label1.Text = "top boundaries (object 4)";
            }
            if (player.Bounds.IntersectsWith(object4_bottom.Bounds))
            {
                player.Location = new Point(player.Location.X, object4.Location.Y + object4.Height);
                label1.Text = "bottom boundaries (object 4)";
                airtime = false;
            }

            //HITBOXES OBJECT 5
            if (player.Bounds.IntersectsWith(object5_left.Bounds))
            {
                player.Location = new Point(object5.Location.X - player.Width, player.Location.Y);
                label1.Text = "left boundaries (object 5)";
            }
            if (player.Bounds.IntersectsWith(object5_right.Bounds))
            {
                player.Location = new Point(object5.Location.X + object5.Width, player.Location.Y);
                label1.Text = "right boundaries (object 5)";
            }
            if (player.Bounds.IntersectsWith(object5_top.Bounds))
            {
                player.Location = new Point(player.Location.X, object5.Location.Y - player.Height + 1);
                label1.Text = "top boundaries (object 5)";
            }
            if (player.Bounds.IntersectsWith(object5_bottom.Bounds))
            {
                player.Location = new Point(player.Location.X, object5.Location.Y + object5.Height);
                label1.Text = "bottom boundaries (object 5)";
                airtime = false;
            }

            //HITBOXES OBJECT 6
            if (player.Bounds.IntersectsWith(object6_left.Bounds))
            {
                player.Location = new Point(object6.Location.X - player.Width, player.Location.Y);
                label1.Text = "left boundaries (object 6)";
            }
            if (player.Bounds.IntersectsWith(object6_right.Bounds))
            {
                player.Location = new Point(object6.Location.X + object6.Width, player.Location.Y);
                label1.Text = "right boundaries (object 6)";
            }
            if (player.Bounds.IntersectsWith(object6_top.Bounds))
            {
                player.Location = new Point(player.Location.X, object6.Location.Y - player.Height + 1);
                label1.Text = "top boundaries (object 6)";
            }
            if (player.Bounds.IntersectsWith(object6_bottom.Bounds))
            {
                player.Location = new Point(player.Location.X, object6.Location.Y + object6.Height);
                label1.Text = "bottom boundaries (object 6)";
                airtime = false;
            }

            if (player.Bounds.IntersectsWith(object3_top.Bounds) || player.Bounds.IntersectsWith(object6_top.Bounds) || player.Bounds.IntersectsWith(object5_top.Bounds) || player.Bounds.IntersectsWith(object4_top.Bounds) || player.Bounds.IntersectsWith(floor.Bounds) || player.Bounds.IntersectsWith(object1_top.Bounds) || player.Bounds.IntersectsWith(object2_top.Bounds)) { onground = true; }
            else { onground = false; }
            if (onground == false && airtime == false)
            {
                player.Top += 11;
            }
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { if (onground == true) { jump = true; }}
            if (e.KeyCode == Keys.A) { left = true; }
            if (e.KeyCode == Keys.D) { right = true; }
        }
        private void keyup(object sender, KeyEventArgs e)
        {
            label2.Text = "Input: " + Convert.ToString(e.KeyCode);
            if (e.KeyCode == Keys.Space) { jump = false; onground = false; airtime = false; }
            if (e.KeyCode == Keys.A) { left = false; }
            if (e.KeyCode == Keys.D) { right = false; }
        }
    }
}