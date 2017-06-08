namespace Proyecto_Hospital
{
    partial class frmMostrar_Pacto
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
            this.dgpacto = new System.Windows.Forms.DataGridView();
            this.btnBuscarPorFecha = new System.Windows.Forms.Button();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigopacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad_medida = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pacto_stocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuencia = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.costo_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgpacto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgpacto
            // 
            this.dgpacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpacto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.codigopacto,
            this.numero,
            this.codigo_stock,
            this.descripcion,
            this.unidad_medida,
            this.pacto_stocks,
            this.frecuencia,
            this.costo_unitario,
            this.costo_total});
            this.dgpacto.Location = new System.Drawing.Point(12, 22);
            this.dgpacto.Name = "dgpacto";
            this.dgpacto.Size = new System.Drawing.Size(1061, 361);
            this.dgpacto.TabIndex = 34;
            // 
            // btnBuscarPorFecha
            // 
            this.btnBuscarPorFecha.Location = new System.Drawing.Point(155, 431);
            this.btnBuscarPorFecha.Name = "btnBuscarPorFecha";
            this.btnBuscarPorFecha.Size = new System.Drawing.Size(63, 29);
            this.btnBuscarPorFecha.TabIndex = 35;
            this.btnBuscarPorFecha.Text = "Buscar";
            this.btnBuscarPorFecha.UseVisualStyleBackColor = true;
            this.btnBuscarPorFecha.Click += new System.EventHandler(this.btnBuscarPorFecha_Click);
            // 
            // dtfecha
            // 
            this.dtfecha.CustomFormat = "dd/mm/yyyy";
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfecha.Location = new System.Drawing.Point(45, 433);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(104, 20);
            this.dtfecha.TabIndex = 36;
            this.dtfecha.Value = new System.DateTime(2017, 5, 30, 21, 8, 46, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Busqueda por Fecha:";
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // codigopacto
            // 
            this.codigopacto.DataPropertyName = "codigopacto";
            this.codigopacto.HeaderText = "Codigo Pacto de Stock";
            this.codigopacto.Name = "codigopacto";
            // 
            // numero
            // 
            this.numero.HeaderText = "N#";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.numero.Width = 30;
            // 
            // codigo_stock
            // 
            this.codigo_stock.DataPropertyName = "codigo_stock";
            this.codigo_stock.HeaderText = "Codigo";
            this.codigo_stock.Name = "codigo_stock";
            this.codigo_stock.Width = 50;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 400;
            // 
            // unidad_medida
            // 
            this.unidad_medida.DataPropertyName = "unidad_medida";
            this.unidad_medida.FillWeight = 70F;
            this.unidad_medida.HeaderText = "Unidad de Medida";
            this.unidad_medida.Name = "unidad_medida";
            this.unidad_medida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unidad_medida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unidad_medida.Width = 70;
            // 
            // pacto_stocks
            // 
            this.pacto_stocks.DataPropertyName = "pacto_stocks";
            this.pacto_stocks.FillWeight = 70F;
            this.pacto_stocks.HeaderText = "Pacto de Stock";
            this.pacto_stocks.Name = "pacto_stocks";
            this.pacto_stocks.Width = 70;
            // 
            // frecuencia
            // 
            this.frecuencia.DataPropertyName = "frecuencia";
            this.frecuencia.FillWeight = 70F;
            this.frecuencia.HeaderText = "Frecuencia";
            this.frecuencia.Name = "frecuencia";
            this.frecuencia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.frecuencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.frecuencia.Width = 70;
            // 
            // costo_unitario
            // 
            this.costo_unitario.DataPropertyName = "costo_unitario";
            this.costo_unitario.FillWeight = 50F;
            this.costo_unitario.HeaderText = "Costo Unitario";
            this.costo_unitario.Name = "costo_unitario";
            this.costo_unitario.Width = 70;
            // 
            // costo_total
            // 
            this.costo_total.DataPropertyName = "costo_total";
            this.costo_total.FillWeight = 50F;
            this.costo_total.HeaderText = "Costo Total";
            this.costo_total.Name = "costo_total";
            this.costo_total.Width = 60;
            // 
            // frmMostrar_Pacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtfecha);
            this.Controls.Add(this.btnBuscarPorFecha);
            this.Controls.Add(this.dgpacto);
            this.Name = "frmMostrar_Pacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMostrar_Pacto";
            this.Load += new System.EventHandler(this.frmMostrar_Pacto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgpacto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgpacto;
        private System.Windows.Forms.Button btnBuscarPorFecha;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigopacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewComboBoxColumn unidad_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacto_stocks;
        private System.Windows.Forms.DataGridViewComboBoxColumn frecuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_total;
    }
}