namespace buscaminas
{
    partial class Form3
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
            System.Windows.Forms.Label nombreJugadorLabel;
            this.Aceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.facil = new System.Windows.Forms.Button();
            this.medio = new System.Windows.Forms.Button();
            this.dificil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.personalizado = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buscaminasDataSet = new buscaminas.BuscaminasDataSet();
            this.historialPuntuacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialPuntuacionTableAdapter = new buscaminas.BuscaminasDataSetTableAdapters.HistorialPuntuacionTableAdapter();
            this.tableAdapterManager = new buscaminas.BuscaminasDataSetTableAdapters.TableAdapterManager();
            this.nombretext = new System.Windows.Forms.TextBox();
            nombreJugadorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buscaminasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialPuntuacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreJugadorLabel
            // 
            nombreJugadorLabel.AutoSize = true;
            nombreJugadorLabel.Location = new System.Drawing.Point(0, 42);
            nombreJugadorLabel.Name = "nombreJugadorLabel";
            nombreJugadorLabel.Size = new System.Drawing.Size(88, 13);
            nombreJugadorLabel.TabIndex = 11;
            nombreJugadorLabel.Text = "Nombre Jugador:";
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.Aceptar.ForeColor = System.Drawing.Color.Red;
            this.Aceptar.Location = new System.Drawing.Point(108, 74);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 2;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Escoje un nivel";
            // 
            // facil
            // 
            this.facil.BackColor = System.Drawing.SystemColors.Highlight;
            this.facil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.facil.Location = new System.Drawing.Point(3, 166);
            this.facil.Name = "facil";
            this.facil.Size = new System.Drawing.Size(75, 23);
            this.facil.TabIndex = 4;
            this.facil.Text = "Facil";
            this.facil.UseVisualStyleBackColor = false;
            this.facil.Click += new System.EventHandler(this.facil_Click);
            // 
            // medio
            // 
            this.medio.BackColor = System.Drawing.SystemColors.Highlight;
            this.medio.Location = new System.Drawing.Point(109, 166);
            this.medio.Name = "medio";
            this.medio.Size = new System.Drawing.Size(75, 23);
            this.medio.TabIndex = 5;
            this.medio.Text = "Medio";
            this.medio.UseVisualStyleBackColor = false;
            this.medio.Click += new System.EventHandler(this.medio_Click);
            // 
            // dificil
            // 
            this.dificil.BackColor = System.Drawing.SystemColors.Highlight;
            this.dificil.Location = new System.Drawing.Point(207, 166);
            this.dificil.Name = "dificil";
            this.dificil.Size = new System.Drawing.Size(75, 23);
            this.dificil.TabIndex = 6;
            this.dificil.Text = "Dificil";
            this.dificil.UseVisualStyleBackColor = false;
            this.dificil.Click += new System.EventHandler(this.dificil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "5 minas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "10 minas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "15 minas";
            // 
            // personalizado
            // 
            this.personalizado.BackColor = System.Drawing.SystemColors.Highlight;
            this.personalizado.Location = new System.Drawing.Point(93, 243);
            this.personalizado.Name = "personalizado";
            this.personalizado.Size = new System.Drawing.Size(107, 23);
            this.personalizado.TabIndex = 10;
            this.personalizado.Text = "Personalizado";
            this.personalizado.UseVisualStyleBackColor = false;
            this.personalizado.Click += new System.EventHandler(this.personalizado_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(81, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "BUSCAMINAS";
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
            // nombretext
            // 
            this.nombretext.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historialPuntuacionBindingSource, "NombreJugador", true));
            this.nombretext.Location = new System.Drawing.Point(94, 39);
            this.nombretext.Name = "nombretext";
            this.nombretext.Size = new System.Drawing.Size(100, 20);
            this.nombretext.TabIndex = 12;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 324);
            this.Controls.Add(nombreJugadorLabel);
            this.Controls.Add(this.nombretext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.personalizado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dificil);
            this.Controls.Add(this.medio);
            this.Controls.Add(this.facil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Aceptar);
            this.Name = "Form3";
            this.Text = "Form3";
            //this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buscaminasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialPuntuacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button facil;
        private System.Windows.Forms.Button medio;
        private System.Windows.Forms.Button dificil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button personalizado;
        private System.Windows.Forms.Label label6;
        private BuscaminasDataSet buscaminasDataSet;
        private System.Windows.Forms.BindingSource historialPuntuacionBindingSource;
        private BuscaminasDataSetTableAdapters.HistorialPuntuacionTableAdapter historialPuntuacionTableAdapter;
        private BuscaminasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombretext;

    }
}