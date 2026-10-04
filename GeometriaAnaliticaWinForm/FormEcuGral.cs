using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GeometriaAnaliticaWinForm
{
    public partial class FormEcuGral : FormPlantilla
    {
        public FormEcuGral()
        {
            InitializeComponent();
        }

        Evaluar eva1 = new Evaluar();
        private void buttonEvaluar_Click(object sender, EventArgs e)
        {
            eva1.A = Convert.ToSingle(textBoxA.Text);
            eva1.B = Convert.ToSingle(textBoxB.Text);
            eva1.C = Convert.ToSingle(textBoxC.Text);
            eva1.D = Convert.ToSingle(textBoxD.Text);
            eva1.E = Convert.ToSingle(textBoxE.Text);
            eva1.F = Convert.ToSingle(textBoxF.Text);

            textBoxResultado.Text = Convert.ToString(eva1.Tipo());
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
            textBoxD.Clear();
            textBoxE.Clear();
            textBoxF.Clear();
            textBoxResultado.Clear();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
