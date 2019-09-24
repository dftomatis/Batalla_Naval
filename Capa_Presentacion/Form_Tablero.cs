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
        Montecarlo monte_P1;
        Montecarlo monte_P2;
        int Player1DisparosExitosos;
        int Player1DisparosFallados;
        int Player1Intentos;
        int Player2DisparosExitosos;
        int Player2DisparosFallados;
        int Player2Intentos;
        Boolean ganador;
        float efectividadTiros_p1;
        float efectividadMediaTiros_p1;
        float efectividadPartidas_p1;
        float efectividadMediaPartidas_p1;
        float efectividadTiros_p2;
        float efectividadMediaTiros_p2;
        float efectividadPartidas_p2;
        float efectividadMediaPartidas_p2;




        public Form_Tablero()
        {
            InitializeComponent();
            btn_P1Disparar.Enabled = false;
            btn_P2Disparar.Enabled = false;
            btnP1SelectEstrategia.Enabled = false;
            btnP2SelectEstrategia.Enabled = false;
            btn_Terminar.Enabled = false;
            rb_Estrategia_Aleatoria.Enabled = false;
            rb_EstrategiaAleatoria2.Enabled = false;
            rb_estrategiaCaza.Enabled = false;
            rb_EstrategiaCaza2.Enabled = false;
            txtAcertadosP1.ReadOnly = true;
            txtAcertadosP2.ReadOnly = true;
           
            txtEfectividadTirosP1.ReadOnly = true;
            txtEfectividadTirosP2.ReadOnly = true;
            txtFalladosP1.ReadOnly = true;
            txtFalladosP2.ReadOnly = true;
            txtGanadasP1.ReadOnly = true;
            txtGanadasP2.ReadOnly = true;
            txtMediaPartidasP1.ReadOnly = true;
            txtMediaPartidasP2.ReadOnly = true;
            txtMediaTirosP1.ReadOnly = true;
            txtMediaTirosP2.ReadOnly = true;
            txtNroPartidaP1.ReadOnly = true;
            txtNroPartidaP2.ReadOnly = true;
            txtPerdidasP1.ReadOnly = true;
            txtPerdidasP2.ReadOnly = true;
            txtTotalTirosP1.ReadOnly = true;
            txtTotalTirosP2.ReadOnly = true;
            monte_P1 = new Montecarlo();
            monte_P2 = new Montecarlo();

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

       

        

        private void BtnSelectEstrategia_Click(object sender, EventArgs e)
        {
            if (rb_Estrategia_Aleatoria.Checked)
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
            rb_estrategiaCaza.Enabled = false;
            rb_Estrategia_Aleatoria.Enabled = false;

        }

        private void Btn_P1Disparar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] disparo = new int[2];
            disparo = estraA_P1.disparar(rnd);

            if (this.ActualizarGrilla(1, disparo))
            {
                Player1DisparosExitosos++;
                monte_P1.TirosAcertados++;
                txtAcertadosP1.Text = monte_P1.TirosAcertados.ToString();
                btn_P1Disparar.Enabled = true;
                btn_P2Disparar.Enabled = false;
            }
            else
            {
                Player1DisparosFallados++;
                monte_P1.TirosFallados++;
                txtFalladosP1.Text = monte_P1.TirosFallados.ToString();
                btn_P1Disparar.Enabled = false;
                btn_P2Disparar.Enabled = true;
            }

            Player1Intentos++;
            monte_P1.TotalTiros++;
            txtTotalTirosP1.Text = monte_P1.TotalTiros.ToString();
            if (Player1DisparosExitosos == 40)
            {
                ganador = true;
                MessageBox.Show("Jugador 1 Ganaste! en " + Player1Intentos.ToString() + " intentos");
                btn_P1Disparar.Enabled = false;
                btn_P2Disparar.Enabled = false;
                monte_P1.PartidasGanadas++;
                monte_P1.ResultadoPartidaActual = 1;
                txtGanadasP1.Text = monte_P1.PartidasGanadas.ToString();
                CalcularMontecarlo();
            }
        }

        private void BtnP2SelectEstrategia_Click(object sender, EventArgs e)
        {
            if (rb_EstrategiaAleatoria2.Checked)
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
            
            rb_EstrategiaAleatoria2.Enabled = false;
            rb_EstrategiaCaza2.Enabled = false;
        }

        private void Btn_P2Disparar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] disparo = new int[2];
            disparo = estraA_P2.disparar(rnd);

            if (this.ActualizarGrilla(2, disparo))
            {
                Player2DisparosExitosos++;
                monte_P2.TirosAcertados++;
                txtAcertadosP2.Text = monte_P2.TirosAcertados.ToString();
                btn_P1Disparar.Enabled = false;
                btn_P2Disparar.Enabled = true;
            }
            else
            {
                Player2DisparosFallados++;
                monte_P2.TirosFallados++;
                txtFalladosP2.Text = monte_P2.TirosFallados.ToString();
                btn_P1Disparar.Enabled = true;
                btn_P2Disparar.Enabled = false;
            }

            Player2Intentos++;
            monte_P2.TotalTiros++;
            txtTotalTirosP2.Text = monte_P2.TotalTiros.ToString();
            if (Player2DisparosExitosos == 40)
            {
                ganador = true;
                MessageBox.Show("Jugador 2 Ganaste! en " + Player2Intentos.ToString() + " intentos");
                btn_P1Disparar.Enabled = false;
                btn_P2Disparar.Enabled = false;
                monte_P2.PartidasGanadas++;
                monte_P2.ResultadoPartidaActual = 1;
                txtGanadasP2.Text = monte_P2.PartidasGanadas.ToString();
                CalcularMontecarlo();
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
            nfilas = 25;
            ncolumnas = 30;
            vector1 = new int[25, 30];
            vector2 = new int[25, 30];
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
            rb_Estrategia_Aleatoria.Enabled = true;
            rb_EstrategiaAleatoria2.Enabled = true;
            rb_estrategiaCaza.Enabled = true;
            rb_EstrategiaCaza2.Enabled = true;
            rb_Estrategia_Aleatoria.Checked = false;
            rb_EstrategiaAleatoria2.Checked = false;
            rb_estrategiaCaza.Checked = false;
            rb_EstrategiaCaza2.Checked = false;
            monte_P1.TirosAcertados = 0;
            monte_P2.TirosAcertados = 0;
            monte_P1.TirosFallados = 0;
            monte_P2.TirosFallados = 0;
            monte_P1.EfectividadTiros = 0;
            monte_P2.EfectividadTiros = 0;
            monte_P1.TotalTiros = 0;
            monte_P2.TotalTiros = 0;
            monte_P1.ResultadoPartidaActual = 0;
            monte_P2.ResultadoPartidaActual = 0;
            txtAcertadosP1.Text = "";
            txtAcertadosP2.Text = "";
            txtFalladosP1.Text = "";
            txtFalladosP2.Text = "";
            txtTotalTirosP1.Text = "";
            txtTotalTirosP2.Text = "";
            txtEfectividadTirosP1.Text = "";
            txtEfectividadTirosP2.Text = "";
            rb_Estrategia_Aleatoria.Checked = true;
            rb_EstrategiaAleatoria2.Checked = true;


        }



        private void CalcularMontecarlo()
        {
            monte_P1.NumeroPartidas++;
            monte_P2.NumeroPartidas++;
            monte_P1.PartidasPerdidas = monte_P1.NumeroPartidas - monte_P1.PartidasGanadas;
            monte_P2.PartidasPerdidas = monte_P2.NumeroPartidas - monte_P2.PartidasGanadas;
            efectividadTiros_p1 = monte_P1.calcularEfectividadTiros();
            efectividadTiros_p2 = monte_P2.calcularEfectividadTiros();
            efectividadMediaTiros_p1 = monte_P1.calcularEfectividadMediaTiros();
            efectividadMediaTiros_p2 = monte_P2.calcularEfectividadMediaTiros();
            efectividadMediaPartidas_p1 = monte_P1.calcularEfectividadMediaPartidas();
            efectividadMediaPartidas_p2 = monte_P2.calcularEfectividadMediaPartidas();
            CompletarDatos();

        }
        public void CompletarDatos()
        {
            txtNroPartidaP1.Text = monte_P1.NumeroPartidas.ToString();
            txtNroPartidaP2.Text = monte_P2.NumeroPartidas.ToString();
            
            txtEfectividadTirosP1.Text = efectividadTiros_p1.ToString()+"%";
            txtEfectividadTirosP2.Text = efectividadTiros_p2.ToString() + "%";
            txtMediaPartidasP1.Text = efectividadMediaPartidas_p1.ToString();
            txtMediaPartidasP2.Text = efectividadMediaPartidas_p2.ToString();
            txtMediaTirosP1.Text = efectividadMediaTiros_p1.ToString();
            txtMediaTirosP2.Text = efectividadMediaTiros_p2.ToString();
            txtPerdidasP1.Text = monte_P1.PartidasPerdidas.ToString() ;
            txtPerdidasP2.Text = monte_P2.PartidasPerdidas.ToString();
            
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }
    }
}
    

