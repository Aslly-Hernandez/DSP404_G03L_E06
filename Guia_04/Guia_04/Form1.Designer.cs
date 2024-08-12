namespace Guia_04
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
            this.btnCalculo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nupBase = new System.Windows.Forms.NumericUpDown();
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.lstTabla1 = new System.Windows.Forms.ListBox();
            this.lstTabla2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupBase)).BeginInit();
            this.grbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(22, 103);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo.TabIndex = 0;
            this.btnCalculo.Text = "Ver tablas";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(22, 158);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Finalizar";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // nupBase
            // 
            this.nupBase.DecimalPlaces = 1;
            this.nupBase.Location = new System.Drawing.Point(12, 59);
            this.nupBase.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nupBase.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nupBase.Name = "nupBase";
            this.nupBase.Size = new System.Drawing.Size(120, 20);
            this.nupBase.TabIndex = 3;
            this.nupBase.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // grbResult
            // 
            this.grbResult.Controls.Add(this.lstTabla2);
            this.grbResult.Controls.Add(this.lstTabla1);
            this.grbResult.Location = new System.Drawing.Point(258, 26);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(296, 326);
            this.grbResult.TabIndex = 4;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "Resultados";
            // 
            // lstTabla1
            // 
            this.lstTabla1.FormattingEnabled = true;
            this.lstTabla1.Location = new System.Drawing.Point(18, 33);
            this.lstTabla1.Name = "lstTabla1";
            this.lstTabla1.Size = new System.Drawing.Size(120, 264);
            this.lstTabla1.TabIndex = 5;
            // 
            // lstTabla2
            // 
            this.lstTabla2.FormattingEnabled = true;
            this.lstTabla2.Location = new System.Drawing.Point(158, 33);
            this.lstTabla2.Name = "lstTabla2";
            this.lstTabla2.Size = new System.Drawing.Size(120, 264);
            this.lstTabla2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(573, 359);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.nupBase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalculo);
            this.Name = "Form1";
            this.Text = "Ingrese numero";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupBase)).EndInit();
            this.grbResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupBase;
        private System.Windows.Forms.GroupBox grbResult;
        private System.Windows.Forms.ListBox lstTabla2;
        private System.Windows.Forms.ListBox lstTabla1;
    }
}

