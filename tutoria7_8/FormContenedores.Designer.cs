namespace Tutoria7
{
    partial class FormContenedores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.btnDesencolar = new System.Windows.Forms.Button();
            this.nudTiempoAtencion = new System.Windows.Forms.NumericUpDown();
            this.cmbLugarProcedencia = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.nudNumeroCajas = new System.Windows.Forms.NumericUpDown();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroContendor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTiempoAtencion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCajas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEncolar);
            this.groupBox1.Controls.Add(this.btnDesencolar);
            this.groupBox1.Controls.Add(this.nudTiempoAtencion);
            this.groupBox1.Controls.Add(this.cmbLugarProcedencia);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.nudNumeroCajas);
            this.groupBox1.Controls.Add(this.cmbRubro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEncargado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumeroContendor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(54, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de contenedores";
            // 
            // btnEncolar
            // 
            this.btnEncolar.Location = new System.Drawing.Point(66, 329);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(75, 23);
            this.btnEncolar.TabIndex = 15;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.UseVisualStyleBackColor = true;
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
            // 
            // btnDesencolar
            // 
            this.btnDesencolar.Location = new System.Drawing.Point(173, 329);
            this.btnDesencolar.Name = "btnDesencolar";
            this.btnDesencolar.Size = new System.Drawing.Size(109, 23);
            this.btnDesencolar.TabIndex = 14;
            this.btnDesencolar.Text = "Desencolar";
            this.btnDesencolar.UseVisualStyleBackColor = true;
            this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click);
            // 
            // nudTiempoAtencion
            // 
            this.nudTiempoAtencion.Location = new System.Drawing.Point(199, 276);
            this.nudTiempoAtencion.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudTiempoAtencion.Name = "nudTiempoAtencion";
            this.nudTiempoAtencion.Size = new System.Drawing.Size(140, 22);
            this.nudTiempoAtencion.TabIndex = 13;
            // 
            // cmbLugarProcedencia
            // 
            this.cmbLugarProcedencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugarProcedencia.FormattingEnabled = true;
            this.cmbLugarProcedencia.Items.AddRange(new object[] {
            "USA",
            "Italia"});
            this.cmbLugarProcedencia.Location = new System.Drawing.Point(199, 233);
            this.cmbLugarProcedencia.Name = "cmbLugarProcedencia";
            this.cmbLugarProcedencia.Size = new System.Drawing.Size(140, 24);
            this.cmbLugarProcedencia.TabIndex = 12;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(199, 191);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(140, 22);
            this.txtValor.TabIndex = 11;
            // 
            // nudNumeroCajas
            // 
            this.nudNumeroCajas.Location = new System.Drawing.Point(199, 152);
            this.nudNumeroCajas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumeroCajas.Name = "nudNumeroCajas";
            this.nudNumeroCajas.Size = new System.Drawing.Size(140, 22);
            this.nudNumeroCajas.TabIndex = 10;
            this.nudNumeroCajas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbRubro
            // 
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Items.AddRange(new object[] {
            "Ropa",
            "Repuestos"});
            this.cmbRubro.Location = new System.Drawing.Point(199, 108);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(140, 24);
            this.cmbRubro.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tiempo de atencion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Lugar de procedencia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valor mercancia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero de cajas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rubro:";
            // 
            // txtEncargado
            // 
            this.txtEncargado.Location = new System.Drawing.Point(199, 68);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(140, 22);
            this.txtEncargado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encargado:";
            // 
            // txtNumeroContendor
            // 
            this.txtNumeroContendor.Location = new System.Drawing.Point(199, 33);
            this.txtNumeroContendor.Name = "txtNumeroContendor";
            this.txtNumeroContendor.Size = new System.Drawing.Size(140, 22);
            this.txtNumeroContendor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de contenedor:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(481, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(659, 323);
            this.dataGridView1.TabIndex = 1;
            // 
            // FormContenedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormContenedores";
            this.Text = "FormContenedores";
            this.Load += new System.EventHandler(this.FormContenedores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTiempoAtencion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCajas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroContendor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTiempoAtencion;
        private System.Windows.Forms.ComboBox cmbLugarProcedencia;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.NumericUpDown nudNumeroCajas;
        private System.Windows.Forms.ComboBox cmbRubro;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.Button btnDesencolar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}