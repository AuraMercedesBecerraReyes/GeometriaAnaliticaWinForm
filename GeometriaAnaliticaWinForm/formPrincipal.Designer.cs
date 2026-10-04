namespace GeometriaAnaliticaWinForm
{
    partial class formPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonEcuGral = new Button();
            buttonRecta = new Button();
            buttonCircunferencia = new Button();
            buttonHiperbola = new Button();
            buttonElipse = new Button();
            buttonParabola = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 71);
            label3.Name = "label3";
            label3.Size = new Size(670, 23);
            label3.TabIndex = 4;
            label3.Text = "Bienvenido al programa de geometría analítica que te ayudará";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(122, 94);
            label4.Name = "label4";
            label4.Size = new Size(582, 23);
            label4.TabIndex = 5;
            label4.Text = "a encontrar los elementos de las cónicas y la recta.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(295, 451);
            label5.Name = "label5";
            label5.Size = new Size(241, 23);
            label5.TabIndex = 6;
            label5.Text = "Selecciona una opción";
            // 
            // buttonEcuGral
            // 
            buttonEcuGral.BackColor = Color.DimGray;
            buttonEcuGral.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEcuGral.ForeColor = SystemColors.Control;
            buttonEcuGral.Location = new Point(124, 498);
            buttonEcuGral.Name = "buttonEcuGral";
            buttonEcuGral.Size = new Size(187, 38);
            buttonEcuGral.TabIndex = 7;
            buttonEcuGral.Text = "Ecuación General";
            buttonEcuGral.UseVisualStyleBackColor = false;
            buttonEcuGral.Click += buttonEcuGral_Click;
            // 
            // buttonRecta
            // 
            buttonRecta.BackColor = Color.DimGray;
            buttonRecta.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRecta.ForeColor = SystemColors.ButtonFace;
            buttonRecta.Location = new Point(331, 498);
            buttonRecta.Name = "buttonRecta";
            buttonRecta.Size = new Size(163, 38);
            buttonRecta.TabIndex = 8;
            buttonRecta.Text = "Recta";
            buttonRecta.UseVisualStyleBackColor = false;
            buttonRecta.Click += buttonRecta_Click;
            // 
            // buttonCircunferencia
            // 
            buttonCircunferencia.BackColor = Color.DimGray;
            buttonCircunferencia.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCircunferencia.ForeColor = SystemColors.ButtonHighlight;
            buttonCircunferencia.Location = new Point(515, 498);
            buttonCircunferencia.Name = "buttonCircunferencia";
            buttonCircunferencia.Size = new Size(182, 38);
            buttonCircunferencia.TabIndex = 9;
            buttonCircunferencia.Text = "Circunferencia";
            buttonCircunferencia.UseVisualStyleBackColor = false;
            buttonCircunferencia.Click += buttonCircunferencia_Click;
            // 
            // buttonHiperbola
            // 
            buttonHiperbola.BackColor = Color.DimGray;
            buttonHiperbola.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHiperbola.ForeColor = Color.WhiteSmoke;
            buttonHiperbola.Location = new Point(515, 556);
            buttonHiperbola.Name = "buttonHiperbola";
            buttonHiperbola.Size = new Size(182, 38);
            buttonHiperbola.TabIndex = 12;
            buttonHiperbola.Text = "Hipérbola";
            buttonHiperbola.UseVisualStyleBackColor = false;
            buttonHiperbola.Click += buttonHiperbola_Click;
            // 
            // buttonElipse
            // 
            buttonElipse.BackColor = Color.DimGray;
            buttonElipse.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonElipse.ForeColor = Color.White;
            buttonElipse.Location = new Point(331, 556);
            buttonElipse.Name = "buttonElipse";
            buttonElipse.Size = new Size(163, 38);
            buttonElipse.TabIndex = 11;
            buttonElipse.Text = "Elipse";
            buttonElipse.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonElipse.UseVisualStyleBackColor = false;
            buttonElipse.Click += buttonElipse_Click;
            // 
            // buttonParabola
            // 
            buttonParabola.BackColor = Color.DimGray;
            buttonParabola.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonParabola.ForeColor = Color.Transparent;
            buttonParabola.Location = new Point(124, 556);
            buttonParabola.Name = "buttonParabola";
            buttonParabola.Size = new Size(187, 38);
            buttonParabola.TabIndex = 10;
            buttonParabola.Text = "Parábola";
            buttonParabola.UseVisualStyleBackColor = false;
            buttonParabola.Click += buttonParabola_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(96, 131);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(625, 305);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // formPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 718);
            Controls.Add(pictureBox2);
            Controls.Add(buttonHiperbola);
            Controls.Add(buttonElipse);
            Controls.Add(buttonParabola);
            Controls.Add(buttonCircunferencia);
            Controls.Add(buttonRecta);
            Controls.Add(buttonEcuGral);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "formPrincipal";
            Text = "Principal";
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(buttonEcuGral, 0);
            Controls.SetChildIndex(buttonRecta, 0);
            Controls.SetChildIndex(buttonCircunferencia, 0);
            Controls.SetChildIndex(buttonParabola, 0);
            Controls.SetChildIndex(buttonElipse, 0);
            Controls.SetChildIndex(buttonHiperbola, 0);
            Controls.SetChildIndex(pictureBox2, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonEcuGral;
        private Button buttonRecta;
        private Button buttonCircunferencia;
        private Button buttonHiperbola;
        private Button buttonElipse;
        private Button buttonParabola;
        private PictureBox pictureBox2;
    }
}