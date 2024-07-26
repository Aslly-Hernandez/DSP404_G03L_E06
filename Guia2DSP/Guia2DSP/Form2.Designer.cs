namespace Guia2DSP
{
    partial class frmCesar
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lbltexto = new System.Windows.Forms.Label();
            this.lblllave = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtLlave = new System.Windows.Forms.TextBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.rdbEncriptar = new System.Windows.Forms.RadioButton();
            this.rdbDesencriptar = new System.Windows.Forms.RadioButton();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.grOpcion = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grOpcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(158, 24);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(160, 13);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Encriptamiento por código César";
            this.lbltitulo.Click += new System.EventHandler(this.lbltitulo_Click);
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Location = new System.Drawing.Point(39, 71);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(198, 13);
            this.lbltexto.TabIndex = 1;
            this.lbltexto.Text = "Ingrese el texto a Encriptar/Desencriptar";
            // 
            // lblllave
            // 
            this.lblllave.AutoSize = true;
            this.lblllave.Location = new System.Drawing.Point(295, 71);
            this.lblllave.Name = "lblllave";
            this.lblllave.Size = new System.Drawing.Size(155, 13);
            this.lblllave.TabIndex = 2;
            this.lblllave.Text = "Llave (Digite un número entero)";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(39, 274);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 13);
            this.lblresultado.TabIndex = 3;
            // 
            // txtLlave
            // 
            this.txtLlave.Location = new System.Drawing.Point(456, 68);
            this.txtLlave.Name = "txtLlave";
            this.txtLlave.Size = new System.Drawing.Size(100, 20);
            this.txtLlave.TabIndex = 4;
            this.txtLlave.TextChanged += new System.EventHandler(this.txtLlave_TextChanged);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(42, 94);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(514, 68);
            this.txtTexto.TabIndex = 5;
            // 
            // rdbEncriptar
            // 
            this.rdbEncriptar.AutoSize = true;
            this.rdbEncriptar.Checked = true;
            this.rdbEncriptar.Location = new System.Drawing.Point(6, 37);
            this.rdbEncriptar.Name = "rdbEncriptar";
            this.rdbEncriptar.Size = new System.Drawing.Size(67, 17);
            this.rdbEncriptar.TabIndex = 7;
            this.rdbEncriptar.TabStop = true;
            this.rdbEncriptar.Text = "Encriptar";
            this.rdbEncriptar.UseVisualStyleBackColor = true;
            this.rdbEncriptar.CheckedChanged += new System.EventHandler(this.rdbEncriptar_CheckedChanged);
            // 
            // rdbDesencriptar
            // 
            this.rdbDesencriptar.AutoSize = true;
            this.rdbDesencriptar.Location = new System.Drawing.Point(169, 37);
            this.rdbDesencriptar.Name = "rdbDesencriptar";
            this.rdbDesencriptar.Size = new System.Drawing.Size(85, 17);
            this.rdbDesencriptar.TabIndex = 8;
            this.rdbDesencriptar.Text = "Desencriptar";
            this.rdbDesencriptar.UseVisualStyleBackColor = true;
            this.rdbDesencriptar.CheckedChanged += new System.EventHandler(this.rdbDesencriptar_CheckedChanged);
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(336, 181);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(75, 23);
            this.btnEncriptar.TabIndex = 9;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(336, 210);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(336, 239);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(42, 294);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(514, 68);
            this.txtResultado.TabIndex = 12;
            // 
            // grOpcion
            // 
            this.grOpcion.Controls.Add(this.rdbEncriptar);
            this.grOpcion.Controls.Add(this.rdbDesencriptar);
            this.grOpcion.Location = new System.Drawing.Point(37, 173);
            this.grOpcion.Name = "grOpcion";
            this.grOpcion.Size = new System.Drawing.Size(281, 74);
            this.grOpcion.TabIndex = 13;
            this.grOpcion.TabStop = false;
            this.grOpcion.Text = "Seleccione una opción ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(490, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ir al ejemplo 3";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grOpcion);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.txtLlave);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblllave);
            this.Controls.Add(this.lbltexto);
            this.Controls.Add(this.lbltitulo);
            this.Name = "frmCesar";
            this.Text = "Encriptador/Desencriptador de Código de César";
            this.Load += new System.EventHandler(this.frmCesar_Load);
            this.grOpcion.ResumeLayout(false);
            this.grOpcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lbltexto;
        private System.Windows.Forms.Label lblllave;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtLlave;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.RadioButton rdbEncriptar;
        private System.Windows.Forms.RadioButton rdbDesencriptar;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.GroupBox grOpcion;
        private System.Windows.Forms.Button button1;
    }
}