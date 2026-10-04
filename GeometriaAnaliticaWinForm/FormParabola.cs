using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GeometriaAnaliticaWinForm
{
    public partial class FormParabola : FormPlantilla
    {
        public FormParabola()
        {
            InitializeComponent();
        }

        Parabola p1 = new Parabola();

        private void buttonTipo_Click(object sender, EventArgs e)
        {
            p1.A = Convert.ToSingle(textBoxA.Text);
            p1.C = Convert.ToSingle(textBoxC.Text);
            p1.D = Convert.ToSingle(textBoxD.Text);
            p1.E = Convert.ToSingle(textBoxE.Text);
            p1.F = Convert.ToSingle(textBoxF.Text);
            textBoxTipo.Text = Convert.ToString(p1.Tipo());

        }

        private void buttonEcuacion_Click(object sender, EventArgs e)
        {
            p1.A = Convert.ToSingle(textBoxA.Text);
            p1.C = Convert.ToSingle(textBoxC.Text);
            p1.D = Convert.ToSingle(textBoxD.Text);
            p1.E = Convert.ToSingle(textBoxE.Text);
            p1.F = Convert.ToSingle(textBoxF.Text);
            textBoxEcuacion.Text = Convert.ToString(p1.Ecuacion());
        }

        private void buttonVertice_Click(object sender, EventArgs e)
        {
            p1.A = Convert.ToSingle(textBoxA.Text);
            p1.C = Convert.ToSingle(textBoxC.Text);
            p1.D = Convert.ToSingle(textBoxD.Text);
            p1.E = Convert.ToSingle(textBoxE.Text);
            p1.F = Convert.ToSingle(textBoxF.Text);
            textBoxVertice.Text = Convert.ToString(p1.Vertice());
        }

        private void buttonDirectriz_Click(object sender, EventArgs e)
        {
            p1.A = Convert.ToSingle(textBoxA.Text);
            p1.C = Convert.ToSingle(textBoxC.Text);
            p1.D = Convert.ToSingle(textBoxD.Text);
            p1.E = Convert.ToSingle(textBoxE.Text);
            p1.F = Convert.ToSingle(textBoxF.Text);
            textBoxDirectriz.Text = Convert.ToString(p1.Directriz());
        }

        private void buttonDistFoc_Click(object sender, EventArgs e)
        {
            p1.A = Convert.ToSingle(textBoxA.Text);
            p1.C = Convert.ToSingle(textBoxC.Text);
            p1.D = Convert.ToSingle(textBoxD.Text);
            p1.E = Convert.ToSingle(textBoxE.Text);
            p1.F = Convert.ToSingle(textBoxF.Text);
            textBoxDistFoc.Text = Convert.ToString(p1.DF());
        }

        private void buttonLR_Click(object sender, EventArgs e)
        {
            p1.A = Convert.ToSingle(textBoxA.Text);
            p1.C = Convert.ToSingle(textBoxC.Text);
            p1.D = Convert.ToSingle(textBoxD.Text);
            p1.E = Convert.ToSingle(textBoxE.Text);
            p1.F = Convert.ToSingle(textBoxF.Text);
            textBoxLR.Text = Convert.ToString(p1.LR());
        }

        private void buttonFoco_Click(object sender, EventArgs e)
        {
            p1.A = Convert.ToSingle(textBoxA.Text);
            p1.C = Convert.ToSingle(textBoxC.Text);
            p1.D = Convert.ToSingle(textBoxD.Text);
            p1.E = Convert.ToSingle(textBoxE.Text);
            p1.F = Convert.ToSingle(textBoxF.Text);
            textBoxFoco.Text = Convert.ToString(p1.Foco());
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxC.Clear();
            textBoxD.Clear();
            textBoxE.Clear();
            textBoxF.Clear();
            textBoxTipo.Clear();
            textBoxEcuacion.Clear();
            textBoxVertice.Clear();
            textBoxDirectriz.Clear();
            textBoxDistFoc.Clear();
            textBoxLR.Clear();
            textBoxFoco.Clear();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
