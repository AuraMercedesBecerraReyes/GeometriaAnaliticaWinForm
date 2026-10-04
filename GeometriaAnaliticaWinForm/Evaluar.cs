using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriaAnaliticaWinForm
{
    internal class Evaluar
    {
        private float a;
        private float b;
        private float c;
        private float d;
        private float e;
        private float f;

        public Evaluar()
        {

        }

        public Evaluar(float a, float b, float c, float d, float e, float f)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
            this.E = e;
            this.F = f;
        }

        public float A { get => a; set => a = value; }
        public float B { get => b; set => b = value; }
        public float C { get => c; set => c = value; }
        public float D { get => d; set => d = value; }
        public float E { get => e; set => e = value; }
        public float F { get => f; set => f = value; }

        public string Tipo()
        {
            if (this.A == 0 && this.B == 0 && this.C == 0)
            {
                return "Recta";
            } else if (this.A == this.C)
            {
                return "Circunferencia";
            } else if ((this.A == 0 && this.C != 0) || (this.A != 0 && this.C == 0))
            {
                return "Parábola";
            } else if ((this.A > 0 && this.C > 0) || (this.A < 0 && this.C < 0))
            {
                return "Elipse";
            } else if ((this.A > 0 && this.C < 0) || (this.A < 0 && this.C > 0))
            {
                return "Hipérbola";
            } else
            {
                return "Caso no válido";
            }
        }
    }
}
