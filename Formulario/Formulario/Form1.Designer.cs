namespace Formulario
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.tbnum1 = new System.Windows.Forms.TextBox();
            this.tbnum2 = new System.Windows.Forms.TextBox();
            this.sumar = new System.Windows.Forms.CheckBox();
            this.restar = new System.Windows.Forms.CheckBox();
            this.multiplicar = new System.Windows.Forms.CheckBox();
            this.dividir = new System.Windows.Forms.CheckBox();
            this.modulo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalcular.Location = new System.Drawing.Point(149, 339);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operaciones Básicas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número 2";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(171, 378);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(35, 13);
            this.result.TabIndex = 4;
            this.result.Text = "label7";
            // 
            // tbnum1
            // 
            this.tbnum1.Location = new System.Drawing.Point(139, 149);
            this.tbnum1.Name = "tbnum1";
            this.tbnum1.Size = new System.Drawing.Size(100, 20);
            this.tbnum1.TabIndex = 5;
            // 
            // tbnum2
            // 
            this.tbnum2.Location = new System.Drawing.Point(139, 229);
            this.tbnum2.Name = "tbnum2";
            this.tbnum2.Size = new System.Drawing.Size(100, 20);
            this.tbnum2.TabIndex = 6;
            // 
            // sumar
            // 
            this.sumar.AutoSize = true;
            this.sumar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sumar.Location = new System.Drawing.Point(151, 264);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(32, 17);
            this.sumar.TabIndex = 7;
            this.sumar.Text = "+";
            this.sumar.UseVisualStyleBackColor = true;
            // 
            // restar
            // 
            this.restar.AutoSize = true;
            this.restar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restar.Location = new System.Drawing.Point(197, 264);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(29, 17);
            this.restar.TabIndex = 8;
            this.restar.Text = "-";
            this.restar.UseVisualStyleBackColor = true;
            // 
            // multiplicar
            // 
            this.multiplicar.AutoSize = true;
            this.multiplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiplicar.Location = new System.Drawing.Point(151, 290);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(30, 17);
            this.multiplicar.TabIndex = 9;
            this.multiplicar.Text = "*";
            this.multiplicar.UseVisualStyleBackColor = true;
            // 
            // dividir
            // 
            this.dividir.AutoSize = true;
            this.dividir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dividir.Location = new System.Drawing.Point(197, 290);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(31, 17);
            this.dividir.TabIndex = 10;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = true;
            // 
            // modulo
            // 
            this.modulo.AutoSize = true;
            this.modulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modulo.Location = new System.Drawing.Point(172, 314);
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(34, 17);
            this.modulo.TabIndex = 11;
            this.modulo.Text = "%";
            this.modulo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 464);
            this.Controls.Add(this.modulo);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.tbnum2);
            this.Controls.Add(this.tbnum1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox tbnum1;
        private System.Windows.Forms.TextBox tbnum2;
        private System.Windows.Forms.CheckBox sumar;
        private System.Windows.Forms.CheckBox restar;
        private System.Windows.Forms.CheckBox multiplicar;
        private System.Windows.Forms.CheckBox dividir;
        private System.Windows.Forms.CheckBox modulo;
    }
}

