namespace Dsicusion2
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
            this.btn1Generar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1Transposed = new System.Windows.Forms.DataGridView();
            this.dataGridView2Original = new System.Windows.Forms.DataGridView();
            this.textBox1Dimension = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Transposed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2Original)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1Generar
            // 
            this.btn1Generar.Location = new System.Drawing.Point(53, 168);
            this.btn1Generar.Name = "btn1Generar";
            this.btn1Generar.Size = new System.Drawing.Size(75, 24);
            this.btn1Generar.TabIndex = 0;
            this.btn1Generar.Text = "GENERAR";
            this.btn1Generar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dimension:";
            // 
            // dataGridView1Transposed
            // 
            this.dataGridView1Transposed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Transposed.Location = new System.Drawing.Point(271, 215);
            this.dataGridView1Transposed.Name = "dataGridView1Transposed";
            this.dataGridView1Transposed.RowHeadersWidth = 51;
            this.dataGridView1Transposed.RowTemplate.Height = 24;
            this.dataGridView1Transposed.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1Transposed.TabIndex = 2;
            // 
            // dataGridView2Original
            // 
            this.dataGridView2Original.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2Original.Location = new System.Drawing.Point(271, 42);
            this.dataGridView2Original.Name = "dataGridView2Original";
            this.dataGridView2Original.RowHeadersWidth = 51;
            this.dataGridView2Original.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2Original.TabIndex = 3;
            // 
            // textBox1Dimension
            // 
            this.textBox1Dimension.Location = new System.Drawing.Point(53, 113);
            this.textBox1Dimension.Name = "textBox1Dimension";
            this.textBox1Dimension.Size = new System.Drawing.Size(100, 22);
            this.textBox1Dimension.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(586, 376);
            this.Controls.Add(this.textBox1Dimension);
            this.Controls.Add(this.dataGridView2Original);
            this.Controls.Add(this.dataGridView1Transposed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1Generar);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Transposed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2Original)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtDimension;
        private System.Windows.Forms.DataGridView dataGridViewOriginal;
        private System.Windows.Forms.DataGridView dataGridViewTransposed;
        private System.Windows.Forms.Button btn1Generar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1Transposed;
        private System.Windows.Forms.DataGridView dataGridView2Original;
        private System.Windows.Forms.TextBox textBox1Dimension;
    }
}

