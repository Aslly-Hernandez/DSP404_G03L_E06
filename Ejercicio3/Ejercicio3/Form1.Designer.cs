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
            this.lstPalabras = new System.Windows.Forms.ListBox();
            this.lblPalabra = new System.Windows.Forms.Label();
            this.txtsignificado = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPalabras
            // 
            this.lstPalabras.FormattingEnabled = true;
            this.lstPalabras.ItemHeight = 16;
            this.lstPalabras.Location = new System.Drawing.Point(83, 71);
            this.lstPalabras.Name = "lstPalabras";
            this.lstPalabras.Size = new System.Drawing.Size(177, 244);
            this.lstPalabras.TabIndex = 0;
            this.lstPalabras.SelectedIndexChanged += new System.EventHandler(this.lstPalabras_SelectedIndexChanged);
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Location = new System.Drawing.Point(336, 71);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(55, 16);
            this.lblPalabra.TabIndex = 1;
            this.lblPalabra.Text = "Palabra";
            // 
            // txtsignificado
            // 
            this.txtsignificado.Enabled = false;
            this.txtsignificado.Location = new System.Drawing.Point(339, 154);
            this.txtsignificado.Multiline = true;
            this.txtsignificado.Name = "txtsignificado";
            this.txtsignificado.Size = new System.Drawing.Size(213, 161);
            this.txtsignificado.TabIndex = 2;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(169, 363);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(331, 28);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtsignificado);
            this.Controls.Add(this.lblPalabra);
            this.Controls.Add(this.lstPalabras);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPalabras;
        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.TextBox txtsignificado;
        private System.Windows.Forms.Button btnsalir;
    }
}

