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
    public partial class Form1 : Form
    {
        public static int N = 2;      
        int[,] numbers = new int[filas, columnas];
        public static int filas = 10;
        public static int columnas = 10;
        public static double minas = N;
        DateTime tiempo;
        int banderas;
        int contador;
       public static string tiempoenterminar;
                    

        public void iniciar()
        {
                       
            Random r = new Random();

           // for (int i = 0; i < minas; i++)
            int contador = 0;            
            while (contador < minas)
                
            {
            
                int y = r.Next(0, columnas - 1);
                int x = r.Next(0, filas - 1);
                if (numbers[x, y] != -1)
                {
                    numbers[x, y] = -1; 
                    contador = contador + 1;
                }
            }
            for (int x = 0; x < filas; x++)
            {
                for (int y = 0; y < columnas; y++)
                {
                    if (numbers[x, y] == -1)
                    {
                        CalcularAdyacentesMinas(x, y);
                    }
                }

            }

        }


        private void CalcularAdyacentesMinas(int x, int y)
        {
            if (x > 0 && y > 0 && numbers[x - 1, y - 1] != -1)
            {
                numbers[x - 1, y - 1] = numbers[x - 1, y - 1] + 1;

            }

            if (x > 0 && numbers[x - 1, y] != -1)
            {
                numbers[x - 1, y] = numbers[x - 1, y] + 1;
            }

            if (x > 0 && y < columnas - 1 && numbers[x - 1, y + 1] != -1)
            {
                numbers[x - 1, y + 1] = numbers[x - 1, y + 1] + 1;
            }

            if (y > 0 && numbers[x, y - 1] != -1)
            {
                numbers[x, y - 1] = numbers[x, y - 1] + 1;
            }

            if (y < columnas - 1 && numbers[x, y + 1] != -1)
            {
                numbers[x, y + 1] = numbers[x, y + 1] + 1;
            }

            if (x < filas - 1 && y > 0 && numbers[x + 1, y - 1] != -1)
            {
                numbers[x + 1, y - 1] = numbers[x + 1, y - 1] + 1;
            }

            if (x < filas - 1 && numbers[x + 1, y] != -1)
            {
                numbers[x + 1, y] = numbers[x + 1, y] + 1;
            }

            if (x < filas - 1 && y < columnas - 1 && numbers[x + 1, y + 1] != -1)
            {
                numbers[x + 1, y + 1] = numbers[x + 1, y + 1] + 1;
            }



        }

        public Form1()
        {
            InitializeComponent();
            iniciar();

            tableLayoutPanel1.RowCount = filas;
            tableLayoutPanel1.ColumnCount = columnas;

            //tableLayoutPanel1.Width = 3 * 50;
            //tableLayoutPanel1.Height = 5 * 50;            
            ponerbotones();

        }

        private void funcionreloj (object sender, EventArgs e)
        {
            
            tiempo = tiempo.AddSeconds(1);



            minutos.Text = tiempo.Second.ToString();
        }
             
             public void play_Click(object sender, EventArgs e)
        {
            
            //tiempo = DateTime.Now;
          
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(funcionreloj);
            timer1.Start();
            tableLayoutPanel1.Visible = true; 
        }

             private void pause_Click(object sender, EventArgs e)
             {
                 timer1.Stop();
             }

        private void stop_Click(object sender, EventArgs e)
        {
            minutos.Text = "00";
            timer1.Stop();
            //Application.ExitThread();    
        }

        private void ponerbotones()
        {


            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Button btn1 = new Button();
                    btn1.Size = new System.Drawing.Size(50, 50);
                    btn1.Name = "boton_" + i + "_" + j;
                    btn1.BackColor = Color.White;
                    //btn1.Text = numbers[i, j].ToString();
                    btn1.ForeColor = Color.Black;
                    btn1.Anchor = AnchorStyles.Top;
                    tableLayoutPanel1.Controls.Add(btn1);
                    btn1.Tag = i + ";" + j;
                    // btn1.Click += new EventHandler(btn1_Click);
                    btn1.MouseDown += new MouseEventHandler(btn1_Click);
                    tableLayoutPanel1.Visible = false;
                }

            }

        }

        //void btn1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}     

        

         //void btn1_Click(object sender, EventArgs e)
        void btn1_Click(object sender, MouseEventArgs e)
        {
            

                //throw new NotImplementedException();
                Button btnActual = (sender as Button);
                string btn1 = btnActual.Name;

                string tag = btnActual.Tag as string;

                string[] result = tag.Split(';');
                int hola = numbers[Convert.ToInt32(result[0]), Convert.ToInt32(result[1])];


            if (e.Button == MouseButtons.Left)
            {
                switch (hola)
                {
                    case -1:
                        //lamar a funcion finde juego
                        btnActual.Text = "*";
                        MessageBox.Show(" lo siento has perdido");   
                        Application.ExitThread();

                        break;
                    case 0:
                        //llamar a la funcion recursiva
                        recur(Convert.ToInt32(result[0]), Convert.ToInt32(result[1]));

                        break;

                    default:
                        btnActual.Text = hola.ToString();
                        break;
                }

            }

            if (e.Button == MouseButtons.Right)
            {

                if (hola == -1)
                {
                    banderas++;
                }
                if (hola != -1)
                {
                    contador++;
                }

                btnActual.Text = "%";
                //if (banderas == minas && contador == 0)                  
                //    MessageBox.Show("Enhorabuena has ganado ");
            }

            if (e.Button == MouseButtons.Left)
            {
                if (hola != -1 && btnActual.Text != "-1" && contador > 0)
                    contador--;

                //if (banderas == minas && contador == 0)
                //    //tableLayoutPanel1.Visible = true;
                //    MessageBox.Show("Enhorabuena has ganado ");
            }
            if (banderas == minas && contador == 0)
            //tableLayoutPanel1.Visible = true;
            {
                timer1.Stop(); 
                MessageBox.Show("Enhorabuena has ganado ");  
                tiempoenterminar  = minutos.Text.ToString();
               
                 final formularioNuevo = new final();
                 formularioNuevo.Show();
            }
        }
        

        private void fin(object sender, EventArgs e)
        {
            
        }

        private void recur(int x, int y)
        {
          Control[] botonARRAY =  tableLayoutPanel1.Controls.Find("boton_" + (x).ToString() + "_" + (y).ToString(), false);
          Button boton = (botonARRAY[0] as Button); 

           if (String.IsNullOrEmpty(boton.Text))
           {
          boton.Text = numbers[x, y].ToString();

            if (x > 0 && y > 0)
            {


                if (numbers[x - 1, y - 1] == 0)
                {
                    //mostrar el valor de eses botom
                    recur(x - 1, y - 1);
                }
                else
                {
                    botonARRAY = tableLayoutPanel1.Controls.Find("boton_" + (x - 1).ToString() + "_" + (y - 1).ToString(), false);
                    boton = (botonARRAY[0] as Button);
                    boton.Text = numbers[x - 1, y - 1].ToString(); 
                }
            }

            if (x > 0)
            {
                
                if (numbers[x - 1, y] == 0)
                {
                   
                    //mostrar
                    recur(x - 1, y);
                }
                else
                {
                    botonARRAY = tableLayoutPanel1.Controls.Find("boton_" + (x - 1).ToString() + "_" + (y).ToString(), false);
                    boton = (botonARRAY[0] as Button);
                    boton.Text = numbers[x - 1, y].ToString();
                }
            }

            if (x > 0 && y < columnas -1)
            {
                if (numbers[x - 1, y + 1] == 0)
                {
                    //Mostrar valor boton
                    recur(x - 1, y + 1);
                }
                else
                {
                    botonARRAY = tableLayoutPanel1.Controls.Find("boton_" + (x - 1).ToString() + "_" + (y+1).ToString(), false);
                    boton = (botonARRAY[0] as Button);
                    boton.Text = numbers[x - 1, y+1].ToString();
                }
            }

            if (y > 0)
            {
                if (numbers[x, y - 1] == 0)
                {
                    //mostar
                    recur(x, y - 1);
                }
                else               
                {
                    //mostrar
                    botonARRAY = tableLayoutPanel1.Controls.Find("boton_" + (x).ToString() + "_" + (y - 1).ToString(), false);
                    boton = (botonARRAY[0] as Button);
                    boton.Text = numbers[x, y - 1].ToString(); 
                }
            }
            if (y < columnas - 1)
            {
                if (numbers[x, y + 1] == 0)
                {
                    // mostrar
                    recur(x, y + 1);
                }
                else
                {
                    botonARRAY = tableLayoutPanel1.Controls.Find("boton_" + (x).ToString() + "_" + (y+1).ToString(), false);
                    boton = (botonARRAY[0] as Button);
                    boton.Text = numbers[x, y+1].ToString();
                }
            }

            if (x < filas - 1 && y > 0)
            {
                if (numbers[x + 1, y - 1] == 0)
                {
                    //mostrar
                    recur(x + 1, y - 1);
                }
                else
                {
                    botonARRAY = tableLayoutPanel1.Controls.Find("boton_" + (x+1).ToString() + "_" + (y - 1).ToString(), false);
                    boton = (botonARRAY[0] as Button);
                    boton.Text = numbers[x+1, y - 1].ToString();
                }

            }

            if (x < filas - 1)
            {
                if (numbers[x + 1, y] == 0)
                {
                    //mostrar
                    recur(x + 1, y);
                }
                else
                {
                    botonARRAY = tableLayoutPanel1.Controls.Find("boton_" + (x+1).ToString() + "_" + (y).ToString(), false);
                    boton = (botonARRAY[0] as Button);
                    boton.Text = numbers[x+1, y ].ToString();
                }
            }

            if (x < filas - 1 && y < columnas - 1)
            {
                if (numbers[x + 1, y + 1] == 0)
                {
                    //mostrar
                    recur(x + 1, y + 1);
                }
                else
                {
                    botonARRAY = tableLayoutPanel1.Controls.Find("boton_" + (x+1).ToString() + "_" + (y + 1).ToString(), false);
                    boton = (botonARRAY[0] as Button);
                    boton.Text = numbers[x+1, y + 1].ToString();
                }
            }
            
               // CONTADOR, TIEMPO, MARCAR MINAS
           }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void historialPuntuacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historialPuntuacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buscaminasDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'buscaminasDataSet.HistorialPuntuacion' Puede moverla o quitarla según sea necesario.
            this.historialPuntuacionTableAdapter.Fill(this.buscaminasDataSet.HistorialPuntuacion);

        }


       

      
        

        

       
       

    }

    //public partial class Form2 : Form
    //{

    //}
}

