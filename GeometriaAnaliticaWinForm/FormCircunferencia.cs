using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GeometriaAnaliticaWinForm
{
    public partial class FormCircunferencia : FormPlantilla
    {
        public FormCircunferencia()
        {
            InitializeComponent();
        }
        Circunferencia c1 = new Circunferencia();
        private void buttonCentro_Click(object sender, EventArgs e)
        {
            c1.A = Convert.ToSingle(textBoxA.Text);
            c1.C = Convert.ToSingle(textBoxC.Text);
            c1.D = Convert.ToSingle(textBoxD.Text);
            c1.E = Convert.ToSingle(textBoxE.Text);
            c1.F = Convert.ToSingle(textBoxF.Text);
            textBoxCentro.Text = Convert.ToString(c1.Centro());
        }

        private void buttonRadio_Click(object sender, EventArgs e)
        {
            c1.A = Convert.ToSingle(textBoxA.Text);
            c1.C = Convert.ToSingle(textBoxC.Text);
            c1.D = Convert.ToSingle(textBoxD.Text);
            c1.E = Convert.ToSingle(textBoxE.Text);
            c1.F = Convert.ToSingle(textBoxF.Text);
            textBoxRadio.Text = Convert.ToString(c1.Radio());
        }

        private void buttonArea_Click(object sender, EventArgs e)
        {
            c1.A = Convert.ToSingle(textBoxA.Text);
            c1.C = Convert.ToSingle(textBoxC.Text);
            c1.D = Convert.ToSingle(textBoxD.Text);
            c1.E = Convert.ToSingle(textBoxE.Text);
            c1.F = Convert.ToSingle(textBoxF.Text);
            textBoxArea.Text = Convert.ToString(c1.Area());
        }

        private void buttonPerimetro_Click(object sender, EventArgs e)
        {
            c1.A = Convert.ToSingle(textBoxA.Text);
            c1.C = Convert.ToSingle(textBoxC.Text);
            c1.D = Convert.ToSingle(textBoxD.Text);
            c1.E = Convert.ToSingle(textBoxE.Text);
            c1.F = Convert.ToSingle(textBoxF.Text);
            textBoxPerimetro.Text = Convert.ToString(c1.Perimetro());
        }

        private void buttonIntX_Click(object sender, EventArgs e)
        {
            c1.A = Convert.ToSingle(textBoxA.Text);
            c1.C = Convert.ToSingle(textBoxC.Text);
            c1.D = Convert.ToSingle(textBoxD.Text);
            c1.E = Convert.ToSingle(textBoxE.Text);
            c1.F = Convert.ToSingle(textBoxF.Text);
            textIntX.Text = Convert.ToString(c1.InterseccionX());
        }

        private void buttonIntY_Click(object sender, EventArgs e)
        {
            c1.A = Convert.ToSingle(textBoxA.Text);
            c1.C = Convert.ToSingle(textBoxC.Text);
            c1.D = Convert.ToSingle(textBoxD.Text);
            c1.E = Convert.ToSingle(textBoxE.Text);
            c1.F = Convert.ToSingle(textBoxF.Text);
            textBoxIntY.Text = Convert.ToString(c1.InterseccionY());
        }

        private void buttonEcuOrd_Click(object sender, EventArgs e)
        {
            c1.A = Convert.ToSingle(textBoxA.Text);
            c1.C = Convert.ToSingle(textBoxC.Text);
            c1.D = Convert.ToSingle(textBoxD.Text);
            c1.E = Convert.ToSingle(textBoxE.Text);
            c1.F = Convert.ToSingle(textBoxF.Text);
            textBoxEcuOrd.Text = Convert.ToString(c1.EcuOrd());
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxC.Clear();
            textBoxD.Clear();
            textBoxE.Clear();
            textBoxF.Clear();
            textBoxCentro.Clear();
            textBoxRadio.Clear();
            textBoxArea.Clear();
            textBoxPerimetro.Clear();
            textBoxEcuOrd.Clear();
            textBoxIntY.Clear();
            textIntX.Clear();

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
