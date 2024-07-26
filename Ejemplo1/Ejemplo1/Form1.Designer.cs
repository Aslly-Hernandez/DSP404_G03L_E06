namespace Ejemplo1
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
            this.BtnContar = new System.Windows.Forms.Button();
            this.btnReinicio = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnContar
            // 
            this.BtnContar.Location = new System.Drawing.Point(37, 34);
            this.BtnContar.Name = "BtnContar";
            this.BtnContar.Size = new System.Drawing.Size(75, 23);
            this.BtnContar.TabIndex = 0;
            this.BtnContar.Text = "Contar";
            this.BtnContar.UseVisualStyleBackColor = true;
            this.BtnContar.Click += new System.EventHandler(this.BtnContar_Click);
            // 
            // btnReinicio
            // 
            this.btnReinicio.Location = new System.Drawing.Point(178, 34);
            this.btnReinicio.Name = "btnReinicio";
            this.btnReinicio.Size = new System.Drawing.Size(105, 23);
            this.btnReinicio.TabIndex = 1;
            this.btnReinicio.Text = "Reiniciar conteo";
            this.btnReinicio.UseVisualStyleBackColor = true;
            this.btnReinicio.Click += new System.EventHandler(this.btnReinicio_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(175, 152);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(105, 23);
            this.btnFin.TabIndex = 2;
            this.btnFin.Text = "Salir del programa";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(34, 87);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ir al ejemplo 2 (Guia01)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(310, 279);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnReinicio);
            this.Controls.Add(this.BtnContar);
            this.Name = "Form1";
            this.Text = "Pruebas de ambitos de variables";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnContar;
        private System.Windows.Forms.Button btnReinicio;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button button1;
    }
}

