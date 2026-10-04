using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriaAnaliticaWinForm
{
    internal class Elipse
    {
        private float a;
        private float c;
        private float d;
        private float e;
        private float f;

        public Elipse()
        {

        }

        public Elipse(float a, float c, float d, float e, float f)
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

        public string Tipo()
        {
            if (this.A == 0 || this.C == 0)
            {
                return "No es una elipse";
            }
            else if (Math.Sign(this.A) != Math.Sign(this.C))
            {
                return "No es una elipse";
            }
            else if (this.A == this.C)
            {
                return "Es una circunferencia";
            }
            else if (this.A < this.C)
            {
                return "Horizontal";
            }
            else
            {
                return "Vertical";
            }
        }

        private float M
        {
            get
            {
                return ((this.D * this.D) / (4 * this.A))
                     + ((this.E * this.E) / (4 * this.C))
                     - this.F;
            }
        }

        public string Ecuacion()
        {
            if (this.A == 0 || this.C == 0 || Math.Sign(this.A) != Math.Sign(this.C) || this.A == this.C)
            {
                return "No es una elipse";
            }

            float h = (-this.D) / (2 * this.A);
            float k = (-this.E) / (2 * this.C);

            float a2, b2;

            if (this.A < this.C)
            {
                a2 = M / this.A;
                b2 = M / this.C;
            }
            else
            {
                a2 = M / this.C;
                b2 = M / this.A;
            }

            if (a2 <= 0 || b2 <= 0)
            {
                return "Elipse degenerada";
            }

            string signoH;
            if (h > 0)
            {
                signoH = $"- {h}";
            }
            else if (h < 0)
            {
                signoH = $"+ {Math.Abs(h)}";
            }
            else
            {
                signoH = "";
            }

            string signoK;
            if (k > 0)
            {
                signoK = $"- {k}";
            }
            else if (k < 0)
            {
                signoK = $"+ {Math.Abs(k)}";
            }
            else
            {
                signoK = "";
            }

            string termX;
            if (h == 0)
            {
                termX = "x";
            }
            else
            {
                termX = $"(x {signoH})";
            }

            string termY;
            if (k == 0)
            {
                termY = "y";
            }
            else
            {
                termY = $"(y {signoK})";
            }

            if (this.A < this.C)
            {
                return $"{termX}² / {a2} + {termY}² / {b2} = 1";
            }
            else
            {
                return $"{termX}² / {b2} + {termY}² / {a2} = 1";
            }
        }

        public string Centro()
        {
            if (this.A == 0 || this.C == 0 || Math.Sign(this.A) != Math.Sign(this.C) || this.A == this.C)
            {
                return "No es una elipse";
            }

            float h = (-this.D) / (2 * this.A);
            float k = (-this.E) / (2 * this.C);

            return $"({h} , {k})";
        }

        public string Semiejes()
        {
            if (this.A == 0 || this.C == 0 || Math.Sign(this.A) != Math.Sign(this.C) || this.A == this.C)
            {
                return "No es una elipse";
            }

            float a2, b2;

            if (this.A < this.C)
            {
                a2 = M / this.A;
                b2 = M / this.C;
            }
            else
            {
                a2 = M / this.C;
                b2 = M / this.A;
            }

            if (a2 <= 0 || b2 <= 0)
            {
                return "Elipse degenerada";
            }

            float semiA = (float)Math.Sqrt(a2);
            float semiB = (float)Math.Sqrt(b2);

            return $"a = {semiA} y b = {semiB}";
        }

        public string DF()
        {
            if (this.A == 0 || this.C == 0 || Math.Sign(this.A) != Math.Sign(this.C) || this.A == this.C)
            {
                return "No es una elipse";
            }

            float a2, b2;

            if (this.A < this.C)
            {
                a2 = M / this.A;
                b2 = M / this.C;
            }
            else
            {
                a2 = M / this.C;
                b2 = M / this.A;
            }

            if (a2 <= 0 || b2 <= 0)
            {
                return "Elipse degenerada";
            }

            float c = (float)Math.Sqrt(a2 - b2);

            return $"{c}";
        }

        public string Focos()
        {
            if (this.A == 0 || this.C == 0 || Math.Sign(this.A) != Math.Sign(this.C) || this.A == this.C)
            {
                return "No es una elipse";
            }

            float h = (-this.D) / (2 * this.A);
            float k = (-this.E) / (2 * this.C);

            float a2, b2;

            if (this.A < this.C)
            {
                a2 = M / this.A;
                b2 = M / this.C;
            }
            else
            {
                a2 = M / this.C;
                b2 = M / this.A;
            }

            if (a2 <= 0 || b2 <= 0)
            {
                return "Elipse degenerada";
            }

            float c = (float)Math.Sqrt(a2 - b2);

            if (this.A < this.C)
            {
                return $"F1 = ({h + c} , {k})  y  F2 = ({h - c} , {k})";
            }
            else
            {
                return $"F1 = ({h} , {k + c})  y  F2 = ({h} , {k - c})";
            }
        }

        public string VertMay()
        {
            if (this.A == 0 || this.C == 0 || Math.Sign(this.A) != Math.Sign(this.C) || this.A == this.C)
            {
                return "No es una elipse";
            }

            float h = (-this.D) / (2 * this.A);
            float k = (-this.E) / (2 * this.C);

            float a2;

            if (this.A < this.C)
            {
                a2 = M / this.A;
            }
            else
            {
                a2 = M / this.C;
            }

            if (a2 <= 0)
            {
                return "Elipse degenerada";
            }

            float semiA = (float)Math.Sqrt(a2);

            if (this.A < this.C)
            {
                return $"V1 = ({h + semiA} , {k})  y  V2 = ({h - semiA} , {k})";
            }
            else
            {
                return $"V1 = ({h} , {k + semiA})  y  V2 = ({h} , {k - semiA})";
            }
        }

        public string VertMen()
        {
            if (this.A == 0 || this.C == 0 || Math.Sign(this.A) != Math.Sign(this.C) || this.A == this.C)
            {
                return "No es una elipse";
            }

            float h = (-this.D) / (2 * this.A);
            float k = (-this.E) / (2 * this.C);

            float b2;

            if (this.A < this.C)
            {
                b2 = M / this.C;
            }
            else
            {
                b2 = M / this.A;
            }

            if (b2 <= 0)
            {
                return "Elipse degenerada";
            }

            float semiB = (float)Math.Sqrt(b2);

            if (this.A < this.C)
            {
                return $"V1 = ({h} , {k + semiB})  y  V2 = ({h} , {k - semiB})";
            }
            else
            {
                return $"V1 = ({h + semiB} , {k})  y  V2 = ({h - semiB} , {k})";
            }
        }

        public string LR()
        {
            if (this.A == 0 || this.C == 0 || Math.Sign(this.A) != Math.Sign(this.C) || this.A == this.C)
            {
                return "No es una elipse";
            }

            float a2, b2;

            if (this.A < this.C)
            {
                a2 = M / this.A;
                b2 = M / this.C;
            }
            else
            {
                a2 = M / this.C;
                b2 = M / this.A;
            }

            if (a2 <= 0 || b2 <= 0)
            {
                return "Elipse degenerada";
            }

            float semiA = (float)Math.Sqrt(a2);
            float semiB = (float)Math.Sqrt(b2);

            float lr = (2 * semiB * semiB) / semiA;

            return $"{lr}";
        }

        public string Exen()
        {
            if (this.A == 0 || this.C == 0 || Math.Sign(this.A) != Math.Sign(this.C) || this.A == this.C)
            {
                return "No es una elipse";
            }

            float a2, b2;

            if (this.A < this.C)
            {
                a2 = M / this.A;
                b2 = M / this.C;
            }
            else
            {
                a2 = M / this.C;
                b2 = M / this.A;
            }

            if (a2 <= 0 || b2 <= 0)
            {
                return "Elipse degenerada";
            }

            float semiA = (float)Math.Sqrt(a2);
            float c = (float)Math.Sqrt(a2 - b2);
            float e = c / semiA;

            return $"{e}";
        }
    }
}
