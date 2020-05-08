namespace buscaminas
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buscaminasDataSet = new buscaminas.BuscaminasDataSet();
            this.historialPuntuacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialPuntuacionTableAdapter = new buscaminas.BuscaminasDataSetTableAdapters.HistorialPuntuacionTableAdapter();
            this.regDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreJugadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoTranscurridoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscaminasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialPuntuacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regDataGridViewTextBoxColumn,
            this.nombreJugadorDataGridViewTextBoxColumn,
            this.tiempoTranscurridoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.historialPuntuacionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // buscaminasDataSet
            // 
            this.buscaminasDataSet.DataSetName = "BuscaminasDataSet";
            this.buscaminasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historialPuntuacionBindingSource
            // 
            this.historialPuntuacionBindingSource.DataMember = "HistorialPuntuacion";
            this.historialPuntuacionBindingSource.DataSource = this.buscaminasDataSet;
            // 
            // historialPuntuacionTableAdapter
            // 
            this.historialPuntuacionTableAdapter.ClearBeforeFill = true;
            // 
            // regDataGridViewTextBoxColumn
            // 
            this.regDataGridViewTextBoxColumn.DataPropertyName = "Reg";
            this.regDataGridViewTextBoxColumn.HeaderText = "Reg";
            this.regDataGridViewTextBoxColumn.Name = "regDataGridViewTextBoxColumn";
            this.regDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreJugadorDataGridViewTextBoxColumn
            // 
            this.nombreJugadorDataGridViewTextBoxColumn.DataPropertyName = "NombreJugador";
            this.nombreJugadorDataGridViewTextBoxColumn.HeaderText = "NombreJugador";
            this.nombreJugadorDataGridViewTextBoxColumn.Name = "nombreJugadorDataGridViewTextBoxColumn";
            // 
            // tiempoTranscurridoDataGridViewTextBoxColumn
            // 
            this.tiempoTranscurridoDataGridViewTextBoxColumn.DataPropertyName = "TiempoTranscurrido";
            this.tiempoTranscurridoDataGridViewTextBoxColumn.HeaderText = "TiempoTranscurrido";
            this.tiempoTranscurridoDataGridViewTextBoxColumn.Name = "tiempoTranscurridoDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(621, 245);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscaminasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialPuntuacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreJugadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoTranscurridoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource historialPuntuacionBindingSource;
        private BuscaminasDataSet buscaminasDataSet;
        private BuscaminasDataSetTableAdapters.HistorialPuntuacionTableAdapter historialPuntuacionTableAdapter;
    }
}
