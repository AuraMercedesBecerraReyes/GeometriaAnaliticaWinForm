using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GeometriaAnaliticaWinForm
{
    public partial class FormElipse : FormPlantilla
    {
        public FormElipse()
        {
            InitializeComponent();
        }

        Elipse e1 = new Elipse();

        private void buttonTipo_Click(object sender, EventArgs e)
        {
            e1.A = Convert.ToSingle(textBoxA.Text);
            e1.C = Convert.ToSingle(textBoxC.Text);
            e1.D = Convert.ToSingle(textBoxD.Text);
            e1.E = Convert.ToSingle(textBoxE.Text);
            e1.F = Convert.ToSingle(textBoxF.Text);
            textBoxTipo.Text = Convert.ToString(e1.Tipo());

        }

        private void buttonEcuacion_Click(object sender, EventArgs e)
        {
            e1.A = Convert.ToSingle(textBoxA.Text);
            e1.C = Convert.ToSingle(textBoxC.Text);
            e1.D = Convert.ToSingle(textBoxD.Text);
            e1.E = Convert.ToSingle(textBoxE.Text);
            e1.F = Convert.ToSingle(textBoxF.Text);
            textBoxEcuacion.Text = Convert.ToString(e1.Ecuacion());
        }

        private void buttonCentro_Click(object sender, EventArgs e)
        {
            e1.A = Convert.ToSingle(textBoxA.Text);
            e1.C = Convert.ToSingle(textBoxC.Text);
            e1.D = Convert.ToSingle(textBoxD.Text);
            e1.E = Convert.ToSingle(textBoxE.Text);
            e1.F = Convert.ToSingle(textBoxF.Text);
            textBoxCentro.Text = Convert.ToString(e1.Centro());
        }

        private void buttonSemiejes_Click(object sender, EventArgs e)
        {
            e1.A = Convert.ToSingle(textBoxA.Text);
            e1.C = Convert.ToSingle(textBoxC.Text);
            e1.D = Convert.ToSingle(textBoxD.Text);
            e1.E = Convert.ToSingle(textBoxE.Text);
            e1.F = Convert.ToSingle(textBoxF.Text);
            textBoxSemiejes.Text = Convert.ToString(e1.Semiejes());
        }

        private void buttonFocos_Click(object sender, EventArgs e)
        {
            e1.A = Convert.ToSingle(textBoxA.Text);
            e1.C = Convert.ToSingle(textBoxC.Text);
            e1.D = Convert.ToSingle(textBoxD.Text);
            e1.E = Convert.ToSingle(textBoxE.Text);
            e1.F = Convert.ToSingle(textBoxF.Text);
            textBoxFocos.Text = Convert.ToString(e1.Focos());
        }

        private void buttonDistFoc_Click(object sender, EventArgs e)
        {
            e1.A = Convert.ToSingle(textBoxA.Text);
            e1.C = Convert.ToSingle(textBoxC.Text);
            e1.D = Convert.ToSingle(textBoxD.Text);
            e1.E = Convert.ToSingle(textBoxE.Text);
            e1.F = Convert.ToSingle(textBoxF.Text);
            textBoxDistFoc.Text = Convert.ToString(e1.DF());
        }

        private void buttonLR_Click(object sender, EventArgs e)
        {
            e1.A = Convert.ToSingle(textBoxA.Text);
            e1.C = Convert.ToSingle(textBoxC.Text);
            e1.D = Convert.ToSingle(textBoxD.Text);
            e1.E = Convert.ToSingle(textBoxE.Text);
            e1.F = Convert.ToSingle(textBoxF.Text);
            textBoxLR.Text = Convert.ToString(e1.LR());
        }

        private void buttonExentricidad_Click(object sender, EventArgs e)
        {
            e1.A = Convert.ToSingle(textBoxA.Text);
            e1.C = Convert.ToSingle(textBoxC.Text);
            e1.D = Convert.ToSingle(textBoxD.Text);
            e1.E = Convert.ToSingle(textBoxE.Text);
            e1.F = Convert.ToSingle(textBoxF.Text);
            textBoxExen.Text = Convert.ToString(e1.Exen());
        }

        private void buttonVertMay_Click(object sender, EventArgs e)
        {
            e1.A = Convert.ToSingle(textBoxA.Text);
            e1.C = Convert.ToSingle(textBoxC.Text);
            e1.D = Convert.ToSingle(textBoxD.Text);
            e1.E = Convert.ToSingle(textBoxE.Text);
            e1.F = Convert.ToSingle(textBoxF.Text);
            textBoxVertMay.Text = Convert.ToString(e1.VertMay());
        }

        private void buttonVertMen_Click(object sender, EventArgs e)
        {
            e1.A = Convert.ToSingle(textBoxA.Text);
            e1.C = Convert.ToSingle(textBoxC.Text);
            e1.D = Convert.ToSingle(textBoxD.Text);
            e1.E = Convert.ToSingle(textBoxE.Text);
            e1.F = Convert.ToSingle(textBoxF.Text);
            textBoxVertMen.Text = Convert.ToString(e1.VertMen());
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
            textBoxCentro.Clear();
            textBoxSemiejes.Clear();
            textBoxFocos.Clear();
            textBoxDistFoc.Clear();
            textBoxLR.Clear();
            textBoxExen.Clear();
            textBoxVertMay.Clear();
            textBoxVertMen.Clear();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
