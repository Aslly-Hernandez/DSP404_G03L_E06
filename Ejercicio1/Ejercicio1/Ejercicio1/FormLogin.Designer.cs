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
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 172);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 237);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(143, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(131, 170);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(186, 23);
            txtUsuario.TabIndex = 4;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(131, 237);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(186, 23);
            txtContra.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(131, 314);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 35);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(242, 314);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 35);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button2_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 374);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(txtContra);
            Controls.Add(txtUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLogin";
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