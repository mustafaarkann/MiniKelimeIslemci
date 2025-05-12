

//**BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
//**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
//**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
//**					2023-2024 BAHAR DÖNEMİ
//**	
//**				ÖDEV NUMARASI...1......:
//**ÖĞRENCİ ADI...MUSTAFA ARKAN.......:
//**ÖĞRENCİ NUMARASI..B231210089.....:
//**DERSİN ALINDIĞI GRUP..A.:
//****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ÖDEV
{

    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form2 : Form
    {

        private string selectedShape;
        private Point startPoint;
        private bool isDrawing;

        public Form2()
        {

            InitializeComponent();

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                isDrawing = true;
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Graphics g = this.CreateGraphics();
                g.Clear(Color.White);

                switch (selectedShape)
                {
                    case "Kare":
                        DrawSquare(startPoint, e.Location);
                        break;
                    case "Dikdörtgen":
                        DrawRectangle(startPoint, e.Location);
                        break;
                    case "Cember":
                        DrawCircle(startPoint, e.Location);
                        break;
                    case "Elips":
                        DrawEllipse(startPoint, e.Location);
                        break;
                    case "Üçgen":
                        DrawTriangle(startPoint, e.Location);
                        break;
                }
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void kareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedShape = "Kare";
        }

        private void dikdörtgenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedShape = "Dikdörtgen";
        }

        private void çemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedShape = "Cember";
        }

        private void elipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedShape = "Elips";
        }

        private void üçgenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedShape = "Üçgen";
        }

        private void DrawSquare(Point startPoint, Point endPoint)
        {
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
        }

        private void DrawRectangle(Point startPoint, Point endPoint)
        {
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y));
        }

        private void DrawCircle(Point startPoint, Point endPoint)
        {
            Graphics g = this.CreateGraphics();
            int radius = (int)Math.Sqrt(Math.Pow((endPoint.X - startPoint.X), 2) + Math.Pow((endPoint.Y - startPoint.Y), 2));
            g.DrawEllipse(new Pen(Color.Black, 2), new Rectangle(startPoint.X - radius, startPoint.Y - radius, 2 * radius, 2 * radius));
        }

        private void DrawEllipse(Point startPoint, Point endPoint)
        {
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(new Pen(Color.Black, 2), new Rectangle(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y));
        }

        private void DrawTriangle(Point startPoint, Point endPoint)
        {
            Graphics g = this.CreateGraphics();
            Point[] points = { new Point(startPoint.X, endPoint.Y), new Point((endPoint.X + startPoint.X) / 2, startPoint.Y), endPoint };
            g.DrawPolygon(new Pen(Color.Black, 2), points);
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }


    }



}

