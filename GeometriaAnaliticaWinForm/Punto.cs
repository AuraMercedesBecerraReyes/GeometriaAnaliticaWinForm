using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriaAnaliticaWinForm
{
    internal class Punto
    {
        private float x;
        private float y;

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }

        public Punto()
        {

        }
        public Punto(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

    }
}
