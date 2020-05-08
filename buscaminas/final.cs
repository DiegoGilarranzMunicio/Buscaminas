using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace buscaminas
{
    public partial class final : Form
    {
       
        
        public final()
        {
            InitializeComponent();
            

            usuario.Text = Form3.user;
            tiempo.Text = Form1.tiempoenterminar.ToString();
            dia.Text = DateTime.Now.ToString(); 
            nivel.Text = Form3.nivel;
            
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            historialPuntuacionTableAdapter1.Insert(Form3.user, Int16.Parse(Form1.tiempoenterminar), DateTime.Now , Form3.nivel);
           
            Application.ExitThread();
        }

        private void historialPuntuacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historialPuntuacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buscaminasDataSet);

        }

        private void final_Load(object sender, EventArgs e)
        {
            //DateTime pi;
            //pi=DateTime.Now ;
            // TODO: esta línea de código carga datos en la tabla 'buscaminasDataSet2.HistorialPuntuacion' Puede moverla o quitarla según sea necesario.
            this.historialPuntuacionTableAdapter1.Fill(this.buscaminasDataSet2.HistorialPuntuacion);

            // TODO: esta línea de código carga datos en la tabla 'buscaminasDataSet.HistorialPuntuacion' Puede moverla o quitarla según sea necesario.
            //this.historialPuntuacionTableAdapter.Fill(this.buscaminasDataSet.HistorialPuntuacion);
            //historialPuntuacionTableAdapter1.Insert(Form3.user, Convert.ToInt16( Form1.tiempoenterminar), pi.Date , Form3.nivel);
           
          
        }

        
    } 
}
