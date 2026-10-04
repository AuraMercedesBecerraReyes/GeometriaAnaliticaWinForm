using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriaAnaliticaWinForm
{
    internal class Circunferencia
    {
        private float a;
        private float c;
        private float d;
        private float e;
        private float f;

        public Circunferencia()
        {

        }

        public Circunferencia(float a, float c, float d, float e, float f)
        {
            this.A = a;
            this.C = c;
            this.D = d;
            this.E = e;
            this.F = f;
        }

        public float A { get => a; set => a = value; }
        public float C { get => c; set => c = value; }
        public float D { get => d; set => d = value; }
        public float E { get => e; set => e = value; }
        public float F { get => f; set => f = value; }



        public string Centro()
        {
            if (this.A == 0 || this.C == 0 || this.A != this.C)
            {
                return "No es una circunferencia";
            }

            double h = (-(this.D) / (2 * this.A));
            double k = (-(this.E) / (2 * this.A));

            string termh;
            if (h == 0)
            {
                termh = "0";
            }
            else if (h > 0)
            {
                termh = $"{h}";
            }
            else
            {
                termh = $"-{Math.Abs(h)}";
            }

            string termk;
            if (k == 0)
            {
                termk = "0";
            }
            else if (k > 0)
            {
                termk = $"{k}";
            }
            else
            {
                termk = $"-{Math.Abs(k)}";
            }

            return $"({termh} , {termk})";
        }

        public string Radio()
        {
            if (this.A == 0 || this.C == 0 || this.A != this.C)
            {
                return "No es una circunferencia";
            }

            double h = (-(this.D) / (2 * this.A));
            double k = (-(this.E) / (2 * this.A));
            double rCuadrado = h * h + k * k - (this.F / this.A);

            if (rCuadrado < 0)
            {
                return "No es real";
            }
            else if (rCuadrado == 0)
            {
                return "Es un punto (radio = 0).";
            }
            else
            {
                double r = Math.Sqrt(rCuadrado);
                return $"{r}";
            }
        }

        public string EcuOrd()
        {
            if (this.A == 0 || this.C == 0 || this.A != this.C)
            {
                return "No es una circunferencia";
            }

            double h = (-(this.D) / (2 * this.A));
            double k = (-(this.E) / (2 * this.A));
            double rCuadrado = h * h + k * k - (this.F / this.A);

            if (rCuadrado < 0)
            {
                return "No es una circunferencia real.";
            }

            string signoH;
            if (h == 0)
                signoH = "";
            else if (h > 0)
                signoH = $"- {h}";
            else
                signoH = $"+ {Math.Abs(h)}";

            string signoK;
            if (k == 0)
                signoK = "";
            else if (k > 0)
                signoK = $"- {k}";
            else
                signoK = $"+ {Math.Abs(k)}";

            string termX;
            if (h == 0)
                termX = "x²";
            else
                termX = $"(x {signoH})²";

            string termY;
            if (k == 0)
                termY = "y²";
            else
                termY = $"(y {signoK})²";

            return $"{termX} + {termY} = {rCuadrado}";
        }

        public string InterseccionX()
        {
            if (this.A == 0 || this.C == 0 || this.A != this.C)
            {
                return "No es una circunferencia";
            }

            double h = (-(this.D) / (2 * this.A));
            double k = (-(this.E) / (2 * this.A));
            double rCuadrado = h * h + k * k - (this.F / this.A);

            if (rCuadrado < 0)
                return "No hay intersecciones.";

            double discriminante = rCuadrado - k * k;

            if (discriminante < 0)
            {
                return "No intersecta el eje X.";
            }
            else if (discriminante == 0)
            {
                return $"({h}, 0)";
            }
            else
            {
                double raiz = Math.Sqrt(discriminante);
                double x1 = h + raiz;
                double x2 = h - raiz;
                return $"({x1}, 0) y ({x2}, 0)";
            }
        }

        public string InterseccionY()
        {
            if (this.A == 0 || this.C == 0 || this.A != this.C)
            {
                return "No es una circunferencia";
            }

            double h = (-(this.D) / (2 * this.A));
            double k = (-(this.E) / (2 * this.A));
            double rCuadrado = h * h + k * k - (this.F / this.A);

            if (rCuadrado < 0)
                return "No hay intersecciones";

            double discriminante = rCuadrado - h * h;

            if (discriminante < 0)
            {
                return "No intersecta el eje Y.";
            }
            else if (discriminante == 0)
            {
                return $"(0, {k})";
            }
            else
            {
                double raiz = Math.Sqrt(discriminante);
                double y1 = k + raiz;
                double y2 = k - raiz;
                return $"(0, {y1}) y (0, {y2})";
            }
        }

        public double Area()
        {
            if (this.A == 0 || this.C == 0 || this.A != this.C)
            {
                return 0;
            }

            double h = (-(this.D) / (2 * this.A));
            double k = (-(this.E) / (2 * this.A));
            double rCuadrado = h * h + k * k - (this.F / this.A);

            if (rCuadrado < 0)
            {
                return 0;
            }

            return rCuadrado * Math.PI;
        }

        public double Perimetro()
        {
            if (this.A == 0 || this.C == 0 || this.A != this.C)
            {
                return 0;
            }

            double h = (-(this.D) / (2 * this.A));
            double k = (-(this.E) / (2 * this.A));
            double rCuadrado = h * h + k * k - (this.F / this.A);

            if (rCuadrado < 0)
            {
                return 0;
            }

            double r = Math.Sqrt(rCuadrado);
            return 2 * Math.PI * r;
        }
    }
}
