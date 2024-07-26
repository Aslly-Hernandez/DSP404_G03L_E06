namespace Práctica3DSP
{
    partial class Form3
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
            lstPalabras = new ListBox();
            lblpalabra = new Label();
            txtsignificado = new TextBox();
            btnsalir = new Button();
            SuspendLayout();
            // 
            // lstPalabras
            // 
            lstPalabras.FormattingEnabled = true;
            lstPalabras.ItemHeight = 15;
            lstPalabras.Location = new Point(36, 33);
            lstPalabras.Name = "lstPalabras";
            lstPalabras.Size = new Size(120, 184);
            lstPalabras.TabIndex = 0;
            lstPalabras.SelectedIndexChanged += lstPalabras_SelectedIndexChanged;
            // 
            // lblpalabra
            // 
            lblpalabra.AutoSize = true;
            lblpalabra.Location = new Point(190, 33);
            lblpalabra.Name = "lblpalabra";
            lblpalabra.Size = new Size(46, 15);
            lblpalabra.TabIndex = 1;
            lblpalabra.Text = "Palabra";
            lblpalabra.Click += label1_Click;
            // 
            // txtsignificado
            // 
            txtsignificado.Enabled = false;
            txtsignificado.Location = new Point(190, 121);
            txtsignificado.Multiline = true;
            txtsignificado.Name = "txtsignificado";
            txtsignificado.Size = new Size(164, 96);
            txtsignificado.TabIndex = 2;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(84, 268);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(199, 23);
            btnsalir.TabIndex = 3;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(387, 327);
            Controls.Add(btnsalir);
            Controls.Add(txtsignificado);
            Controls.Add(lblpalabra);
            Controls.Add(lstPalabras);
            Name = "Form3";
            Text = "Formulario";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstPalabras;
        private Label lblpalabra;
        private TextBox txtsignificado;
        private Button btnsalir;
    }
}