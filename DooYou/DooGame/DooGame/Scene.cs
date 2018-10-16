using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DooGame
{
    public partial class Scene : Form
    {
        public Scene()
        {
            InitializeComponent();
        }

        int length = 0;
        Font theFont = new Font("굴림", 20);
        Brush theBrush = new SolidBrush(Color.White);

        private void Scene_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("Images/main_ff.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void Scene_Paint(object sender, PaintEventArgs e)
        {
            
            e.Graphics.DrawImage(Image.FromFile("Images/main_ff.jpg"), this.Width, this.Height);

            //보류ㅠㅠ
            //if (length < testStr.Length)
            //{
            //    e.Graphics.DrawString(testStr.Substring(0, length), theFont, theBrush, 100, 50);
            //}
            //else
            //{
            //    e.Graphics.DrawString(testStr, theFont, theBrush, 100, 50);
            //}
        
        
        }

        private void Scene_MouseClick(object sender, MouseEventArgs e)
        {
            Text = String.Format("{0}, {1}", e.X, e.Y);

            if (213 < e.X && e.X < 546)
            {
                if (268 < e.Y && e.Y < 310)
                {
                    domibeP.Visible = true;
                }
            }
            //            Invalidate();
        }

        private void domibeP_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            domibeP.BackgroundImage = Image.FromFile("Images/domibe.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;

          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            length++;
            Invalidate();
        }

        private void NextS1_Click(object sender, EventArgs e)
        {
            blackP.Visible = true;
        }

        private void blackP_Paint(object sender, PaintEventArgs e)
        {
            blackP.BackgroundImage = Image.FromFile("Images/black.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
            TextS1.Text = "안녕하세용";
        }

      }


    }
