namespace Ejercicio3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResul = new System.Windows.Forms.Label();
            this.nudN1 = new System.Windows.Forms.NumericUpDown();
            this.nudN2 = new System.Windows.Forms.NumericUpDown();
            this.cmbOperaciones = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opciones Disponibles ";
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Location = new System.Drawing.Point(142, 221);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(44, 16);
            this.lblResul.TabIndex = 3;
            this.lblResul.Text = "label4";
            // 
            // nudN1
            // 
            this.nudN1.Location = new System.Drawing.Point(145, 71);
            this.nudN1.Name = "nudN1";
            this.nudN1.Size = new System.Drawing.Size(181, 22);
            this.nudN1.TabIndex = 4;
            // 
            // nudN2
            // 
            this.nudN2.Location = new System.Drawing.Point(145, 133);
            this.nudN2.Name = "nudN2";
            this.nudN2.Size = new System.Drawing.Size(181, 22);
            this.nudN2.TabIndex = 5;
            // 
            // cmbOperaciones
            // 
            this.cmbOperaciones.FormattingEnabled = true;
            this.cmbOperaciones.Location = new System.Drawing.Point(411, 132);
            this.cmbOperaciones.Name = "cmbOperaciones";
            this.cmbOperaciones.Size = new System.Drawing.Size(162, 24);
            this.cmbOperaciones.TabIndex = 6;
            this.cmbOperaciones.SelectedIndexChanged += new System.EventHandler(this.cmbOperaciones_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(631, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbOperaciones);
            this.Controls.Add(this.nudN2);
            this.Controls.Add(this.nudN1);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.NumericUpDown nudN1;
        private System.Windows.Forms.NumericUpDown nudN2;
        private System.Windows.Forms.ComboBox cmbOperaciones;
        private System.Windows.Forms.Button button1;
    }
}

