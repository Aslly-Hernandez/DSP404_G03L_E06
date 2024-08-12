namespace Practica04deDSP
{
    partial class Ejercicio4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio4));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            txtpwd = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(169, 14);
            pictureBox1.Margin = new Padding(3, 5, 3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtpwd);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(67, 181);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 5, 3, 5);
            groupBox1.Size = new Size(312, 215);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Private";
            // 
            // txtpwd
            // 
            txtpwd.Location = new Point(99, 142);
            txtpwd.Margin = new Padding(3, 5, 3, 5);
            txtpwd.Name = "txtpwd";
            txtpwd.Size = new Size(181, 45);
            txtpwd.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(99, 58);
            txtUsuario.Margin = new Padding(3, 5, 3, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(181, 45);
            txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label2.Location = new Point(24, 145);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label1.Location = new Point(24, 61);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Teal;
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.ForeColor = SystemColors.ButtonFace;
            btnAceptar.Location = new Point(176, 417);
            btnAceptar.Margin = new Padding(3, 5, 3, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(106, 39);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // Ejercicio4
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 473);
            Controls.Add(btnAceptar);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            Margin = new Padding(3, 5, 3, 5);
            Name = "Ejercicio4";
            Text = "Login";
            Load += Ejercicio4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtpwd;
        private TextBox txtUsuario;
        private Button btnAceptar;
    }
}