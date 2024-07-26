namespace Práctica3DSP
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
            gbInformacon = new GroupBox();
            txtEdad = new TextBox();
            txtInfo = new TextBox();
            cbtipoinfo = new ComboBox();
            lbedad = new Label();
            Lbdig_info = new Label();
            Lbtipo_info = new Label();
            gbMantenimiento = new GroupBox();
            button1 = new Button();
            button5 = new Button();
            btPromedio = new Button();
            btLimpiar = new Button();
            btMostrar = new Button();
            btAgregar = new Button();
            gbMatriz = new GroupBox();
            dgdatos = new DataGridView();
            gbInformacon.SuspendLayout();
            gbMantenimiento.SuspendLayout();
            gbMatriz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgdatos).BeginInit();
            SuspendLayout();
            // 
            // gbInformacon
            // 
            gbInformacon.Controls.Add(txtEdad);
            gbInformacon.Controls.Add(txtInfo);
            gbInformacon.Controls.Add(cbtipoinfo);
            gbInformacon.Controls.Add(lbedad);
            gbInformacon.Controls.Add(Lbdig_info);
            gbInformacon.Controls.Add(Lbtipo_info);
            gbInformacon.Location = new Point(49, 25);
            gbInformacon.Name = "gbInformacon";
            gbInformacon.Size = new Size(278, 127);
            gbInformacon.TabIndex = 0;
            gbInformacon.TabStop = false;
            gbInformacon.Text = "Informacion";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(138, 86);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 5;
            txtEdad.TextChanged += txtEdad_TextChanged;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(138, 52);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(121, 23);
            txtInfo.TabIndex = 4;
            txtInfo.KeyPress += txtInfo_KeyPress;
            // 
            // cbtipoinfo
            // 
            cbtipoinfo.FormattingEnabled = true;
            cbtipoinfo.Items.AddRange(new object[] { "Nombre", "Apellido" });
            cbtipoinfo.Location = new Point(138, 23);
            cbtipoinfo.Name = "cbtipoinfo";
            cbtipoinfo.Size = new Size(121, 23);
            cbtipoinfo.TabIndex = 3;
            // 
            // lbedad
            // 
            lbedad.AutoSize = true;
            lbedad.Location = new Point(18, 94);
            lbedad.Name = "lbedad";
            lbedad.Size = new Size(33, 15);
            lbedad.TabIndex = 2;
            lbedad.Text = "Edad";
            // 
            // Lbdig_info
            // 
            Lbdig_info.AutoSize = true;
            Lbdig_info.Location = new Point(18, 60);
            Lbdig_info.Name = "Lbdig_info";
            Lbdig_info.Size = new Size(118, 15);
            Lbdig_info.TabIndex = 1;
            Lbdig_info.Text = "Digite la información";
            // 
            // Lbtipo_info
            // 
            Lbtipo_info.AutoSize = true;
            Lbtipo_info.Location = new Point(18, 26);
            Lbtipo_info.Name = "Lbtipo_info";
            Lbtipo_info.Size = new Size(114, 15);
            Lbtipo_info.TabIndex = 0;
            Lbtipo_info.Text = "Tipo de información";
            // 
            // gbMantenimiento
            // 
            gbMantenimiento.Controls.Add(button5);
            gbMantenimiento.Controls.Add(btPromedio);
            gbMantenimiento.Controls.Add(btLimpiar);
            gbMantenimiento.Controls.Add(btMostrar);
            gbMantenimiento.Controls.Add(btAgregar);
            gbMantenimiento.Location = new Point(392, 25);
            gbMantenimiento.Name = "gbMantenimiento";
            gbMantenimiento.Size = new Size(254, 127);
            gbMantenimiento.TabIndex = 1;
            gbMantenimiento.TabStop = false;
            gbMantenimiento.Text = "Mantenimientos";
            // 
            // button1
            // 
            button1.Location = new Point(551, 381);
            button1.Name = "button1";
            button1.Size = new Size(112, 23);
            button1.TabIndex = 3;
            button1.Text = "Ir al ejemplo 3";
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(35, 91);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "Salir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btPromedio
            // 
            btPromedio.Location = new Point(137, 60);
            btPromedio.Name = "btPromedio";
            btPromedio.Size = new Size(75, 23);
            btPromedio.TabIndex = 3;
            btPromedio.Text = "Promedio";
            btPromedio.UseVisualStyleBackColor = true;
            // 
            // btLimpiar
            // 
            btLimpiar.Location = new Point(35, 60);
            btLimpiar.Name = "btLimpiar";
            btLimpiar.Size = new Size(91, 23);
            btLimpiar.TabIndex = 2;
            btLimpiar.Text = "Limpiar matriz";
            btLimpiar.UseVisualStyleBackColor = true;
            btLimpiar.Click += btLimpiar_Click;
            // 
            // btMostrar
            // 
            btMostrar.Location = new Point(137, 26);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(102, 23);
            btMostrar.TabIndex = 1;
            btMostrar.Text = "Mostrar matriz";
            btMostrar.UseVisualStyleBackColor = true;
            btMostrar.Click += btMostrar_Click;
            // 
            // btAgregar
            // 
            btAgregar.Location = new Point(35, 26);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(75, 23);
            btAgregar.TabIndex = 0;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = true;
            btAgregar.Click += btAgregar_Click;
            // 
            // gbMatriz
            // 
            gbMatriz.Controls.Add(dgdatos);
            gbMatriz.Location = new Point(49, 170);
            gbMatriz.Name = "gbMatriz";
            gbMatriz.Size = new Size(538, 180);
            gbMatriz.TabIndex = 1;
            gbMatriz.TabStop = false;
            gbMatriz.Text = "Matriz";
            // 
            // dgdatos
            // 
            dgdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdatos.Location = new Point(18, 22);
            dgdatos.Name = "dgdatos";
            dgdatos.Size = new Size(500, 143);
            dgdatos.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(700, 450);
            Controls.Add(button1);
            Controls.Add(gbMatriz);
            Controls.Add(gbMantenimiento);
            Controls.Add(gbInformacon);
            Name = "Form2";
            Text = "Formulario";
            Load += Form2_Load;
            gbInformacon.ResumeLayout(false);
            gbInformacon.PerformLayout();
            gbMantenimiento.ResumeLayout(false);
            gbMatriz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgdatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbInformacon;
        private GroupBox gbMantenimiento;
        private TextBox txtEdad;
        private TextBox txtInfo;
        private ComboBox cbtipoinfo;
        private Label lbedad;
        private Label Lbdig_info;
        private Label Lbtipo_info;
        private Button button5;
        private Button btPromedio;
        private Button btLimpiar;
        private Button btMostrar;
        private Button btAgregar;
        private GroupBox gbMatriz;
        private DataGridView dgdatos;
        private Button button1;
    }
}