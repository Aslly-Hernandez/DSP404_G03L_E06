namespace conplementario1
{
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.TextBox textBox7;
    private System.Windows.Forms.TextBox textBox8;
    private System.Windows.Forms.TextBox textBox9;
    private System.Windows.Forms.TextBox textBox10;
    private System.Windows.Forms.Button buttonOptionA;
    private System.Windows.Forms.Button buttonOptionB;
    private System.Windows.Forms.Label labelResultado;

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
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.btnopcionA = new System.Windows.Forms.Button();
            this.butnopcionB = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.textNum7 = new System.Windows.Forms.TextBox();
            this.textNum6 = new System.Windows.Forms.TextBox();
            this.textNum5 = new System.Windows.Forms.TextBox();
            this.textNum4 = new System.Windows.Forms.TextBox();
            this.textNum3 = new System.Windows.Forms.TextBox();
            this.textNum10 = new System.Windows.Forms.TextBox();
            this.textNum9 = new System.Windows.Forms.TextBox();
            this.textNum8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(44, 12);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(100, 20);
            this.textNum1.TabIndex = 0;
            this.textNum1.TextChanged += new System.EventHandler(this.text10Numeros_TextChanged);
            // 
            // btnopcionA
            // 
            this.btnopcionA.Location = new System.Drawing.Point(295, 21);
            this.btnopcionA.Name = "btnopcionA";
            this.btnopcionA.Size = new System.Drawing.Size(75, 23);
            this.btnopcionA.TabIndex = 1;
            this.btnopcionA.Text = "Opcion A";
            this.btnopcionA.UseVisualStyleBackColor = true;
            this.btnopcionA.Click += new System.EventHandler(this.btnopcionA_Click);
            // 
            // butnopcionB
            // 
            this.butnopcionB.Location = new System.Drawing.Point(295, 82);
            this.butnopcionB.Name = "butnopcionB";
            this.butnopcionB.Size = new System.Drawing.Size(75, 23);
            this.butnopcionB.TabIndex = 2;
            this.butnopcionB.Text = "Opcion B";
            this.butnopcionB.UseVisualStyleBackColor = true;
            this.butnopcionB.Click += new System.EventHandler(this.butnopcionB_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(315, 181);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 3;
            this.lblresultado.Text = "Resultado";
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(44, 38);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(100, 20);
            this.textNum2.TabIndex = 4;
            // 
            // textNum7
            // 
            this.textNum7.Location = new System.Drawing.Point(44, 181);
            this.textNum7.Name = "textNum7";
            this.textNum7.Size = new System.Drawing.Size(100, 20);
            this.textNum7.TabIndex = 5;
            // 
            // textNum6
            // 
            this.textNum6.Location = new System.Drawing.Point(44, 146);
            this.textNum6.Name = "textNum6";
            this.textNum6.Size = new System.Drawing.Size(100, 20);
            this.textNum6.TabIndex = 6;
            // 
            // textNum5
            // 
            this.textNum5.Location = new System.Drawing.Point(44, 120);
            this.textNum5.Name = "textNum5";
            this.textNum5.Size = new System.Drawing.Size(100, 20);
            this.textNum5.TabIndex = 7;
            // 
            // textNum4
            // 
            this.textNum4.Location = new System.Drawing.Point(44, 90);
            this.textNum4.Name = "textNum4";
            this.textNum4.Size = new System.Drawing.Size(100, 20);
            this.textNum4.TabIndex = 8;
            // 
            // textNum3
            // 
            this.textNum3.Location = new System.Drawing.Point(44, 64);
            this.textNum3.Name = "textNum3";
            this.textNum3.Size = new System.Drawing.Size(100, 20);
            this.textNum3.TabIndex = 9;
            // 
            // textNum10
            // 
            this.textNum10.Location = new System.Drawing.Point(44, 281);
            this.textNum10.Name = "textNum10";
            this.textNum10.Size = new System.Drawing.Size(100, 20);
            this.textNum10.TabIndex = 10;
            // 
            // textNum9
            // 
            this.textNum9.Location = new System.Drawing.Point(44, 243);
            this.textNum9.Name = "textNum9";
            this.textNum9.Size = new System.Drawing.Size(100, 20);
            this.textNum9.TabIndex = 11;
            // 
            // textNum8
            // 
            this.textNum8.Location = new System.Drawing.Point(44, 207);
            this.textNum8.Name = "textNum8";
            this.textNum8.Size = new System.Drawing.Size(100, 20);
            this.textNum8.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 329);
            this.Controls.Add(this.textNum8);
            this.Controls.Add(this.textNum9);
            this.Controls.Add(this.textNum10);
            this.Controls.Add(this.textNum3);
            this.Controls.Add(this.textNum4);
            this.Controls.Add(this.textNum5);
            this.Controls.Add(this.textNum6);
            this.Controls.Add(this.textNum7);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.butnopcionB);
            this.Controls.Add(this.btnopcionA);
            this.Controls.Add(this.textNum1);
            this.Name = "Form1";
            this.Text = "Numeros Decimales ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.Button btnopcionA;
        private System.Windows.Forms.Button butnopcionB;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.TextBox textNum7;
        private System.Windows.Forms.TextBox textNum6;
        private System.Windows.Forms.TextBox textNum5;
        private System.Windows.Forms.TextBox textNum4;
        private System.Windows.Forms.TextBox textNum3;
        private System.Windows.Forms.TextBox textNum10;
        private System.Windows.Forms.TextBox textNum9;
        private System.Windows.Forms.TextBox textNum8;
    }
}

