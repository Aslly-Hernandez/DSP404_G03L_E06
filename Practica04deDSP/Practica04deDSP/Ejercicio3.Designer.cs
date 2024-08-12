namespace Practica04deDSP
{
    partial class Ejercicio3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nudN1 = new NumericUpDown();
            nudN2 = new NumericUpDown();
            cmbOperaciones = new ComboBox();
            lblresul = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudN1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudN2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 33);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 94);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 41);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 2;
            label3.Text = "Opciones disponibles";
            // 
            // nudN1
            // 
            nudN1.Location = new Point(122, 33);
            nudN1.Name = "nudN1";
            nudN1.Size = new Size(120, 23);
            nudN1.TabIndex = 3;
            // 
            // nudN2
            // 
            nudN2.Location = new Point(122, 92);
            nudN2.Name = "nudN2";
            nudN2.Size = new Size(120, 23);
            nudN2.TabIndex = 4;
            // 
            // cmbOperaciones
            // 
            cmbOperaciones.FormattingEnabled = true;
            cmbOperaciones.Location = new Point(307, 91);
            cmbOperaciones.Name = "cmbOperaciones";
            cmbOperaciones.Size = new Size(121, 23);
            cmbOperaciones.TabIndex = 5;
            cmbOperaciones.SelectedIndexChanged += cmbOperaciones_SelectedIndexChanged;
            // 
            // lblresul
            // 
            lblresul.AutoSize = true;
            lblresul.Location = new Point(122, 179);
            lblresul.Name = "lblresul";
            lblresul.Size = new Size(38, 15);
            lblresul.TabIndex = 6;
            lblresul.Text = "label4";
            // 
            // button1
            // 
            button1.Location = new Point(420, 229);
            button1.Name = "button1";
            button1.Size = new Size(104, 23);
            button1.TabIndex = 7;
            button1.Text = "Ir a ejemplo 4";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Ejercicio3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(536, 264);
            Controls.Add(button1);
            Controls.Add(lblresul);
            Controls.Add(cmbOperaciones);
            Controls.Add(nudN2);
            Controls.Add(nudN1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ejercicio3";
            Text = "Ejercicio3";
            Load += Ejercicio3_Load;
            ((System.ComponentModel.ISupportInitialize)nudN1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudN2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown nudN1;
        private NumericUpDown nudN2;
        private ComboBox cmbOperaciones;
        private Label lblresul;
        private Button button1;
    }
}