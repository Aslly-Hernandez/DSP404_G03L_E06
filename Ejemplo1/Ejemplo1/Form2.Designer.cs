namespace Ejemplo1
{
    partial class Form2
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
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTasaInter = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtTasaInterEX = new System.Windows.Forms.TextBox();
            this.rdbInteres1 = new System.Windows.Forms.RadioButton();
            this.rdbInteres2 = new System.Windows.Forms.RadioButton();
            this.rdbInteres3 = new System.Windows.Forms.RadioButton();
            this.lstResul = new System.Windows.Forms.ListBox();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(36, 32);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(106, 13);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Nombre de Empresa:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(36, 81);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(98, 13);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto prestamo ($)";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(240, 81);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(74, 13);
            this.lblTiempo.TabIndex = 2;
            this.lblTiempo.Text = "Tiempo (años)";
            // 
            // lblTasaInter
            // 
            this.lblTasaInter.AutoSize = true;
            this.lblTasaInter.Location = new System.Drawing.Point(36, 137);
            this.lblTasaInter.Name = "lblTasaInter";
            this.lblTasaInter.Size = new System.Drawing.Size(69, 13);
            this.lblTasaInter.TabIndex = 3;
            this.lblTasaInter.Text = "Tasa Interes:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(140, 29);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(310, 20);
            this.txtEmpresa.TabIndex = 4;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(140, 78);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(94, 20);
            this.txtMonto.TabIndex = 5;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(320, 78);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(130, 20);
            this.txtTiempo.TabIndex = 6;
            // 
            // txtTasaInterEX
            // 
            this.txtTasaInterEX.Enabled = false;
            this.txtTasaInterEX.Location = new System.Drawing.Point(306, 181);
            this.txtTasaInterEX.Name = "txtTasaInterEX";
            this.txtTasaInterEX.Size = new System.Drawing.Size(144, 20);
            this.txtTasaInterEX.TabIndex = 7;
            // 
            // rdbInteres1
            // 
            this.rdbInteres1.AutoSize = true;
            this.rdbInteres1.Checked = true;
            this.rdbInteres1.Location = new System.Drawing.Point(39, 182);
            this.rdbInteres1.Name = "rdbInteres1";
            this.rdbInteres1.Size = new System.Drawing.Size(48, 17);
            this.rdbInteres1.TabIndex = 8;
            this.rdbInteres1.TabStop = true;
            this.rdbInteres1.Text = "12 %";
            this.rdbInteres1.UseVisualStyleBackColor = true;
            this.rdbInteres1.CheckedChanged += new System.EventHandler(this.rdbInteres1_CheckedChanged);
            // 
            // rdbInteres2
            // 
            this.rdbInteres2.AutoSize = true;
            this.rdbInteres2.Location = new System.Drawing.Point(123, 182);
            this.rdbInteres2.Name = "rdbInteres2";
            this.rdbInteres2.Size = new System.Drawing.Size(57, 17);
            this.rdbInteres2.TabIndex = 9;
            this.rdbInteres2.Text = "23.5 %";
            this.rdbInteres2.UseVisualStyleBackColor = true;
            this.rdbInteres2.CheckedChanged += new System.EventHandler(this.rdbInteres2_CheckedChanged);
            // 
            // rdbInteres3
            // 
            this.rdbInteres3.AutoSize = true;
            this.rdbInteres3.Location = new System.Drawing.Point(212, 182);
            this.rdbInteres3.Name = "rdbInteres3";
            this.rdbInteres3.Size = new System.Drawing.Size(88, 17);
            this.rdbInteres3.TabIndex = 10;
            this.rdbInteres3.Text = "Otro, indique:";
            this.rdbInteres3.UseVisualStyleBackColor = true;
            this.rdbInteres3.CheckedChanged += new System.EventHandler(this.rdbInteres3_CheckedChanged);
            // 
            // lstResul
            // 
            this.lstResul.Enabled = false;
            this.lstResul.FormattingEnabled = true;
            this.lstResul.Location = new System.Drawing.Point(39, 228);
            this.lstResul.Name = "lstResul";
            this.lstResul.Size = new System.Drawing.Size(411, 121);
            this.lstResul.TabIndex = 11;
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Location = new System.Drawing.Point(77, 393);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(108, 23);
            this.btnAnalisis.TabIndex = 12;
            this.btnAnalisis.Text = "Análisis Financiero";
            this.btnAnalisis.UseVisualStyleBackColor = true;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(279, 393);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(99, 23);
            this.btnFin.TabIndex = 13;
            this.btnFin.Text = "Salir del programa";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Volver a ejemplo 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Ir al ejemplo 3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 488);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnAnalisis);
            this.Controls.Add(this.lstResul);
            this.Controls.Add(this.rdbInteres3);
            this.Controls.Add(this.rdbInteres2);
            this.Controls.Add(this.rdbInteres1);
            this.Controls.Add(this.txtTasaInterEX);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.lblTasaInter);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblEmpresa);
            this.Name = "Form2";
            this.Text = "Calculo del Monto a pagar por un Prestamo";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblTasaInter;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox txtTasaInterEX;
        private System.Windows.Forms.RadioButton rdbInteres1;
        private System.Windows.Forms.RadioButton rdbInteres2;
        private System.Windows.Forms.RadioButton rdbInteres3;
        private System.Windows.Forms.ListBox lstResul;
        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}