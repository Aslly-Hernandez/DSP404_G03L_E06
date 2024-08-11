using System;

namespace Ejercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.txtOpcionMenu = new System.Windows.Forms.TextBox();
            this.btnConfirmarMenu = new System.Windows.Forms.Button();
            this.btnConfirmarCuenta = new System.Windows.Forms.Button();
            this.btnConfirmarCantidad = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMensaje2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el Numero de Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMensaje.Location = new System.Drawing.Point(339, 140);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(40, 16);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = "Menu";
            this.lblMensaje.Click += new System.EventHandler(this.lblMensajes_Click);
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new System.Drawing.Point(62, 173);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(178, 22);
            this.txtNumeroCuenta.TabIndex = 3;
            // 
            // txtOpcionMenu
            // 
            this.txtOpcionMenu.Location = new System.Drawing.Point(640, 173);
            this.txtOpcionMenu.Multiline = true;
            this.txtOpcionMenu.Name = "txtOpcionMenu";
            this.txtOpcionMenu.Size = new System.Drawing.Size(49, 26);
            this.txtOpcionMenu.TabIndex = 4;
            // 
            // btnConfirmarMenu
            // 
            this.btnConfirmarMenu.Location = new System.Drawing.Point(624, 209);
            this.btnConfirmarMenu.Name = "btnConfirmarMenu";
            this.btnConfirmarMenu.Size = new System.Drawing.Size(84, 25);
            this.btnConfirmarMenu.TabIndex = 5;
            this.btnConfirmarMenu.Text = "Confirmar Menu";
            this.btnConfirmarMenu.UseVisualStyleBackColor = true;
            this.btnConfirmarMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConfirmarCuenta
            // 
            this.btnConfirmarCuenta.Location = new System.Drawing.Point(62, 224);
            this.btnConfirmarCuenta.Name = "btnConfirmarCuenta";
            this.btnConfirmarCuenta.Size = new System.Drawing.Size(134, 27);
            this.btnConfirmarCuenta.TabIndex = 6;
            this.btnConfirmarCuenta.Text = "Confirmar Cuenta";
            this.btnConfirmarCuenta.UseVisualStyleBackColor = true;
            this.btnConfirmarCuenta.Click += new System.EventHandler(this.btnConfirmarCuenta_Click);
            // 
            // btnConfirmarCantidad
            // 
            this.btnConfirmarCantidad.Location = new System.Drawing.Point(315, 402);
            this.btnConfirmarCantidad.Name = "btnConfirmarCantidad";
            this.btnConfirmarCantidad.Size = new System.Drawing.Size(165, 29);
            this.btnConfirmarCantidad.TabIndex = 7;
            this.btnConfirmarCantidad.Text = "Confirmar Cantidad";
            this.btnConfirmarCantidad.UseVisualStyleBackColor = true;
            this.btnConfirmarCantidad.Click += new System.EventHandler(this.btnConfirmarCantidad_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(338, 358);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(749, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ingrese Opcion ";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // lblMensaje2
            // 
            this.lblMensaje2.AutoSize = true;
            this.lblMensaje2.Location = new System.Drawing.Point(335, 183);
            this.lblMensaje2.Name = "lblMensaje2";
            this.lblMensaje2.Size = new System.Drawing.Size(44, 16);
            this.lblMensaje2.TabIndex = 11;
            this.lblMensaje2.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(803, 453);
            this.Controls.Add(this.lblMensaje2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnConfirmarCantidad);
            this.Controls.Add(this.btnConfirmarCuenta);
            this.Controls.Add(this.btnConfirmarMenu);
            this.Controls.Add(this.txtOpcionMenu);
            this.Controls.Add(this.txtNumeroCuenta);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cajero Electronico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblMensajes_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.TextBox txtOpcionMenu;
        private System.Windows.Forms.Button btnConfirmarMenu;
        private System.Windows.Forms.Button btnConfirmarCuenta;
        private System.Windows.Forms.Button btnConfirmarCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMensaje2;
    }
}

