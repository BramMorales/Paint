using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    struct Punto
    {
        public int x { get; set; }
        public int y { get; set; }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    
    public partial class Form1 : Form
    {
        List<Figura> figuras = new List<Figura>();
        private string Estado = "Normal";
        private Punto PE;
        private int Figura, Poligono, Colour;
        private Point[] points = new Point[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void DibujaFiguras()
        {
            foreach (var figura in figuras)
                figura.Dibuja(this);
        }



        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Estado = "Dibujando";
            lbl_Coords.Text = String.Format($"x:{e.X},y:{e.Y}");
            PE = new Punto(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Estado = "Normal";
            lbl_Coords.Text = String.Format($"x:{e.X},y:{e.Y}");

            switch (Figura) 
            {
                case 1:
                    Rectangulo r1 = new Rectangulo(PE, new Punto(e.X, e.Y),Colour);
                    r1.Dibuja(this);
                    figuras.Add(r1);
                    break;

                case 2:
                    Elipse e1 = new Elipse(PE, new Punto(e.X, e.Y),Colour);
                    e1.Dibuja(this);
                    figuras.Add(e1);
                    break;

                case 3:
                    Linea l1 = new Linea(PE, new Punto(e.X, e.Y),Colour);
                    l1.Dibuja(this);
                    figuras.Add(l1);
                    break;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Estado == "Dibujando")
                lbl_Coords.Text = String.Format($"x:{e.X},y:{e.Y}");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.DibujaFiguras();
        }

        private void btn_Rectangulo_Click(object sender, EventArgs e)
        {
            Figura = 1;
        }

        private void btn_Elipse_Click(object sender, EventArgs e)
        {
            Figura = 2;
        }

        private void btn_Linea_Click(object sender, EventArgs e)
        {
            Figura = 3;
        }

        private void btn_Rojo_Click(object sender, EventArgs e)
        {
            Colour = 1;
        }

        private void btn_Azul_Click(object sender, EventArgs e)
        {
            Colour = 2;
        }

        private void btn_Verde_Click(object sender, EventArgs e)
        {
            Colour = 3;
        }

        private void btn_Morado_Click(object sender, EventArgs e)
        {
            Colour = 4;
        }

        private void btn_Blanco_Click(object sender, EventArgs e)
        {
            Colour = 5;
        }

        private void btn_Amarillo_Click(object sender, EventArgs e)
        {
            Colour = 6;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Figura == 4)
                if (Poligono < 5) {
                    points[Poligono] =  new Point(e.X, e.Y);
                    Poligono++;
                }
                else {
                    Graphics g = this.CreateGraphics();
                    g.DrawPolygon(new Pen(Color.Black,2),points);
                    switch (this.Colour)
                    {
                        case 1:
                            g.FillPolygon(new SolidBrush(Color.Red),points);
                            break;

                        case 2:
                            g.FillPolygon(new SolidBrush(Color.Blue), points);
                            break;

                        case 3:
                            g.FillPolygon(new SolidBrush(Color.Green), points);
                            break;

                        case 4:
                            g.FillPolygon(new SolidBrush(Color.Black), points);
                            break;

                        case 5:
                            g.FillPolygon(new SolidBrush(Color.White), points);
                            break;

                        case 6:
                            g.FillPolygon(new SolidBrush(Color.Yellow), points);
                            break;

                    }
                    Poligono = 0;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Figura = 4;
        }

    }
}
