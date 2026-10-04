using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GeometriaAnaliticaWinForm
{
    public partial class FormRecta : FormPlantilla
    {
        public FormRecta()
        {
            InitializeComponent();
        }

        Recta r1 = new Recta();
        private void buttonDistancia_Click(object sender, EventArgs e)
        {
            r1.P1.X = Convert.ToSingle(textBoxX1.Text);
            r1.P1.Y = Convert.ToSingle(textBoxY1.Text);
            r1.P2.X = Convert.ToSingle(textBoxX2.Text);
            r1.P2.Y = Convert.ToSingle(textBoxY2.Text);
            textBoxDistancia.Text = Convert.ToString(r1.Distancia());
        }

        private void buttonPendiente_Click(object sender, EventArgs e)
        {
            r1.P1.X = Convert.ToSingle(textBoxX1.Text);
            r1.P1.Y = Convert.ToSingle(textBoxY1.Text);
            r1.P2.X = Convert.ToSingle(textBoxX2.Text);
            r1.P2.Y = Convert.ToSingle(textBoxY2.Text);
            textBoxPendiente.Text = Convert.ToString(r1.Pendiente());
        }

        private void buttonPM_Click(object sender, EventArgs e)
        {
            r1.P1.X = Convert.ToSingle(textBoxX1.Text);
            r1.P1.Y = Convert.ToSingle(textBoxY1.Text);
            r1.P2.X = Convert.ToSingle(textBoxX2.Text);
            r1.P2.Y = Convert.ToSingle(textBoxY2.Text);
            textBoxPM.Text = Convert.ToString(r1.PuntoMedio());

        }

        private void buttonEcuPO_Click(object sender, EventArgs e)
        {
            r1.P1.X = Convert.ToSingle(textBoxX1.Text);
            r1.P1.Y = Convert.ToSingle(textBoxY1.Text);
            r1.P2.X = Convert.ToSingle(textBoxX2.Text);
            r1.P2.Y = Convert.ToSingle(textBoxY2.Text);
            textBoxEcuPo.Text = Convert.ToString(r1.EcuacionPO());
        }

        private void buttonEcuPP_Click(object sender, EventArgs e)
        {
            r1.P1.X = Convert.ToSingle(textBoxX1.Text);
            r1.P1.Y = Convert.ToSingle(textBoxY1.Text);
            r1.P2.X = Convert.ToSingle(textBoxX2.Text);
            r1.P2.Y = Convert.ToSingle(textBoxY2.Text);
            textBoxEcuPP.Text = Convert.ToString(r1.EcuacionPP());
        }

        private void buttonEcuGen_Click(object sender, EventArgs e)
        {
            r1.P1.X = Convert.ToSingle(textBoxX1.Text);
            r1.P1.Y = Convert.ToSingle(textBoxY1.Text);
            r1.P2.X = Convert.ToSingle(textBoxX2.Text);
            r1.P2.Y = Convert.ToSingle(textBoxY2.Text);
            textBoxEcuGen.Text = Convert.ToString(r1.EcuacionGen());
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxX1.Clear();
            textBoxX2.Clear();
            textBoxY1.Clear();
            textBoxY2.Clear();
            textBoxDistancia.Clear();
            textBoxPendiente.Clear();
            textBoxPM.Clear();
            textBoxEcuGen.Clear();
            textBoxEcuPo.Clear();
            textBoxEcuPP.Clear();

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
