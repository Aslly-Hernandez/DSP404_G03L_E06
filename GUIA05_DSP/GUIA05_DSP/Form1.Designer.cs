namespace GUIA05_DSP
{
    partial class frmRegistoEmpleados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lblnombres = new System.Windows.Forms.Label();
            this.Lblapellidos = new System.Windows.Forms.Label();
            this.lblfechanac = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAbrirPlanilla = new System.Windows.Forms.Button();
            this.btnGenerarPlanilla = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblRenta = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblContrato = new System.Windows.Forms.Label();
            this.txtSueldoini = new System.Windows.Forms.TextBox();
            this.dtpFechaContrato = new System.Windows.Forms.DateTimePicker();
            this.nudRenta = new System.Windows.Forms.NumericUpDown();
            this.lblISSS = new System.Windows.Forms.Label();
            this.nudISSS = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudISSS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaNac);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.lblfechanac);
            this.groupBox1.Controls.Add(this.Lblapellidos);
            this.groupBox1.Controls.Add(this.Lblnombres);
            this.groupBox1.Location = new System.Drawing.Point(50, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales de empleados";
            // 
            // Lblnombres
            // 
            this.Lblnombres.AutoSize = true;
            this.Lblnombres.Location = new System.Drawing.Point(19, 30);
            this.Lblnombres.Name = "Lblnombres";
            this.Lblnombres.Size = new System.Drawing.Size(52, 13);
            this.Lblnombres.TabIndex = 0;
            this.Lblnombres.Text = "Nombres:";
            // 
            // Lblapellidos
            // 
            this.Lblapellidos.AutoSize = true;
            this.Lblapellidos.Location = new System.Drawing.Point(19, 70);
            this.Lblapellidos.Name = "Lblapellidos";
            this.Lblapellidos.Size = new System.Drawing.Size(52, 13);
            this.Lblapellidos.TabIndex = 1;
            this.Lblapellidos.Text = "Apellidos:";
            // 
            // lblfechanac
            // 
            this.lblfechanac.AutoSize = true;
            this.lblfechanac.Location = new System.Drawing.Point(19, 109);
            this.lblfechanac.Name = "lblfechanac";
            this.lblfechanac.Size = new System.Drawing.Size(94, 13);
            this.lblfechanac.TabIndex = 2;
            this.lblfechanac.Text = "Fecha nacimiento:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(75, 27);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(195, 20);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(75, 66);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(195, 20);
            this.txtApellidos.TabIndex = 4;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(116, 106);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(195, 20);
            this.dtpFechaNac.TabIndex = 5;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(50, 196);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(157, 40);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo empleado";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(230, 196);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(157, 40);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Proximo empleado";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAbrirPlanilla
            // 
            this.btnAbrirPlanilla.Location = new System.Drawing.Point(430, 196);
            this.btnAbrirPlanilla.Name = "btnAbrirPlanilla";
            this.btnAbrirPlanilla.Size = new System.Drawing.Size(157, 40);
            this.btnAbrirPlanilla.TabIndex = 9;
            this.btnAbrirPlanilla.Text = "Abrir Planilla";
            this.btnAbrirPlanilla.UseVisualStyleBackColor = true;
            this.btnAbrirPlanilla.Click += new System.EventHandler(this.btnAbrirPlanilla_Click);
            // 
            // btnGenerarPlanilla
            // 
            this.btnGenerarPlanilla.Location = new System.Drawing.Point(607, 196);
            this.btnGenerarPlanilla.Name = "btnGenerarPlanilla";
            this.btnGenerarPlanilla.Size = new System.Drawing.Size(157, 40);
            this.btnGenerarPlanilla.TabIndex = 10;
            this.btnGenerarPlanilla.Text = "Generar Planilla";
            this.btnGenerarPlanilla.UseVisualStyleBackColor = true;
            this.btnGenerarPlanilla.Click += new System.EventHandler(this.btnGenerarPlanilla_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 169);
            this.dataGridView1.TabIndex = 11;
            // 
            // lblRenta
            // 
            this.lblRenta.AutoSize = true;
            this.lblRenta.Location = new System.Drawing.Point(19, 111);
            this.lblRenta.Name = "lblRenta";
            this.lblRenta.Size = new System.Drawing.Size(66, 13);
            this.lblRenta.TabIndex = 0;
            this.lblRenta.Text = "Tasa Renta:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(19, 71);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(69, 13);
            this.lblSueldo.TabIndex = 1;
            this.lblSueldo.Text = "Sueldo base:";
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Location = new System.Drawing.Point(19, 31);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(82, 13);
            this.lblContrato.TabIndex = 2;
            this.lblContrato.Text = "Fecha contrato:";
            // 
            // txtSueldoini
            // 
            this.txtSueldoini.Location = new System.Drawing.Point(107, 68);
            this.txtSueldoini.Name = "txtSueldoini";
            this.txtSueldoini.Size = new System.Drawing.Size(195, 20);
            this.txtSueldoini.TabIndex = 4;
            this.txtSueldoini.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoini_KeyPress);
            // 
            // dtpFechaContrato
            // 
            this.dtpFechaContrato.Location = new System.Drawing.Point(107, 31);
            this.dtpFechaContrato.Name = "dtpFechaContrato";
            this.dtpFechaContrato.Size = new System.Drawing.Size(195, 20);
            this.dtpFechaContrato.TabIndex = 5;
            // 
            // nudRenta
            // 
            this.nudRenta.DecimalPlaces = 1;
            this.nudRenta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRenta.Location = new System.Drawing.Point(88, 109);
            this.nudRenta.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudRenta.Name = "nudRenta";
            this.nudRenta.Size = new System.Drawing.Size(78, 20);
            this.nudRenta.TabIndex = 6;
            this.nudRenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudRenta_KeyPress);
            // 
            // lblISSS
            // 
            this.lblISSS.AutoSize = true;
            this.lblISSS.Location = new System.Drawing.Point(169, 112);
            this.lblISSS.Name = "lblISSS";
            this.lblISSS.Size = new System.Drawing.Size(58, 13);
            this.lblISSS.TabIndex = 7;
            this.lblISSS.Text = "Tasa ISSS";
            // 
            // nudISSS
            // 
            this.nudISSS.DecimalPlaces = 1;
            this.nudISSS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudISSS.Location = new System.Drawing.Point(234, 110);
            this.nudISSS.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudISSS.Name = "nudISSS";
            this.nudISSS.Size = new System.Drawing.Size(78, 20);
            this.nudISSS.TabIndex = 8;
            this.nudISSS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudISSS_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudISSS);
            this.groupBox2.Controls.Add(this.lblISSS);
            this.groupBox2.Controls.Add(this.nudRenta);
            this.groupBox2.Controls.Add(this.dtpFechaContrato);
            this.groupBox2.Controls.Add(this.txtSueldoini);
            this.groupBox2.Controls.Add(this.lblContrato);
            this.groupBox2.Controls.Add(this.lblSueldo);
            this.groupBox2.Controls.Add(this.lblRenta);
            this.groupBox2.Location = new System.Drawing.Point(430, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 151);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos laborales:";
            // 
            // frmRegistoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGenerarPlanilla);
            this.Controls.Add(this.btnAbrirPlanilla);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistoEmpleados";
            this.Text = "Registro inicial de empleados";
            this.Load += new System.EventHandler(this.frmRegistoEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudISSS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblfechanac;
        private System.Windows.Forms.Label Lblapellidos;
        private System.Windows.Forms.Label Lblnombres;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAbrirPlanilla;
        private System.Windows.Forms.Button btnGenerarPlanilla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblRenta;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.TextBox txtSueldoini;
        private System.Windows.Forms.DateTimePicker dtpFechaContrato;
        private System.Windows.Forms.NumericUpDown nudRenta;
        private System.Windows.Forms.Label lblISSS;
        private System.Windows.Forms.NumericUpDown nudISSS;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

