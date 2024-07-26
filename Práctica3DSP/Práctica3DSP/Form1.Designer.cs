namespace Práctica3DSP
{
    partial class Form1
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
            lblnumero = new Label();
            txtNum = new TextBox();
            btAgregar = new Button();
            btOrdenar = new Button();
            lstdesorden = new ListBox();
            lstOrdenada = new ListBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Location = new Point(39, 32);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(97, 15);
            lblnumero.TabIndex = 0;
            lblnumero.Text = "Ingresar número:";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(142, 29);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 1;
            // 
            // btAgregar
            // 
            btAgregar.BackColor = Color.Lime;
            btAgregar.Location = new Point(269, 24);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(75, 23);
            btAgregar.TabIndex = 3;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = false;
            btAgregar.Click += btAgregar_Click;
            // 
            // btOrdenar
            // 
            btOrdenar.BackColor = Color.Yellow;
            btOrdenar.Location = new Point(269, 60);
            btOrdenar.Name = "btOrdenar";
            btOrdenar.Size = new Size(75, 23);
            btOrdenar.TabIndex = 4;
            btOrdenar.Text = "Ordenar";
            btOrdenar.UseVisualStyleBackColor = false;
            btOrdenar.Click += btOrdenar_Click;
            // 
            // lstdesorden
            // 
            lstdesorden.FormattingEnabled = true;
            lstdesorden.ItemHeight = 15;
            lstdesorden.Location = new Point(39, 120);
            lstdesorden.Name = "lstdesorden";
            lstdesorden.Size = new Size(138, 94);
            lstdesorden.TabIndex = 5;
            // 
            // lstOrdenada
            // 
            lstOrdenada.FormattingEnabled = true;
            lstOrdenada.ItemHeight = 15;
            lstOrdenada.Location = new Point(201, 120);
            lstOrdenada.Name = "lstOrdenada";
            lstOrdenada.Size = new Size(143, 94);
            lstOrdenada.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(269, 272);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 7;
            button1.Text = "Ir a ejemplo 2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(130, 272);
            button2.Name = "button2";
            button2.Size = new Size(112, 23);
            button2.TabIndex = 8;
            button2.Text = "Ir al ejemplo 3";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 307);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lstOrdenada);
            Controls.Add(lstdesorden);
            Controls.Add(btOrdenar);
            Controls.Add(btAgregar);
            Controls.Add(txtNum);
            Controls.Add(lblnumero);
            Name = "Form1";
            Text = "Ordenar";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnumero;
        private TextBox txtNum;
        private Button btAgregar;
        private Button btOrdenar;
        private ListBox lstdesorden;
        private ListBox lstOrdenada;
        private Button button1;
        private Button button2;
    }
}
