using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    abstract class Figura
    {
        public Punto PuntoDePartida { get; set; }
        public Punto PuntoDeSalida { get; set; }
        public int Colour { get; set; }

        public Figura(Punto P1, Punto P2, int Colour)
        {
            this.PuntoDePartida = P1;
            this.PuntoDeSalida = P2;
            this.Colour = Colour;
        }

        public abstract void Dibuja(Form form);
    }

    class Rectangulo : Figura
    {
        public Rectangulo(Punto P1, Punto P2, int Colour) : base(P1, P2,Colour) { 
        
        }

        public override void Dibuja(Form form) {
            Graphics graphics = form.CreateGraphics();
            graphics.DrawRectangle(new Pen(Color.Black, 2), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x - PuntoDePartida.x, PuntoDeSalida.y - PuntoDePartida.y);

            switch (this.Colour) {
                case 1:
                    graphics.FillRectangle(new SolidBrush(Color.Red), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x - PuntoDePartida.x, PuntoDeSalida.y - PuntoDePartida.y);
                    break;

                case 2:
                    graphics.FillRectangle(new SolidBrush(Color.Blue), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x - PuntoDePartida.x, PuntoDeSalida.y - PuntoDePartida.y);
                    break;

                case 3:
                    graphics.FillRectangle(new SolidBrush(Color.Green), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x - PuntoDePartida.x, PuntoDeSalida.y - PuntoDePartida.y);
                    break;

                case 4:
                    graphics.FillRectangle(new SolidBrush(Color.Black), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x - PuntoDePartida.x, PuntoDeSalida.y - PuntoDePartida.y);
                    break;

                case 5:
                    graphics.FillRectangle(new SolidBrush(Color.White), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x - PuntoDePartida.x, PuntoDeSalida.y - PuntoDePartida.y);
                    break;

                case 6:
                    graphics.FillRectangle(new SolidBrush(Color.Yellow), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x - PuntoDePartida.x, PuntoDeSalida.y - PuntoDePartida.y);
                    break;

            }
        }
    }

    class Elipse : Figura
    {
        public Elipse(Punto P1, Punto P2, int Colour) : base(P1, P2, Colour)
        {

        }

        public override void Dibuja(Form form)
        {
            Graphics graphics = form.CreateGraphics();
            graphics.DrawEllipse(new Pen(Color.Black, 2), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x - PuntoDePartida.x, PuntoDeSalida.y - PuntoDePartida.y);

            switch (this.Colour)
            {
                case 1:
                    graphics.FillEllipse(new SolidBrush(Color.Red), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x - PuntoDePartida.x, PuntoDeSalida.y - PuntoDePartida.y);
                    break;

                case 2:
                    graphics.FillEllipse(new SolidBrush(Color.Blue), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x - PuntoDePartida.x, PuntoDeSalida.y - PuntoDePartida.y);
                    break;

                case 3:
                    graphics.FillEllipse(new SolidBrush(Color.Green), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x - PuntoDePartida.x, PuntoDeSalida.y - PuntoDePartida.y);
                    break;

                case 4:
                    graphics.FillEllipse(new SolidBrush(Color.Black), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x - PuntoDePartida.x, PuntoDeSalida.y - PuntoDePartida.y);
                    break;

                case 5:
                    graphics.FillEllipse(new SolidBrush(Color.White), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x - PuntoDePartida.x, PuntoDeSalida.y - PuntoDePartida.y);
                    break;

                case 6:
                    graphics.FillEllipse(new SolidBrush(Color.Yellow), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x - PuntoDePartida.x, PuntoDeSalida.y - PuntoDePartida.y);
                    break;

            }
        }
    }

    class Linea : Figura
    {
        public Linea(Punto P1, Punto P2, int Colour) : base(P1, P2,Colour)
        {

        }

        public override void Dibuja(Form form)
        {
            Graphics graphics = form.CreateGraphics();
            switch (this.Colour)
            {
                case 1:
                    graphics.DrawLine(new Pen(Color.Red, 2), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x, PuntoDeSalida.y);
                    break;

                case 2:
                    graphics.DrawLine(new Pen(Color.Blue, 2), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x, PuntoDeSalida.y); 
                    break;

                case 3:
                    graphics.DrawLine(new Pen(Color.Green, 2), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x, PuntoDeSalida.y); 
                    break;

                case 4:
                    graphics.DrawLine(new Pen(Color.Black, 2), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x, PuntoDeSalida.y); 
                    break;

                case 5:
                    graphics.DrawLine(new Pen(Color.White, 2), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x, PuntoDeSalida.y); 
                    break;

                case 6:
                    graphics.DrawLine(new Pen(Color.Yellow, 2), PuntoDePartida.x, PuntoDePartida.y, PuntoDeSalida.x, PuntoDeSalida.y);
                    break;

            }
        }
    }
}
