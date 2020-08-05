namespace Ingreso_Individual_Facturas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rbexcel = new System.Windows.Forms.RadioButton();
            this.rbpdf = new System.Windows.Forms.RadioButton();
            this.textotales = new System.Windows.Forms.TextBox();
            this.textreceptor = new System.Windows.Forms.TextBox();
            this.textprove = new System.Windows.Forms.TextBox();
            this.textfactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rbexcel);
            this.groupBox1.Controls.Add(this.rbpdf);
            this.groupBox1.Controls.Add(this.textotales);
            this.groupBox1.Controls.Add(this.textreceptor);
            this.groupBox1.Controls.Add(this.textprove);
            this.groupBox1.Controls.Add(this.textfactura);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "Exportar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ingreso factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbexcel
            // 
            this.rbexcel.AutoSize = true;
            this.rbexcel.Location = new System.Drawing.Point(305, 282);
            this.rbexcel.Name = "rbexcel";
            this.rbexcel.Size = new System.Drawing.Size(51, 17);
            this.rbexcel.TabIndex = 9;
            this.rbexcel.TabStop = true;
            this.rbexcel.Text = "Excel";
            this.rbexcel.UseVisualStyleBackColor = true;
            // 
            // rbpdf
            // 
            this.rbpdf.AutoSize = true;
            this.rbpdf.Location = new System.Drawing.Point(219, 282);
            this.rbpdf.Name = "rbpdf";
            this.rbpdf.Size = new System.Drawing.Size(46, 17);
            this.rbpdf.TabIndex = 8;
            this.rbpdf.TabStop = true;
            this.rbpdf.Text = "PDF";
            this.rbpdf.UseVisualStyleBackColor = true;
            this.rbpdf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbpdf_KeyPress);
            // 
            // textotales
            // 
            this.textotales.Location = new System.Drawing.Point(153, 174);
            this.textotales.Name = "textotales";
            this.textotales.Size = new System.Drawing.Size(100, 20);
            this.textotales.TabIndex = 7;
            this.textotales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textotales_KeyPress);
            // 
            // textreceptor
            // 
            this.textreceptor.Location = new System.Drawing.Point(153, 129);
            this.textreceptor.Name = "textreceptor";
            this.textreceptor.Size = new System.Drawing.Size(100, 20);
            this.textreceptor.TabIndex = 6;
            // 
            // textprove
            // 
            this.textprove.Location = new System.Drawing.Point(153, 87);
            this.textprove.Name = "textprove";
            this.textprove.Size = new System.Drawing.Size(100, 20);
            this.textprove.TabIndex = 5;
            this.textprove.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textprove_KeyPress);
            // 
            // textfactura
            // 
            this.textfactura.Location = new System.Drawing.Point(153, 44);
            this.textfactura.Name = "textfactura";
            this.textfactura.Size = new System.Drawing.Size(100, 20);
            this.textfactura.TabIndex = 4;
            this.textfactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textfactura_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Totales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Receptor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Factura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbexcel;
        private System.Windows.Forms.RadioButton rbpdf;
        private System.Windows.Forms.TextBox textotales;
        private System.Windows.Forms.TextBox textreceptor;
        private System.Windows.Forms.TextBox textprove;
        private System.Windows.Forms.TextBox textfactura;
    }
}

