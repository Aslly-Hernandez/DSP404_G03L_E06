namespace WindowsFormsApp1
{
    partial class frmGuia04ejerc1
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
            this.lbltema = new System.Windows.Forms.Label();
            this.lstTabla1 = new System.Windows.Forms.ListBox();
            this.lstTabla2 = new System.Windows.Forms.ListBox();
            this.nupBase = new System.Windows.Forms.NumericUpDown();
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupBase)).BeginInit();
            this.grbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(30, 169);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(210, 56);
            this.btnCalculo.TabIndex = 0;
            this.btnCalculo.Text = "Ver Tablas";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // lbltema
            // 
            this.lbltema.AutoSize = true;
            this.lbltema.Location = new System.Drawing.Point(45, 76);
            this.lbltema.Name = "lbltema";
            this.lbltema.Size = new System.Drawing.Size(100, 16);
            this.lbltema.TabIndex = 2;
            this.lbltema.Text = "Ingrese número";
            // 
            // lstTabla1
            // 
            this.lstTabla1.FormattingEnabled = true;
            this.lstTabla1.ItemHeight = 16;
            this.lstTabla1.Location = new System.Drawing.Point(21, 33);
            this.lstTabla1.Name = "lstTabla1";
            this.lstTabla1.Size = new System.Drawing.Size(120, 308);
            this.lstTabla1.TabIndex = 3;
            // 
            // lstTabla2
            // 
            this.lstTabla2.FormattingEnabled = true;
            this.lstTabla2.ItemHeight = 16;
            this.lstTabla2.Location = new System.Drawing.Point(164, 33);
            this.lstTabla2.Name = "lstTabla2";
            this.lstTabla2.Size = new System.Drawing.Size(120, 308);
            this.lstTabla2.TabIndex = 4;
            // 
            // nupBase
            // 
            this.nupBase.DecimalPlaces = 1;
            this.nupBase.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nupBase.Location = new System.Drawing.Point(48, 118);
            this.nupBase.Maximum = new decimal(new int[] {
            69,
            0,
            0,
            65536});
            this.nupBase.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nupBase.Name = "nupBase";
            this.nupBase.Size = new System.Drawing.Size(120, 22);
            this.nupBase.TabIndex = 5;
            this.nupBase.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // grbResult
            // 
            this.grbResult.Controls.Add(this.lstTabla1);
            this.grbResult.Controls.Add(this.lstTabla2);
            this.grbResult.Location = new System.Drawing.Point(264, 45);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(298, 375);
            this.grbResult.TabIndex = 6;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "Resultados";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(30, 258);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(210, 56);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Finalizar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmGuia04ejerc1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.nupBase);
            this.Controls.Add(this.lbltema);
            this.Controls.Add(this.btnCalculo);
            this.Name = "frmGuia04ejerc1";
            this.Text = "frmGuia04ejerc1";
            this.Load += new System.EventHandler(this.frmGuia04ejerc1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupBase)).EndInit();
            this.grbResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Label lbltema;
        private System.Windows.Forms.ListBox lstTabla1;
        private System.Windows.Forms.ListBox lstTabla2;
        private System.Windows.Forms.NumericUpDown nupBase;
        private System.Windows.Forms.GroupBox grbResult;
        private System.Windows.Forms.Button btnSalir;
    }
}

