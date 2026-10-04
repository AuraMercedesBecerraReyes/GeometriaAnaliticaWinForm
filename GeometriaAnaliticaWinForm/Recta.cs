using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace GeometriaAnaliticaWinForm
{
    internal class Recta
    {
        private Punto p1 = new Punto();
        private Punto p2 = new Punto();

        internal Punto P1 { get => p1; set => p1 = value; }
        internal Punto P2 { get => p2; set => p2 = value; }

        public Recta()
        {

        }
        public Recta(Punto p1, Punto p2)
        {
            this.P1 = p1;
            this.P2 = p2;
        }

        public float Pendiente()
        {
            return ((this.P2.Y) - (this.P1.Y)) / ((this.P2.X) - (this.P1.X));
        }
        public float Distancia()
        {
            return Convert.ToSingle(Math.Sqrt(((this.P2.X - this.P1.X) * (this.P2.X - this.P1.X)) + ((this.P2.Y - this.P1.Y) * (this.P2.Y - this.P1.Y))));
        }
        public string PuntoMedio()
        {
            float xmed = ((this.P1.X) + (this.P2.X)) / 2;
            float ymed = ((this.P1.Y) + (this.P2.Y)) / 2;
            return $"({xmed},{ymed})";
        }
        public string EcuacionPO()
        {
            float b = (this.P1.Y) - (this.Pendiente() * (this.P1.X));
            if (b > 0)
            {
                return $"y = {this.Pendiente()}x + {b} ";
            }
            else if (b == 0)
            {
                return $"y = {this.Pendiente()}x ";
            }
            else
            {
                return $"y = {this.Pendiente()}x {b} ";
            }

        }

        public string EcuacionPP()
        {
            string derecha;
            string izquierda;

            
            if (this.P1.Y >= 0)
            {
                izquierda = $"y - {this.P1.Y}";
            }
            else
            {
                izquierda = $"y + {Math.Abs(this.P1.Y)}";
            }

            
            if (this.P1.X >= 0)
            {
                derecha = $"{this.Pendiente()}(x - {this.P1.X})";
            }
            else
            {
                derecha = $"{this.Pendiente()}(x + {Math.Abs(this.P1.X)})";
            }

            return $"{izquierda} = {derecha}";
        }

        public string EcuacionGen()
        {
            float A = this.Pendiente();
            float B = -1;
            float C = (this.P1.Y - (this.Pendiente() * this.P1.X));

            if (A < 0)
            {
                A = -A;
                B = -B;
                C = -C;
            }

            string termA;
            string termB;
            string termC;

            if (A == 1)
            {
                termA = "x";
            } else if (A == -1)
            {
                termA = "-x";
            } else
            {
                termA = $"{A}x";
            }

            if (B == 1)
            {
                termB = " + y";
            } else if ( B == -1)
            {
                termB = " - y";
            } else if (B > 0)
            {
                termB = $" + {B}y";
            } else if (B > 0)
            {
                termB = $" -{Math.Abs(B)}y";
            } else
            {
                termB = " ";
            }

            if (C == 0)
            {
                termC = " ";
            } else if (C > 0)
            {
                termC = $" + {C}";
            } else
            {
                termC = $" - {Math.Abs(C)}";
            }
            return $"{termA}{termB}{termC} = 0";


        }

    }
}
