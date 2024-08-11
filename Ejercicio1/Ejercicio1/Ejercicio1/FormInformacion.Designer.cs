namespace Ejercicio1
{
    partial class FormInformacion
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
            label1 = new Label();
            tabControl1 = new TabControl();
            pestaña1 = new TabPage();
            pestaña2 = new TabPage();
            pestaña3 = new TabPage();
            pestaña4 = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(319, 21);
            label1.Name = "label1";
            label1.Size = new Size(162, 36);
            label1.TabIndex = 0;
            label1.Text = "Estadisticas";
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(pestaña1);
            tabControl1.Controls.Add(pestaña2);
            tabControl1.Controls.Add(pestaña3);
            tabControl1.Controls.Add(pestaña4);
            tabControl1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(24, 78);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(752, 401);
            tabControl1.TabIndex = 1;
            // 
            // pestaña1
            // 
            pestaña1.BackColor = Color.FromArgb(192, 255, 255);
            pestaña1.BorderStyle = BorderStyle.Fixed3D;
            pestaña1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pestaña1.Location = new Point(4, 31);
            pestaña1.Name = "pestaña1";
            pestaña1.Padding = new Padding(3);
            pestaña1.Size = new Size(744, 366);
            pestaña1.TabIndex = 0;
            pestaña1.Text = "Programas de entretenimiento";
            // 
            // pestaña2
            // 
            pestaña2.BackColor = Color.FromArgb(192, 255, 192);
            pestaña2.Location = new Point(4, 31);
            pestaña2.Name = "pestaña2";
            pestaña2.Padding = new Padding(3);
            pestaña2.Size = new Size(744, 311);
            pestaña2.TabIndex = 1;
            pestaña2.Text = "Libros";
            // 
            // pestaña3
            // 
            pestaña3.BackColor = Color.FromArgb(255, 255, 192);
            pestaña3.Location = new Point(4, 31);
            pestaña3.Name = "pestaña3";
            pestaña3.Size = new Size(744, 311);
            pestaña3.TabIndex = 2;
            pestaña3.Text = "Lenguajes de programación";
            // 
            // pestaña4
            // 
            pestaña4.BackColor = Color.FromArgb(255, 224, 192);
            pestaña4.Location = new Point(4, 31);
            pestaña4.Name = "pestaña4";
            pestaña4.Size = new Size(744, 311);
            pestaña4.TabIndex = 3;
            pestaña4.Text = "Datos en gráfica";
            // 
            // FormInformacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 513);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FormInformacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInformacion";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage pestaña1;
        private TabPage pestaña2;
        private TabPage pestaña3;
        private TabPage pestaña4;
    }
}