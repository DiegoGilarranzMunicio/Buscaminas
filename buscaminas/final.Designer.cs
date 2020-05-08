namespace buscaminas
{
    partial class final
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nivelLabel;
            this.usuario = new System.Windows.Forms.TextBox();
            this.tiempo = new System.Windows.Forms.TextBox();
            this.dia = new System.Windows.Forms.TextBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.buscaminasDataSet = new buscaminas.BuscaminasDataSet();
            this.historialPuntuacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialPuntuacionTableAdapter = new buscaminas.BuscaminasDataSetTableAdapters.HistorialPuntuacionTableAdapter();
            this.tableAdapterManager = new buscaminas.BuscaminasDataSetTableAdapters.TableAdapterManager();
            this.buscaminasDataSet2 = new buscaminas.BuscaminasDataSet2();
            this.historialPuntuacionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.historialPuntuacionTableAdapter1 = new buscaminas.BuscaminasDataSet2TableAdapters.HistorialPuntuacionTableAdapter();
            this.tableAdapterManager1 = new buscaminas.BuscaminasDataSet2TableAdapters.TableAdapterManager();
            this.nivel = new System.Windows.Forms.TextBox();
            nivelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buscaminasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialPuntuacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscaminasDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialPuntuacionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(31, 26);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(100, 20);
            this.usuario.TabIndex = 0;
            // 
            // tiempo
            // 
            this.tiempo.Location = new System.Drawing.Point(31, 75);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(100, 20);
            this.tiempo.TabIndex = 1;
            // 
            // dia
            // 
            this.dia.Location = new System.Drawing.Point(203, 26);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(147, 20);
            this.dia.TabIndex = 2;
            // 
            // aceptar
            // 
            this.aceptar.BackColor = System.Drawing.SystemColors.Highlight;
            this.aceptar.Location = new System.Drawing.Point(132, 122);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 3;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = false;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(31, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(31, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tiempo";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.ForeColor = System.Drawing.Color.Red;
            this.fecha.Location = new System.Drawing.Point(200, 7);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(37, 13);
            this.fecha.TabIndex = 6;
            this.fecha.Text = "Fecha";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HistorialPuntuacionTableAdapter = this.historialPuntuacionTableAdapter;
            this.tableAdapterManager.UpdateOrder = buscaminas.BuscaminasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // buscaminasDataSet2
            // 
            this.buscaminasDataSet2.DataSetName = "BuscaminasDataSet2";
            this.buscaminasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historialPuntuacionBindingSource1
            // 
            this.historialPuntuacionBindingSource1.DataMember = "HistorialPuntuacion";
            this.historialPuntuacionBindingSource1.DataSource = this.buscaminasDataSet2;
            // 
            // historialPuntuacionTableAdapter1
            // 
            this.historialPuntuacionTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.HistorialPuntuacionTableAdapter = this.historialPuntuacionTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = buscaminas.BuscaminasDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nivelLabel
            // 
            nivelLabel.AutoSize = true;
            nivelLabel.ForeColor = System.Drawing.Color.Red;
            nivelLabel.Location = new System.Drawing.Point(203, 53);
            nivelLabel.Name = "nivelLabel";
            nivelLabel.Size = new System.Drawing.Size(34, 13);
            nivelLabel.TabIndex = 7;
            nivelLabel.Text = "Nivel:";
                       // 
            // nivel
            // 
            this.nivel.Location = new System.Drawing.Point(203, 75);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(100, 20);
            this.nivel.TabIndex = 8;
            // 
            // final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 179);
            this.Controls.Add(this.nivel);
            this.Controls.Add(nivelLabel);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.dia);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.usuario);
            this.Name = "final";
            this.Text = "final";
            this.Load += new System.EventHandler(this.final_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buscaminasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialPuntuacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscaminasDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialPuntuacionBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox tiempo;
        private System.Windows.Forms.TextBox dia;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fecha;
        private BuscaminasDataSet buscaminasDataSet;
        private System.Windows.Forms.BindingSource historialPuntuacionBindingSource;
        private BuscaminasDataSetTableAdapters.HistorialPuntuacionTableAdapter historialPuntuacionTableAdapter;
        private BuscaminasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BuscaminasDataSet2 buscaminasDataSet2;
        private System.Windows.Forms.BindingSource historialPuntuacionBindingSource1;
        private BuscaminasDataSet2TableAdapters.HistorialPuntuacionTableAdapter historialPuntuacionTableAdapter1;
        private BuscaminasDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox nivel;
    }
}