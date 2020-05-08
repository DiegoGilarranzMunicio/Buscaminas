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
    public partial class personal : Form
    {
        public personal()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
           // int N = 1;
           // N = Int32.Parse(texfilas.Text);
            Form1.minas = double.Parse(texminas.Text);      
           Form1.filas = Int32.Parse(texfilas.Text);
           Form1.columnas = Int32.Parse(texcolumnas.Text);
            Form1 formularioNuevo = new Form1();
            formularioNuevo.Show();
            
        }
    }
}
