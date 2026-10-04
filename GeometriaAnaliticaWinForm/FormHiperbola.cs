using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GeometriaAnaliticaWinForm
{
    public partial class FormHiperbola : FormPlantilla
    {
        public FormHiperbola()
        {
            InitializeComponent();
        }

        Hiperbola h1 = new Hiperbola();

        private void buttonTipo_Click(object sender, EventArgs e)
        {
            h1.A = Convert.ToSingle(textBoxA.Text);
            h1.C = Convert.ToSingle(textBoxC.Text);
            h1.D = Convert.ToSingle(textBoxD.Text);
            h1.E = Convert.ToSingle(textBoxE.Text);
            h1.F = Convert.ToSingle(textBoxF.Text);
            textBoxTipo.Text = Convert.ToString(h1.Tipo());
        }

        private void buttonEcuacion_Click(object sender, EventArgs e)
        {
            h1.A = Convert.ToSingle(textBoxA.Text);
            h1.C = Convert.ToSingle(textBoxC.Text);
            h1.D = Convert.ToSingle(textBoxD.Text);
            h1.E = Convert.ToSingle(textBoxE.Text);
            h1.F = Convert.ToSingle(textBoxF.Text);
            textBoxEcuacion.Text = Convert.ToString(h1.Ecuacion());
        }

        private void buttonCentro_Click(object sender, EventArgs e)
        {
            h1.A = Convert.ToSingle(textBoxA.Text);
            h1.C = Convert.ToSingle(textBoxC.Text);
            h1.D = Convert.ToSingle(textBoxD.Text);
            h1.E = Convert.ToSingle(textBoxE.Text);
            h1.F = Convert.ToSingle(textBoxF.Text);
            textBoxCentro.Text = Convert.ToString(h1.Centro());
        }

        private void buttonSemiejes_Click(object sender, EventArgs e)
        {
            h1.A = Convert.ToSingle(textBoxA.Text);
            h1.C = Convert.ToSingle(textBoxC.Text);
            h1.D = Convert.ToSingle(textBoxD.Text);
            h1.E = Convert.ToSingle(textBoxE.Text);
            h1.F = Convert.ToSingle(textBoxF.Text);
            textBoxSemiejes.Text = Convert.ToString(h1.Semiejes());
        }

        private void buttonFocos_Click(object sender, EventArgs e)
        {
            h1.A = Convert.ToSingle(textBoxA.Text);
            h1.C = Convert.ToSingle(textBoxC.Text);
            h1.D = Convert.ToSingle(textBoxD.Text);
            h1.E = Convert.ToSingle(textBoxE.Text);
            h1.F = Convert.ToSingle(textBoxF.Text);
            textBoxFocos.Text = Convert.ToString(h1.Focos());
        }

        private void buttonDistFoc_Click(object sender, EventArgs e)
        {
            h1.A = Convert.ToSingle(textBoxA.Text);
            h1.C = Convert.ToSingle(textBoxC.Text);
            h1.D = Convert.ToSingle(textBoxD.Text);
            h1.E = Convert.ToSingle(textBoxE.Text);
            h1.F = Convert.ToSingle(textBoxF.Text);
            textBoxDistFoc.Text = Convert.ToString(h1.DF());
        }

        private void buttonLR_Click(object sender, EventArgs e)
        {
            h1.A = Convert.ToSingle(textBoxA.Text);
            h1.C = Convert.ToSingle(textBoxC.Text);
            h1.D = Convert.ToSingle(textBoxD.Text);
            h1.E = Convert.ToSingle(textBoxE.Text);
            h1.F = Convert.ToSingle(textBoxF.Text);
            textBoxLR.Text = Convert.ToString(h1.LR());
        }

        private void buttonExentricidad_Click(object sender, EventArgs e)
        {
            h1.A = Convert.ToSingle(textBoxA.Text);
            h1.C = Convert.ToSingle(textBoxC.Text);
            h1.D = Convert.ToSingle(textBoxD.Text);
            h1.E = Convert.ToSingle(textBoxE.Text);
            h1.F = Convert.ToSingle(textBoxF.Text);
            textBoxExen.Text = Convert.ToString(h1.Excen());
        }

        private void buttonVertices_Click(object sender, EventArgs e)
        {
            h1.A = Convert.ToSingle(textBoxA.Text);
            h1.C = Convert.ToSingle(textBoxC.Text);
            h1.D = Convert.ToSingle(textBoxD.Text);
            h1.E = Convert.ToSingle(textBoxE.Text);
            h1.F = Convert.ToSingle(textBoxF.Text);
            textBoxVertices.Text = Convert.ToString(h1.Vertices());
        }

        private void buttonAsintotas_Click(object sender, EventArgs e)
        {
            h1.A = Convert.ToSingle(textBoxA.Text);
            h1.C = Convert.ToSingle(textBoxC.Text);
            h1.D = Convert.ToSingle(textBoxD.Text);
            h1.E = Convert.ToSingle(textBoxE.Text);
            h1.F = Convert.ToSingle(textBoxF.Text);
            textBoxAsintotas.Text = Convert.ToString(h1.Asintotas());
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
            textBoxVertices.Clear();
            textBoxAsintotas.Clear();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHiperbola_Load(object sender, EventArgs e)
        {

        }
    }
}
