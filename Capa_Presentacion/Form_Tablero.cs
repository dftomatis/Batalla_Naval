using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Capa_Presentacion
{
    public partial class Form_Tablero : Form
    {





        public Form_Tablero()
        {
            InitializeComponent();
            Cargar_Grilla(30, 30, dataGridView_Tablero_1);
            for (int t = 0; t < 10000000; t++)
            { }
            Cargar_Grilla(30, 30, dataGridView_Tablero_2);
        }

        private void Cargar_Grilla(int filas, int columnas, DataGridView tablero)
        {
            Barco b = new Barco();
            Tablero t = new Tablero();
            int[,] vector = new int[filas, columnas];
            vector = t.Cargar(filas, columnas);
            DataGridView panel = tablero;


            for (int i = 0; i < columnas; i++)
            {
                panel.Columns.Add(i.ToString(), i.ToString());
            }

            for (int i = 0; i < filas; i++)
            {
                int n = panel.Rows.Add();


                for (int j = 0; j < columnas; j++)
                {
                    switch (vector[i, j])
                    {
                        case 2:
                            panel.Rows[i].Cells[j].Style.BackColor = Color.Black;
                            break;
                        case 3:
                            panel.Rows[i].Cells[j].Style.BackColor = Color.LimeGreen;
                            break;
                        case 4:
                            panel.Rows[i].Cells[j].Style.BackColor = Color.Maroon;
                            break;
                        case 5:
                            panel.Rows[i].Cells[j].Style.BackColor = Color.DarkOliveGreen;
                            break;
                        case 6:
                            panel.Rows[i].Cells[j].Style.BackColor = Color.Indigo;
                            break;
                        default:
                            panel.Rows[i].Cells[j].Style.BackColor = Color.Aquamarine;
                            break;


                    }


                }

            }



        }



        //deberia ir el llamado a las estrategias 



       // private boolean Actulaizar_Grilla(fila i, columna j)






        private void Form_Tablero_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView_Tablero_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //deshabilita radiobutton (estrategias para seleccionar)
            //aca va el llamado a la estrategia que se seleccionó (se le pasa por parametro el tamaño de la grilla)
            //if(actualizargrilla)
        }
    }
}
    

