namespace Ejercicio_3
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
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.btnEditarTarea = new System.Windows.Forms.Button();
            this.btnMarcarCompletada = new System.Windows.Forms.Button();
            this.lvTareasPendientes = new System.Windows.Forms.ListView();
            this.txtNombreTarea = new System.Windows.Forms.TextBox();
            this.dtpFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.lvTareasCompletadas = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregarTarea.Location = new System.Drawing.Point(183, 119);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(89, 23);
            this.btnAgregarTarea.TabIndex = 1;
            this.btnAgregarTarea.Text = "AgregarTarea";
            this.btnAgregarTarea.UseVisualStyleBackColor = false;
            this.btnAgregarTarea.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.BackColor = System.Drawing.Color.Fuchsia;
            this.btnEliminarTarea.Location = new System.Drawing.Point(183, 154);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(90, 23);
            this.btnEliminarTarea.TabIndex = 2;
            this.btnEliminarTarea.Text = "EliminarTarea";
            this.btnEliminarTarea.UseVisualStyleBackColor = false;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // btnEditarTarea
            // 
            this.btnEditarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEditarTarea.Location = new System.Drawing.Point(183, 193);
            this.btnEditarTarea.Name = "btnEditarTarea";
            this.btnEditarTarea.Size = new System.Drawing.Size(90, 23);
            this.btnEditarTarea.TabIndex = 3;
            this.btnEditarTarea.Text = "EditarTarea";
            this.btnEditarTarea.UseVisualStyleBackColor = false;
            this.btnEditarTarea.Click += new System.EventHandler(this.btnEditarTarea_Click);
            // 
            // btnMarcarCompletada
            // 
            this.btnMarcarCompletada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMarcarCompletada.Location = new System.Drawing.Point(304, 239);
            this.btnMarcarCompletada.Name = "btnMarcarCompletada";
            this.btnMarcarCompletada.Size = new System.Drawing.Size(121, 23);
            this.btnMarcarCompletada.TabIndex = 4;
            this.btnMarcarCompletada.Text = "MarcarCompletada";
            this.btnMarcarCompletada.UseVisualStyleBackColor = false;
            this.btnMarcarCompletada.Click += new System.EventHandler(this.btnMarcarCompletada_Click);
            // 
            // lvTareasPendientes
            // 
            this.lvTareasPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvTareasPendientes.HideSelection = false;
            this.lvTareasPendientes.Location = new System.Drawing.Point(26, 119);
            this.lvTareasPendientes.Name = "lvTareasPendientes";
            this.lvTareasPendientes.Size = new System.Drawing.Size(121, 97);
            this.lvTareasPendientes.TabIndex = 5;
            this.lvTareasPendientes.UseCompatibleStateImageBehavior = false;
            // 
            // txtNombreTarea
            // 
            this.txtNombreTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtNombreTarea.Location = new System.Drawing.Point(26, 43);
            this.txtNombreTarea.Name = "txtNombreTarea";
            this.txtNombreTarea.Size = new System.Drawing.Size(100, 20);
            this.txtNombreTarea.TabIndex = 6;
            // 
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpFechaLimite.Location = new System.Drawing.Point(26, 78);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaLimite.TabIndex = 7;
            // 
            // lvTareasCompletadas
            // 
            this.lvTareasCompletadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvTareasCompletadas.HideSelection = false;
            this.lvTareasCompletadas.Location = new System.Drawing.Point(304, 119);
            this.lvTareasCompletadas.Name = "lvTareasCompletadas";
            this.lvTareasCompletadas.Size = new System.Drawing.Size(121, 97);
            this.lvTareasCompletadas.TabIndex = 8;
            this.lvTareasCompletadas.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(466, 323);
            this.Controls.Add(this.lvTareasCompletadas);
            this.Controls.Add(this.dtpFechaLimite);
            this.Controls.Add(this.txtNombreTarea);
            this.Controls.Add(this.lvTareasPendientes);
            this.Controls.Add(this.btnMarcarCompletada);
            this.Controls.Add(this.btnEditarTarea);
            this.Controls.Add(this.btnEliminarTarea);
            this.Controls.Add(this.btnAgregarTarea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.Button btnEditarTarea;
        private System.Windows.Forms.Button btnMarcarCompletada;
        private System.Windows.Forms.ListView lvTareasPendientes;
        private System.Windows.Forms.TextBox txtNombreTarea;
        private System.Windows.Forms.DateTimePicker dtpFechaLimite;
        private System.Windows.Forms.ListView lvTareasCompletadas;
    }
}

