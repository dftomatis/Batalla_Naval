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

        int nfilas = 10;
        int ncolumnas = 10;
        int[,] vector1= new int[10, 10];
        int[,] vector2= new int[10, 10];
        EstrategiaA estraA_P1 = new EstrategiaA();
        EstrategiaA estraA_P2 = new EstrategiaA();
        int Player1DisparosExitosos;
        int Player1DisparosFallados;
        int Player1Intentos;
        int Player2DisparosExitosos;
        int Player2DisparosFallados;
        int Player2Intentos;



        public Form_Tablero()
        {
            InitializeComponent();
            Cargar_Grilla(nfilas, ncolumnas, dataGridView_Tablero_1,1);
            for (int t = 0; t < 10000000; t++)
            { }
            Cargar_Grilla(nfilas, ncolumnas, dataGridView_Tablero_2,2);
            btn_P1Disparar.Enabled = false;
            btn_P2Disparar.Enabled = false;
        }

        private void Cargar_Grilla(int filas, int columnas, DataGridView tablero,int jugador)
        {
            Barco b = new Barco();
            Tablero t = new Tablero();
            int[,] vector = new int[filas, columnas];
            vector = t.Cargar(filas, columnas);
            DataGridView panel = tablero;


            if (jugador==1)
            {
                vector1 = vector;
            }
            else
            {
                vector2 = vector;
            }

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
        private Boolean ActualizarGrilla(int jugador,int[] disparo)
        {
            Boolean acierto;

            if (jugador == 1)
            {
                if (disparo[0] == -1 && disparo[1] == -1)
                {
                    MessageBox.Show("Lo siento. No hay mas disparos.");
                    acierto = false;
                }
                else
                {
                    if (vector2[disparo[0], disparo[1]] > 1 && vector2[disparo[0], disparo[1]] < 7)
                    {
                        acierto = true;
                        dataGridView_Tablero_2.Rows[disparo[0]].Cells[disparo[1]].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        acierto = false;
                        dataGridView_Tablero_2.Rows[disparo[0]].Cells[disparo[1]].Style.BackColor = Color.Yellow;
                    }

                }
                return acierto;
            }
            else
            {
                if (disparo[0] == -1 && disparo[1] == -1)
                {
                    MessageBox.Show("Lo siento. No hay mas disparos.");
                    acierto = false;
                }
                else
                {
                    if (vector1[disparo[0], disparo[1]] > 1 && vector1[disparo[0], disparo[1]] < 7)
                    {
                        acierto = true;
                        dataGridView_Tablero_1.Rows[disparo[0]].Cells[disparo[1]].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        acierto = false;
                        dataGridView_Tablero_1.Rows[disparo[0]].Cells[disparo[1]].Style.BackColor = Color.Yellow;
                    }

                }
                return acierto;
            }
        }

        private void PasarVectorAEstrategia(int[,] vector)
        {

        }







        private void Form_Tablero_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView_Tablero_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void BtnSelectEstrategia_Click(object sender, EventArgs e)
        {
            estraA_P1.recibirVector(vector2);
            btnP1SelectEstrategia.Enabled = false;
            if (btnP2SelectEstrategia.Enabled == false)
            {
                btn_P1Disparar.Enabled = true;
                btn_P2Disparar.Enabled = true;
            }
            
        }

        private void Btn_P1Disparar_Click(object sender, EventArgs e)
        {

            int[] disparo = new int[2];
            disparo = estraA_P1.disparar();

            if (this.ActualizarGrilla(1, disparo))
            {
                Player1DisparosExitosos++;
                btn_P1Disparar.Enabled = true;
                btn_P2Disparar.Enabled = false;
            }
            else
            {
                Player1DisparosFallados++;
                btn_P1Disparar.Enabled = false;
                btn_P2Disparar.Enabled = true;
            }

            Player1Intentos++;
            if (Player1DisparosExitosos == 40)
            {
                MessageBox.Show("Jugador 1 Ganaste! en " + Player1Intentos.ToString() + " intentos");
            }
        }

        private void BtnP2SelectEstrategia_Click(object sender, EventArgs e)
        {
            estraA_P2.recibirVector(vector1);
            btnP2SelectEstrategia.Enabled = false;
            if (btnP1SelectEstrategia.Enabled == false)
            {
                btn_P1Disparar.Enabled = true;
                btn_P2Disparar.Enabled = true;
            }
            
        }

        private void Btn_P2Disparar_Click(object sender, EventArgs e)
        {
            int[] disparo = new int[2];
            disparo = estraA_P2.disparar();

            if (this.ActualizarGrilla(2, disparo))
            {
                Player2DisparosExitosos++;
                btn_P1Disparar.Enabled = false;
                btn_P2Disparar.Enabled = true;
            }
            else
            {
                Player2DisparosFallados++;
                btn_P1Disparar.Enabled = true;
                btn_P2Disparar.Enabled = false;
            }

            Player2Intentos++;
            if (Player2DisparosExitosos == 40)
            {
                MessageBox.Show("Jugador 2 Ganaste! en " + Player2Intentos.ToString() + " intentos");
            }
        }
    }
}
    

