namespace AgroFlorEscritorio
{
    partial class frmEstadistica
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
            this.nudPrecioPorMata = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVariedad = new System.Windows.Forms.ComboBox();
            this.btnCalcularEst = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmatas = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioPorMata)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudPrecioPorMata
            // 
            this.nudPrecioPorMata.DecimalPlaces = 2;
            this.nudPrecioPorMata.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPrecioPorMata.Location = new System.Drawing.Point(144, 54);
            this.nudPrecioPorMata.Name = "nudPrecioPorMata";
            this.nudPrecioPorMata.Size = new System.Drawing.Size(120, 20);
            this.nudPrecioPorMata.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Precio por mata:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de la variedad;";
            // 
            // cmbVariedad
            // 
            this.cmbVariedad.FormattingEnabled = true;
            this.cmbVariedad.Location = new System.Drawing.Point(143, 27);
            this.cmbVariedad.Name = "cmbVariedad";
            this.cmbVariedad.Size = new System.Drawing.Size(121, 21);
            this.cmbVariedad.TabIndex = 3;
            // 
            // btnCalcularEst
            // 
            this.btnCalcularEst.Location = new System.Drawing.Point(292, 44);
            this.btnCalcularEst.Name = "btnCalcularEst";
            this.btnCalcularEst.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularEst.TabIndex = 4;
            this.btnCalcularEst.Text = "Calcular";
            this.btnCalcularEst.UseVisualStyleBackColor = true;
            this.btnCalcularEst.Click += new System.EventHandler(this.btnCalcularEst_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblCosto);
            this.groupBox1.Controls.Add(this.lblmatas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCalcularEst);
            this.groupBox1.Controls.Add(this.nudPrecioPorMata);
            this.groupBox1.Controls.Add(this.cmbVariedad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(81, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 108);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CostoDeProdución";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "El costo de producción";
            // 
            // lblmatas
            // 
            this.lblmatas.AutoSize = true;
            this.lblmatas.Location = new System.Drawing.Point(432, 44);
            this.lblmatas.Name = "lblmatas";
            this.lblmatas.Size = new System.Drawing.Size(22, 13);
            this.lblmatas.TabIndex = 6;
            this.lblmatas.Text = "-----";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(419, 81);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(46, 13);
            this.lblCosto.TabIndex = 7;
            this.lblCosto.Text = "-------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "es:";
            // 
            // frmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEstadistica";
            this.Text = "Estadistica";
            this.Load += new System.EventHandler(this.frmEstadistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioPorMata)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudPrecioPorMata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVariedad;
        private System.Windows.Forms.Button btnCalcularEst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblmatas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}