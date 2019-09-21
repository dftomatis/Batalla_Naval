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
            Cargar_Grilla(100,100);
        }

        private void Cargar_Grilla(int filas, int columnas)
        {
            Tablero t = new Tablero();
            int[,] vector = new int[filas, columnas];
            vector = t.Cargar(filas, columnas);
             

            for (int i = 0; i < columnas; i++)
            {
                dataGridView_Tablero_1.Columns.Add(i.ToString(), i.ToString());
            }
            
             for (int i = 0; i < filas; i++)
             {
                 int n = dataGridView_Tablero_1.Rows.Add();
                 
       
                 for (int j = 0; j < columnas; j++)
                 {
                    if (vector[i, j] == 1)
                    {
                        dataGridView_Tablero_1.Rows[i].Cells[j].Style.BackColor = Color.Black;
                    }
                    else
                    {
                        dataGridView_Tablero_1.Rows[i].Cells[j].Style.BackColor = Color.Blue;

                    }
                 }



        }



        }
    }
}
