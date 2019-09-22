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
            Cargar_Grilla(25, 25, dataGridView_Tablero_1);
            Cargar_Grilla(25, 25, dataGridView_Tablero_2);
        }

        private void Cargar_Grilla(int filas, int columnas, DataGridView tablero)
        {
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
                    if (vector[i, j] == 1)
                    {
                        panel.Rows[i].Cells[j].Style.BackColor = Color.Brown;
                    }
                    else
                    {
                        panel.Rows[i].Cells[j].Style.BackColor = Color.Aquamarine;

                    }
                 }



        }



        }

        private void Form_Tablero_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView_Tablero_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
