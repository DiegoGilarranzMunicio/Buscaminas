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
    public partial class Form3 : Form
    {
        public static string nivel;
        public static string user;

       Form1 formularioNuevo = new Form1();

        public Form3()
        {
            InitializeComponent();
            //historialPuntuacionTableAdapter.Connection.Open(); 
        }

       

        private void facil_Click(object sender, EventArgs e)
        {
            int N = 3;
            Form1.minas = N;
            Form1 formularioNuevo = new Form1();            
            formularioNuevo.Show();
            nivel = "Facil";  
            
        }

        private void medio_Click(object sender, EventArgs e)
        {
            Form1.minas = 10;
            Form1 formularioNuevo = new Form1();
            formularioNuevo.Show();
            nivel = "Medio";
                  }

        private void dificil_Click(object sender, EventArgs e)
        {
            Form1.minas = 5;
            Form1 formularioNuevo = new Form1();
            formularioNuevo.Show();
            nivel = "Dificil";
        }

        private void personalizado_Click(object sender, EventArgs e)
        {
            personal formularioNuevo = new personal();
            formularioNuevo.Show();
            nivel = "Personalizado";
        }

  
              private void Aceptar_Click_1(object sender, EventArgs e)
        {
            user = nombretext.Text;

            MessageBox.Show("Usuario valido");
        }


       
     
                               
    }
}
