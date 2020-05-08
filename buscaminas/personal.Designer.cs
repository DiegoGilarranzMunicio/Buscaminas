namespace buscaminas
{
    partial class personal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texfilas = new System.Windows.Forms.TextBox();
            this.texcolumnas = new System.Windows.Forms.TextBox();
            this.texminas = new System.Windows.Forms.TextBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personalizado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Columnas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Minas";
            // 
            // texfilas
            // 
            this.texfilas.Location = new System.Drawing.Point(13, 75);
            this.texfilas.Name = "texfilas";
            this.texfilas.Size = new System.Drawing.Size(51, 20);
            this.texfilas.TabIndex = 4;
            // 
            // texcolumnas
            // 
            this.texcolumnas.Location = new System.Drawing.Point(116, 75);
            this.texcolumnas.Name = "texcolumnas";
            this.texcolumnas.Size = new System.Drawing.Size(51, 20);
            this.texcolumnas.TabIndex = 5;
            // 
            // texminas
            // 
            this.texminas.Location = new System.Drawing.Point(221, 75);
            this.texminas.Name = "texminas";
            this.texminas.Size = new System.Drawing.Size(51, 20);
            this.texminas.TabIndex = 6;
            // 
            // aceptar
            // 
            this.aceptar.BackColor = System.Drawing.SystemColors.Highlight;
            this.aceptar.Location = new System.Drawing.Point(103, 137);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 7;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = false;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.texminas);
            this.Controls.Add(this.texcolumnas);
            this.Controls.Add(this.texfilas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "personal";
            this.Text = "personal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texfilas;
        private System.Windows.Forms.TextBox texcolumnas;
        private System.Windows.Forms.TextBox texminas;
        private System.Windows.Forms.Button aceptar;
    }
}