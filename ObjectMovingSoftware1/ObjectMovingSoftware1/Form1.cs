using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Drawing2D;

namespace ObjectMovingSoftware1
{
    public partial class Form1 : Form
    {
        Rectangle seina, seina1, seina2, seina3, seina4, seina5, seina6, seina7, seina8, seina9, seina10, seina11, seina12, seina13, seina14; // seina

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Rectangle player1; //player
        Rectangle star; //player
        enum position
        {
            Left, Right, up, down
        }
        private position _objposition;
        public Form1()
        {
            InitializeComponent();
            _objposition = position.up;
            seina = new Rectangle(0, 0, 500, 10);       // seinä
            seina1 = new Rectangle(0, 451, 500, 10);    // seinä
            seina2 = new Rectangle(0, 0, 10, 500);      // seinä
            seina3 = new Rectangle(475, 0, 10, 500);    // seinä
            seina4 = new Rectangle(190, 0, 10, 430);    // seinä
            seina5 = new Rectangle(220, 30, 10, 400);   // seinä
            seina6 = new Rectangle(250, 0, 10, 400);    // seinä
            seina7 = new Rectangle(300, 30, 10, 400);   // seinä
            seina8 = new Rectangle(190, 420, 220, 10);  // seinä
            seina9 = new Rectangle(400, 30, 10, 400);   // seinä
            seina10 = new Rectangle(360, 0, 10, 400);   // seinä
            seina11 = new Rectangle(60, 30, 10, 400);   // seinä
            seina12 = new Rectangle(90, 30, 10, 400);   // seinä
            seina13 = new Rectangle(130, 10, 10, 400);  // seinä
            seina14 = new Rectangle(160, 30, 10, 421);  // seinä
            player1 = new Rectangle(200, 200, 20, 20);  // player
            star = new Rectangle(25, 200, 20, 20);      // star
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Blue), player1);
            e.Graphics.FillRectangle(new SolidBrush(Color.MediumVioletRed), star);
            DrawSeina(e);
        }
        private void DrawSeina(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), seina);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), seina1);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), seina2);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), seina3);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), seina4);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), seina5);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), seina6);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), seina7);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), seina8);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), seina9);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), seina10);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), seina11);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), seina12);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), seina13);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), seina14);
            
            #region detectcollision
            if (player1.IntersectsWith(star))
            {
                GameWon();
                Close();
            }
            if (player1.IntersectsWith(seina))
            {
                GameLost();
                Close();
            }
            if (player1.IntersectsWith(seina1))
            {
                GameLost();
                Close();
            }
            if (player1.IntersectsWith(seina2))
            {
                GameLost();
                Close();
            }
            if (player1.IntersectsWith(seina3))
            {
                GameLost();
                Close();
            }
            if (player1.IntersectsWith(seina4))
            {
                GameLost();
                Close();
            }
            if (player1.IntersectsWith(seina5))
            {
                GameLost();
                Close();
            }
            if (player1.IntersectsWith(seina6))
            {
                GameLost();
                Close();
            }
            if (player1.IntersectsWith(seina7))
            {
                GameLost();
                Close();
            }
            if (player1.IntersectsWith(seina8))
            {
                GameLost();
                Close();
            }
            if (player1.IntersectsWith(seina9))
            {
                GameLost();
                Close();
            }
            if (player1.IntersectsWith(seina10))
            {
                GameLost();
                Close();
            }
            if (player1.IntersectsWith(seina11))
            {
                GameLost();
                Close();
            }
            if (player1.IntersectsWith(seina12))
            {
                GameLost();
                Close();
            }
            if (player1.IntersectsWith(seina13))
            {
                GameLost();
                Close();
            }
            if (player1.IntersectsWith(seina14))
            {
                GameLost();
                Close();
            }
            #endregion
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_objposition == position.Right)
            {
                player1.X += 5;
            }
            else if (_objposition == position.Left)
            {
                player1.X -= 5;
            }
            else if (_objposition == position.up)
            {
                player1.Y -= 5;
            }
            else if (_objposition == position.down)
            {
                player1.Y += 5;
            }
            Invalidate();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                _objposition = position.Left;
            }
            else if (e.KeyCode == Keys.D)
            {
                _objposition = position.Right;
            }
            else if (e.KeyCode == Keys.W)
            {
                _objposition = position.up;
            }
            else if (e.KeyCode == Keys.S)
            {
                _objposition = position.down;
            }
        }
        public void GameLost()
        {
            timer1.Enabled = false;
            var gameOver = MessageBox.Show("Game over! Retry?", "Game over", MessageBoxButtons.YesNo);
            if (gameOver == DialogResult.No)
            {
                Close();
            } else
            {
                Application.Restart();
            }   
        }
        public void GameWon()
        {
            timer1.Enabled = false;
            var gameWon = MessageBox.Show("Game won! Retry?", "Game Won", MessageBoxButtons.YesNo);
            if (gameWon == DialogResult.No)
            {
                Close();
            }
            else
            {
                Application.Restart();
            }

        }
    }
}
