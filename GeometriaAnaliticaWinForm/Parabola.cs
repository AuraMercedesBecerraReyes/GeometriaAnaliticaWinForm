using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriaAnaliticaWinForm
{
    internal class Parabola
    {
        private float a;
        private float c;
        private float d;
        private float e;
        private float f;

        public Parabola()
        {

        }

        public Parabola(float a, float c, float d, float e, float f)
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
            if (this.A == 0 && this.C == 0)
            {
                return "No es una parábola";
            }
            else if (this.A != 0 && this.C == 0)
            {
                return "Vertical";
            }
            else if (this.A == 0 && this.C != 0)
            {
                return "Horizontal";
            }
            else
            {
                return "No es una parábola";
            }
        }

        public string Vertice()
        {
            if (this.A != 0 && this.C == 0)
            {
                float h = (-this.D) / (2 * this.A);
                float k = ((this.D * this.D) - (4 * this.A * this.F)) / (4 * this.A * this.E);
                return $"({h} , {k})";
            }
            else if (this.A == 0 && this.C != 0)
            {
                float k = (-this.E) / (2 * this.C);
                float h = ((this.E * this.E) - (4 * this.C * this.F)) / (4 * this.C * this.D);
                return $"({h} , {k})";
            }
            else
            {
                return "No es una parábola";
            }
        }

        public string DF()
        {
            if (this.A != 0 && this.C == 0)
            {
                float p = (-this.E) / (4 * this.A);
                if (p > 0)
                {
                    return $"{p} (arriba)";
                }
                else if (p < 0)
                {
                    return $"{p} (abajo)";
                }
                else
                {
                    return "Caso degenerado";
                }
            }
            else if (this.A == 0 && this.C != 0)
            {
                float p = (-this.D) / (4 * this.C);
                if (p > 0)
                {
                    return $"{p} (derecha)";
                }
                else if (p < 0)
                {
                    return $"{p} (izquierda)";
                }
                else
                {
                    return "Caso degenerado";
                }
            }
            else
            {
                return "No es una parábola";
            }
        }

        public string Ecuacion()
        {
            if (this.A != 0 && this.C == 0)
            {
                float h = (-this.D) / (2 * this.A);
                float k = ((this.D * this.D) - (4 * this.A * this.F)) / (4 * this.A * this.E);
                float p = (-this.E) / (4 * this.A);
                float cuatroP = 4 * p;

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

                return $"{termX}² = {cuatroP}{termY}";
            }
            else if (this.A == 0 && this.C != 0)
            {
                float h = ((this.E * this.E) - (4 * this.C * this.F)) / (4 * this.C * this.D);
                float k = (-this.E) / (2 * this.C);
                float p = (-this.D) / (4 * this.C);
                float cuatroP = 4 * p;

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

                return $"{termY}² = {cuatroP}{termX}";
            }
            else
            {
                return "No es una parábola";
            }
        }

        public string Directriz()
        {
            if (this.A != 0 && this.C == 0)
            {
                float k = ((this.D * this.D) - (4 * this.A * this.F)) / (4 * this.A * this.E);
                float p = (-this.E) / (4 * this.A);

                float y = k - p;

                return $"y = {y}";
            }
            else if (this.A == 0 && this.C != 0)
            {
                float h = ((this.E * this.E) - (4 * this.C * this.F)) / (4 * this.C * this.D);
                float p = (-this.D) / (4 * this.C);

                float x = h - p;

                return $"x = {x}";
            }
            else
            {
                return "No es una parábola";
            }
        }

        public string LR()
        {
            if (this.A != 0 && this.C == 0)
            {
                float p = (-this.E) / (4 * this.A);
                float LR = Math.Abs(4 * p);
                return $"{LR}";
            }
            else if (this.A == 0 && this.C != 0)
            {
                float p = (-this.D) / (4 * this.C);
                float LR = Math.Abs(4 * p);
                return $"{LR}";
            }
            else
            {
                return "No es una parábola";
            }
        }

        public string Foco()
        {
            if (this.A != 0 && this.C == 0)
            {
                float h = (-this.D) / (2 * this.A);
                float k = ((this.D * this.D) - (4 * this.A * this.F)) / (4 * this.A * this.E);
                float p = (-this.E) / (4 * this.A);

                float kp = k + p;

                return $"({h} , {kp})";
            }
            else if (this.A == 0 && this.C != 0)
            {
                float h = ((this.E * this.E) - (4 * this.C * this.F)) / (4 * this.C * this.D);
                float k = (-this.E) / (2 * this.C);
                float p = (-this.D) / (4 * this.C);

                float hp = h + p;

                return $"({hp} , {k})";
            }
            else
            {
                return "No es una parábola";
            }
        }
    }
}
