using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriaAnaliticaWinForm
{
    internal class Hiperbola
    {
        private float a;
        private float c;
        private float d;
        private float e;
        private float f;

        public Hiperbola()
        {

        }

        public Hiperbola(float a, float c, float d, float e, float f)
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
                return "No es una hipérbola";
            if (Math.Sign(this.A) == Math.Sign(this.C))
                return "No es una hipérbola";
            if (this.A > 0 && this.C < 0)
                return "Horizontal";
            else
                return "Vertical";
        }

        // M auxiliar
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
            if (this.A == 0 || this.C == 0 || Math.Sign(this.A) == Math.Sign(this.C))
                return "No es una hipérbola";

            float h = (-this.D) / (2 * this.A);
            float k = (-this.E) / (2 * this.C);

            float a2, b2;

            if (this.A > 0 && this.C < 0)
            {

                a2 = M / this.A;
                b2 = -M / this.C;
            }
            else
            {

                a2 = M / this.C;
                b2 = -M / this.A;
            }

            string signoH;
            if (h > 0) signoH = $"- {h}";
            else if (h < 0) signoH = $"+ {Math.Abs(h)}";
            else signoH = "";

            string signoK;
            if (k > 0) signoK = $"- {k}";
            else if (k < 0) signoK = $"+ {Math.Abs(k)}";
            else signoK = "";

            string termX = (h == 0) ? "x" : $"(x {signoH})";
            string termY = (k == 0) ? "y" : $"(y {signoK})";

            if (this.A > 0 && this.C < 0)
            {
                return $"{termX}² / {a2} - {termY}² / {b2} = 1";
            }
            else
            {

                return $"{termY}² / {a2} - {termX}² / {b2} = 1";
            }
        }

        public string Centro()
        {
            if (this.A == 0 || this.C == 0 || Math.Sign(this.A) == Math.Sign(this.C))
                return "No es una hipérbola";

            float h = (-this.D) / (2 * this.A);
            float k = (-this.E) / (2 * this.C);

            return $"({h} , {k})";
        }

        public string Semiejes()
        {
            if (this.A == 0 || this.C == 0 || Math.Sign(this.A) == Math.Sign(this.C))
                return "No es una hipérbola";

            float a2, b2;

            if (this.A > 0 && this.C < 0)
            {
                a2 = M / this.A;
                b2 = -M / this.C;
            }
            else
            {
                a2 = M / this.C;
                b2 = -M / this.A;
            }

            if (a2 <= 0 || b2 <= 0)
                return "Hipérbola degenerada";

            float semiA = (float)Math.Sqrt(a2);
            float semiB = (float)Math.Sqrt(b2);

            return $"a = {semiA} y b = {semiB}";
        }

        public string DF()
        {
            if (this.A == 0 || this.C == 0 || Math.Sign(this.A) == Math.Sign(this.C))
                return "No es una hipérbola";

            float a2, b2;

            if (this.A > 0 && this.C < 0)
            {
                a2 = M / this.A;
                b2 = -M / this.C;
            }
            else
            {
                a2 = M / this.C;
                b2 = -M / this.A;
            }

            if (a2 <= 0 || b2 <= 0)
                return "Hipérbola degenerada";

            float c = (float)Math.Sqrt(a2 + b2);

            return $"{c}";
        }

        public string Vertices()
        {
            if (this.A == 0 || this.C == 0 || Math.Sign(this.A) == Math.Sign(this.C))
                return "No es una hipérbola";

            float h = (-this.D) / (2 * this.A);
            float k = (-this.E) / (2 * this.C);

            float a2;

            if (this.A > 0 && this.C < 0)
                a2 = M / this.A;
            else
                a2 = M / this.C;

            if (a2 <= 0)
                return "Hipérbola degenerada";

            float semiA = (float)Math.Sqrt(a2);

            if (this.A > 0 && this.C < 0)
            {

                return $"V1 = ({h + semiA} , {k})  y  V2 = ({h - semiA} , {k})";
            }
            else
            {

                return $"V1 = ({h} , {k + semiA})  y  V2 = ({h} , {k - semiA})";
            }
        }

        public string Focos()
        {
            if (this.A == 0 || this.C == 0 || Math.Sign(this.A) == Math.Sign(this.C))
                return "No es una hipérbola";

            float h = (-this.D) / (2 * this.A);
            float k = (-this.E) / (2 * this.C);

            float a2, b2;

            if (this.A > 0 && this.C < 0)
            {
                a2 = M / this.A;
                b2 = -M / this.C;
            }
            else
            {
                a2 = M / this.C;
                b2 = -M / this.A;
            }

            if (a2 <= 0 || b2 <= 0)
                return "Hipérbola degenerada";

            float c = (float)Math.Sqrt(a2 + b2);

            if (this.A > 0 && this.C < 0)
            {

                return $"F1 = ({h + c} , {k})  y  F2 = ({h - c} , {k})";
            }
            else
            {

                return $"F1 = ({h} , {k + c})  y  F2 = ({h} , {k - c})";
            }
        }

        public string Asintotas()
        {
            if (this.A == 0 || this.C == 0 || Math.Sign(this.A) == Math.Sign(this.C))
                return "No es una hipérbola";

            float h = (-this.D) / (2 * this.A);
            float k = (-this.E) / (2 * this.C);

            float a2, b2;

            if (this.A > 0 && this.C < 0)
            {
                a2 = M / this.A;
                b2 = -M / this.C;
            }
            else
            {
                a2 = M / this.C;
                b2 = -M / this.A;
            }

            if (a2 <= 0 || b2 <= 0)
                return "Hipérbola degenerada";

            float semiA = (float)Math.Sqrt(a2);
            float semiB = (float)Math.Sqrt(b2);

            float pendiente = semiB / semiA; 

            string signoH;
            if (h > 0) signoH = $"- {h}";
            else if (h < 0) signoH = $"+ {Math.Abs(h)}";
            else signoH = "";

            string signoK;
            if (k > 0) signoK = $"- {k}";
            else if (k < 0) signoK = $"+ {Math.Abs(k)}";
            else signoK = "";

            string termX = (h == 0) ? "x" : $"(x {signoH})";
            string termY = (k == 0) ? "y" : $"(y {signoK})";

            return $"{termY} = ±{pendiente}{termX}";
        }

        public string Excen()
        {
            if (this.A == 0 || this.C == 0 || Math.Sign(this.A) == Math.Sign(this.C))
                return "No es una hipérbola";

            float a2, b2;

            if (this.A > 0 && this.C < 0)
            {
                a2 = M / this.A;
                b2 = -M / this.C;
            }
            else
            {
                a2 = M / this.C;
                b2 = -M / this.A;
            }

            if (a2 <= 0 || b2 <= 0)
                return "Hipérbola degenerada";

            float semiA = (float)Math.Sqrt(a2);
            float c = (float)Math.Sqrt(a2 + b2);
            float e = c / semiA;

            return $"{e}";
        }

        public string LR()
        {
            if (this.A == 0 || this.C == 0 || Math.Sign(this.A) == Math.Sign(this.C))
                return "No es una hipérbola";

            float a2, b2;

            if (this.A > 0 && this.C < 0)
            {
                a2 = M / this.A;
                b2 = -M / this.C;
            }
            else
            {
                a2 = M / this.C;
                b2 = -M / this.A;
            }

            if (a2 <= 0 || b2 <= 0)
                return "Hipérbola degenerada";

            float semiA = (float)Math.Sqrt(a2);
            float semiB = (float)Math.Sqrt(b2);


            float lr = (2 * semiB * semiB) / semiA;

            return $"{lr}";
        }
    }
}