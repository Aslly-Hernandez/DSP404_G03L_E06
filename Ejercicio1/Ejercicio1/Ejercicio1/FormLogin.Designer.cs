namespace Ejercicio1
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtUsuario = new TextBox();
            txtContra = new TextBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(38, 212);
            label1.Name = "label1";
            label1.Size = new Size(66, 19);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(38, 272);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(128, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(135, 212);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(207, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(135, 272);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(207, 23);
            txtContra.TabIndex = 4;
            txtContra.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(128, 255, 128);
            btnIngresar.FlatStyle = FlatStyle.Popup;
            btnIngresar.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnIngresar.ForeColor = SystemColors.ControlText;
            btnIngresar.Location = new Point(92, 340);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(91, 35);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ControlText;
            btnCancelar.Location = new Point(231, 340);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 35);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(409, 400);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(txtContra);
            Controls.Add(txtUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += FormLogin_FormClosing;
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtUsuario;
        private TextBox txtContra;
        private Button btnIngresar;
        private Button btnCancelar;
    }
}