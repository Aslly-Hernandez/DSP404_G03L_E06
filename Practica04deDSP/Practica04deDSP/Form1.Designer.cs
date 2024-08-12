namespace Practica04deDSP
{
    partial class Ejercicio1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbltema = new Label();
            nupBase = new NumericUpDown();
            btnCalculo = new Button();
            btnSalir = new Button();
            grbResult = new GroupBox();
            lstTabla2 = new ListBox();
            lstTabla1 = new ListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nupBase).BeginInit();
            grbResult.SuspendLayout();
            SuspendLayout();
            // 
            // lbltema
            // 
            lbltema.AutoSize = true;
            lbltema.Location = new Point(42, 30);
            lbltema.Name = "lbltema";
            lbltema.Size = new Size(93, 15);
            lbltema.TabIndex = 0;
            lbltema.Text = "Ingrese número:";
            // 
            // nupBase
            // 
            nupBase.DecimalPlaces = 1;
            nupBase.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nupBase.Location = new Point(40, 57);
            nupBase.Maximum = new decimal(new int[] { 69, 0, 0, 65536 });
            nupBase.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nupBase.Name = "nupBase";
            nupBase.Size = new Size(95, 23);
            nupBase.TabIndex = 1;
            nupBase.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // btnCalculo
            // 
            btnCalculo.Location = new Point(42, 116);
            btnCalculo.Name = "btnCalculo";
            btnCalculo.Size = new Size(93, 41);
            btnCalculo.TabIndex = 2;
            btnCalculo.Text = "Ver tablas";
            btnCalculo.UseVisualStyleBackColor = true;
            btnCalculo.Click += btnCalculo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(42, 182);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(93, 39);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Finalizar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button2_Click;
            // 
            // grbResult
            // 
            grbResult.Controls.Add(lstTabla2);
            grbResult.Controls.Add(lstTabla1);
            grbResult.Location = new Point(194, 30);
            grbResult.Name = "grbResult";
            grbResult.Size = new Size(336, 314);
            grbResult.TabIndex = 4;
            grbResult.TabStop = false;
            grbResult.Text = "Resultados";
            // 
            // lstTabla2
            // 
            lstTabla2.FormattingEnabled = true;
            lstTabla2.ItemHeight = 15;
            lstTabla2.Location = new Point(180, 37);
            lstTabla2.Name = "lstTabla2";
            lstTabla2.Size = new Size(120, 244);
            lstTabla2.TabIndex = 1;
            // 
            // lstTabla1
            // 
            lstTabla1.FormattingEnabled = true;
            lstTabla1.ItemHeight = 15;
            lstTabla1.Location = new Point(23, 37);
            lstTabla1.Name = "lstTabla1";
            lstTabla1.Size = new Size(120, 244);
            lstTabla1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 365);
            button1.Name = "button1";
            button1.Size = new Size(102, 23);
            button1.TabIndex = 5;
            button1.Text = "Ir al ejemplo2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Ejercicio1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 401);
            Controls.Add(button1);
            Controls.Add(grbResult);
            Controls.Add(btnSalir);
            Controls.Add(btnCalculo);
            Controls.Add(nupBase);
            Controls.Add(lbltema);
            Name = "Ejercicio1";
            Text = "Ejercicio1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nupBase).EndInit();
            grbResult.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltema;
        private NumericUpDown nupBase;
        private Button btnCalculo;
        private Button btnSalir;
        private GroupBox grbResult;
        private ListBox lstTabla2;
        private ListBox lstTabla1;
        private Button button1;
    }
}
