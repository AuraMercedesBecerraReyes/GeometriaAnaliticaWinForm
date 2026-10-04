using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GeometriaAnaliticaWinForm
{
    public partial class formPrincipal : FormPlantilla
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void buttonEcuGral_Click(object sender, EventArgs e)
        {
            FormEcuGral formec1 = new FormEcuGral();
            formec1.Show();
        }

        private void buttonRecta_Click(object sender, EventArgs e)
        {
            FormRecta formr1 = new FormRecta();
            formr1.Show();
        }

        private void buttonCircunferencia_Click(object sender, EventArgs e)
        {
            FormCircunferencia formc1 = new FormCircunferencia();
            formc1.Show();
        }

        private void buttonParabola_Click(object sender, EventArgs e)
        {
            FormParabola formp1 = new FormParabola();
            formp1.Show();
        }

        private void buttonElipse_Click(object sender, EventArgs e)
        {
            FormElipse forme1 = new FormElipse();
            forme1.Show();
        }

        private void buttonHiperbola_Click(object sender, EventArgs e)
        {
            FormHiperbola formh1 = new FormHiperbola();
            formh1.Show();
        }
    }
}
