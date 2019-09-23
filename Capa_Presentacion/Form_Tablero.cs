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

        int nfilas;
        int ncolumnas;
        int[,] vector1;
        int[,] vector2;
        EstrategiaA estraA_P1;
        EstrategiaA estraA_P2;
        int Player1DisparosExitosos;
        int Player1DisparosFallados;
        int Player1Intentos;
        int Player2DisparosExitosos;
        int Player2DisparosFallados;
        int Player2Intentos;
        Boolean ganador;
        



        public Form_Tablero()
        {
            InitializeComponent();
            btn_P1Disparar.Enabled = false;
            btn_P2Disparar.Enabled = false;
            btnP1SelectEstrategia.Enabled = false;
            btnP2SelectEstrategia.Enabled = false;
            btn_Terminar.Enabled = false;
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
                btn_Terminar.Enabled = true;
            }
            
        }

        private void Btn_P1Disparar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] disparo = new int[2];
            disparo = estraA_P1.disparar(rnd);

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
                ganador = true;
                MessageBox.Show("Jugador 1 Ganaste! en " + Player1Intentos.ToString() + " intentos");
                btn_P1Disparar.Enabled = false;
                btn_P2Disparar.Enabled = false;
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
                btn_Terminar.Enabled = true;
            }
            
        }

        private void Btn_P2Disparar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] disparo = new int[2];
            disparo = estraA_P2.disparar(rnd);

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
                ganador = true;
                MessageBox.Show("Jugador 2 Ganaste! en " + Player2Intentos.ToString() + " intentos");
                btn_P1Disparar.Enabled = false;
                btn_P2Disparar.Enabled = false;
            }
        }

        private void Btn_Terminar_Click(object sender, EventArgs e)
        {
            btn_Terminar.Enabled = false;
            while (!ganador)
            {
                if (btn_P1Disparar.Enabled == true)
                {
                    while (btn_P1Disparar.Enabled)
                    {
                        btn_P1Disparar.PerformClick();
                    }
                }
                else
                {
                    while (btn_P2Disparar.Enabled)
                    {
                        btn_P2Disparar.PerformClick();
                    }
                }
            }
            
        }

        private void Btn_NuevaPartida_Click(object sender, EventArgs e)
        {
            Player1DisparosExitosos = 0;
            Player1DisparosFallados = 0;
            Player1Intentos = 0;
            Player2DisparosExitosos = 0;
            Player2DisparosFallados = 0;
            Player2Intentos = 0;
            ganador = false;
            estraA_P1 = new EstrategiaA();
            estraA_P2 = new EstrategiaA();
            nfilas = 10;
            ncolumnas = 10;
            vector1 = new int[10, 10];
            vector2 = new int[10, 10];
            dataGridView_Tablero_1.Rows.Clear();
            dataGridView_Tablero_1.Columns.Clear();
            dataGridView_Tablero_1.Refresh();
            dataGridView_Tablero_2.Rows.Clear();
            dataGridView_Tablero_2.Columns.Clear();
            dataGridView_Tablero_2.Refresh();
            Cargar_Grilla(nfilas, ncolumnas, dataGridView_Tablero_1, 1);
            for (int t = 0; t < 10000000; t++)
            { }
            Cargar_Grilla(nfilas, ncolumnas, dataGridView_Tablero_2, 2);
            btn_P1Disparar.Enabled = false;
            btn_P2Disparar.Enabled = false;
            btnP2SelectEstrategia.Enabled = true;
            btnP1SelectEstrategia.Enabled = true;
            btn_Terminar.Enabled = false;
            
        }
    }
}
    

