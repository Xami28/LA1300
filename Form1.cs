using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LA_1300_Projekt

{
    public partial class Form1 : Form
    {
        bool moveLeft, moveRight, moveUp;
        bool buttonpress;
        int speed = 12;
        public Form1()
        {

            InitializeComponent();
    
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void keyispress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if(moveLeft == true)
            {
                pictureBox1.Left -= speed;
            }
            if (moveRight == true)
            {
                pictureBox1.Left += speed;
            }
            if (moveUp == true)
            {
                pictureBox1.Top  -= speed*15;
            }
            if(buttonpress == true)
            {
                moveUp = false;
            }
           
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "object")
                {
                    if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
                    {
                        pictureBox1.Top += 0;
                    }
                    
                    else
                    {
                        pictureBox1.Top += 9;

                    }
                    if (pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds))
                    {
                        pictureBox1.Top += 0;
                        
                    }
                }
               
            }
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                moveLeft = true;
            }
            if(e.KeyCode == Keys.D)
            {
                moveRight = true;
            }
            if (e.KeyCode == Keys.Space && pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                moveUp = true;
                buttonpress = true;
                
            }
       
        }
        
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                moveRight = false;
            }
           
           

        }



    }
}