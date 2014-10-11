namespace AppNumero
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnumeromenor = new System.Windows.Forms.Label();
            this.lblnumeromayor = new System.Windows.Forms.Label();
            this.txtnumeromenor = new System.Windows.Forms.TextBox();
            this.txtnumeromayor = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.rtbmostrar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblnumeromenor
            // 
            this.lblnumeromenor.AutoSize = true;
            this.lblnumeromenor.Location = new System.Drawing.Point(59, 37);
            this.lblnumeromenor.Name = "lblnumeromenor";
            this.lblnumeromenor.Size = new System.Drawing.Size(77, 13);
            this.lblnumeromenor.TabIndex = 0;
            this.lblnumeromenor.Text = "Numero Menor";
            // 
            // lblnumeromayor
            // 
            this.lblnumeromayor.AutoSize = true;
            this.lblnumeromayor.Location = new System.Drawing.Point(59, 86);
            this.lblnumeromayor.Name = "lblnumeromayor";
            this.lblnumeromayor.Size = new System.Drawing.Size(76, 13);
            this.lblnumeromayor.TabIndex = 1;
            this.lblnumeromayor.Text = "Numero Mayor";
            // 
            // txtnumeromenor
            // 
            this.txtnumeromenor.Location = new System.Drawing.Point(147, 37);
            this.txtnumeromenor.Name = "txtnumeromenor";
            this.txtnumeromenor.Size = new System.Drawing.Size(100, 20);
            this.txtnumeromenor.TabIndex = 3;
            // 
            // txtnumeromayor
            // 
            this.txtnumeromayor.Location = new System.Drawing.Point(147, 78);
            this.txtnumeromayor.Name = "txtnumeromayor";
            this.txtnumeromayor.Size = new System.Drawing.Size(100, 20);
            this.txtnumeromayor.TabIndex = 4;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(172, 211);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // rtbmostrar
            // 
            this.rtbmostrar.Location = new System.Drawing.Point(47, 125);
            this.rtbmostrar.Name = "rtbmostrar";
            this.rtbmostrar.Size = new System.Drawing.Size(211, 80);
            this.rtbmostrar.TabIndex = 6;
            this.rtbmostrar.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rtbmostrar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtnumeromayor);
            this.Controls.Add(this.txtnumeromenor);
            this.Controls.Add(this.lblnumeromayor);
            this.Controls.Add(this.lblnumeromenor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumeromenor;
        private System.Windows.Forms.Label lblnumeromayor;
        private System.Windows.Forms.TextBox txtnumeromenor;
        private System.Windows.Forms.TextBox txtnumeromayor;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.RichTextBox rtbmostrar;
    }
}

