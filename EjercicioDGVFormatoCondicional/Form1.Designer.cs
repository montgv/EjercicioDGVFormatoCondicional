namespace EjercicioDGVFormatoCondicional
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSumaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNombre,
            this.ColumnApellido1,
            this.ColumnApellido2,
            this.ColumnLocalidad,
            this.ColumnFechaAlta,
            this.ColumnTipoCliente,
            this.ColumnSumaTotal});
            this.dgv.Location = new System.Drawing.Point(12, 93);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(859, 150);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.Name = "ColumnCodigo";
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnApellido1
            // 
            this.ColumnApellido1.HeaderText = "Apellido1";
            this.ColumnApellido1.Name = "ColumnApellido1";
            // 
            // ColumnApellido2
            // 
            this.ColumnApellido2.HeaderText = "Apellido2";
            this.ColumnApellido2.Name = "ColumnApellido2";
            // 
            // ColumnLocalidad
            // 
            this.ColumnLocalidad.HeaderText = "Localidad";
            this.ColumnLocalidad.Name = "ColumnLocalidad";
            // 
            // ColumnFechaAlta
            // 
            this.ColumnFechaAlta.HeaderText = "Fecha Alta";
            this.ColumnFechaAlta.Name = "ColumnFechaAlta";
            // 
            // ColumnTipoCliente
            // 
            this.ColumnTipoCliente.HeaderText = "Tipo Cliente";
            this.ColumnTipoCliente.Name = "ColumnTipoCliente";
            // 
            // ColumnSumaTotal
            // 
            this.ColumnSumaTotal.HeaderText = "Suma Total";
            this.ColumnSumaTotal.Name = "ColumnSumaTotal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnApellido1;
        private DataGridViewTextBoxColumn ColumnApellido2;
        private DataGridViewTextBoxColumn ColumnLocalidad;
        private DataGridViewTextBoxColumn ColumnFechaAlta;
        private DataGridViewTextBoxColumn ColumnTipoCliente;
        private DataGridViewTextBoxColumn ColumnSumaTotal;
    }
}