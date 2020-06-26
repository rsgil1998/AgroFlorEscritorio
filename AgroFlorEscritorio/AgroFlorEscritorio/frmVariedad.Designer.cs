namespace AgroFlorEscritorio
{
    partial class frmVariedad
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstVariedades = new System.Windows.Forms.DataGridView();
            this.grbNewVariedad = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMatas = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstVariedades)).BeginInit();
            this.grbNewVariedad.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstVariedades);
            this.groupBox2.Location = new System.Drawing.Point(407, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 223);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado";
            // 
            // lstVariedades
            // 
            this.lstVariedades.AllowUserToAddRows = false;
            this.lstVariedades.AllowUserToDeleteRows = false;
            this.lstVariedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstVariedades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVariedades.Location = new System.Drawing.Point(3, 16);
            this.lstVariedades.Name = "lstVariedades";
            this.lstVariedades.ReadOnly = true;
            this.lstVariedades.Size = new System.Drawing.Size(336, 204);
            this.lstVariedades.TabIndex = 0;
            // 
            // grbNewVariedad
            // 
            this.grbNewVariedad.Controls.Add(this.toolStrip1);
            this.grbNewVariedad.Controls.Add(this.txtNombre);
            this.grbNewVariedad.Controls.Add(this.label1);
            this.grbNewVariedad.Controls.Add(this.label2);
            this.grbNewVariedad.Controls.Add(this.nudMatas);
            this.grbNewVariedad.Location = new System.Drawing.Point(52, 42);
            this.grbNewVariedad.Name = "grbNewVariedad";
            this.grbNewVariedad.Size = new System.Drawing.Size(278, 149);
            this.grbNewVariedad.TabIndex = 8;
            this.grbNewVariedad.TabStop = false;
            this.grbNewVariedad.Text = "Nueva Variedad";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 121);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(272, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(53, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total matas: ";
            // 
            // nudMatas
            // 
            this.nudMatas.Location = new System.Drawing.Point(127, 84);
            this.nudMatas.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nudMatas.Name = "nudMatas";
            this.nudMatas.Size = new System.Drawing.Size(100, 20);
            this.nudMatas.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Variedades";
            // 
            // frmVariedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbNewVariedad);
            this.Controls.Add(this.label3);
            this.Name = "frmVariedad";
            this.Text = "frmVariedad";
            this.Load += new System.EventHandler(this.frmVariedad_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstVariedades)).EndInit();
            this.grbNewVariedad.ResumeLayout(false);
            this.grbNewVariedad.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView lstVariedades;
        private System.Windows.Forms.GroupBox grbNewVariedad;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMatas;
        private System.Windows.Forms.Label label3;
    }
}