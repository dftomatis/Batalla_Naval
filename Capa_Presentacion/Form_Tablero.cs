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
        EstrategiaB estraB_P1;
        EstrategiaB estraB_P2;
        Montecarlo monte_P1;
        Montecarlo monte_P2;
        int Player1DisparosExitosos;
        int Player1DisparosFallados;
        int Player1Intentos;
        int Player2DisparosExitosos;
        int Player2DisparosFallados;
        int Player2Intentos;
        Boolean ganador;
        float efectividadTiros_p1=0;
        float efectividadMediaTiros_p1;
        float efectividadPartidas_p1;
        float efectividadMediaPartidas_p1;
        float efectividadTiros_p2=0;
        float efectividadMediaTiros_p2;
        float efectividadPartidas_p2;
        float efectividadMediaPartidas_p2;
        float efectividadMedia_p1;
        float efectividadMedia_p2;
        float efectividadTirosAnteriorP1;
        float efectividadTirosAnteriorP2;
        float mediaTirosTotales_P1;
        float mediaTirosTotales_P2;
        float mediaAcertados_P1;
        float mediaAcertados_P2;
        float mediaFallados_P1;
        float mediaFallados_P2;




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
            txtNroPartidaP1.ReadOnly = true;
            txtNroPartidaP2.ReadOnly = true;
            txtPerdidasP1.ReadOnly = true;
            txtPerdidasP2.ReadOnly = true;
            txtTotalTirosP1.ReadOnly = true;
            txtTotalTirosP2.ReadOnly = true;
            txt_efectividad_Acum_P1.ReadOnly = true;
            txt_efectividad_Acum_P2.ReadOnly = true;
            txt_tiros_totales_P1.ReadOnly = true;
            txt_tiros_totales_P2.ReadOnly = true;
            txt_Acum_Acertados_P1.ReadOnly = true;
            txt_acertados_acum_P2.ReadOnly = true;
            txt_Acum_Fallados_P1.ReadOnly = true;
            txt_fallados_acum_P2.ReadOnly = true;
            monte_P1 = new Montecarlo();
            monte_P2 = new Montecarlo();

        }

        private void Cargar_Grilla(int filas, int columnas, DataGridView tablero,int jugador)
        {
            
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
            int[] aux = new int[2];
            aux = disparo;
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
            else
            {
                estraB_P1.recibirVector(vector2);
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
            if (rb_Estrategia_Aleatoria.Checked)
            {
                disparo = estraA_P1.disparar(rnd);
            }
            else
            {
                disparo = estraB_P1.disparar(rnd);
            }
            

            if (this.ActualizarGrilla(1, disparo))
            {
                Player1DisparosExitosos++;
                monte_P1.TirosAcertados++;
                if (rb_estrategiaCaza.Checked)
                {
                    estraB_P1.cargarListaTirosPotenciales(disparo);
                }
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
                MessageBox.Show("Jugador 1 Ganaste! en " + Player1Intentos.ToString() + " intentos",
                    "Fin del Partido");
                btn_P1Disparar.Enabled = false;
                btn_P2Disparar.Enabled = false;
                monte_P1.PartidasGanadas++;
                monte_P1.ResultadoPartidaActual = 1;
                
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
            else
            {
                estraB_P2.recibirVector(vector1);
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
            if (rb_EstrategiaAleatoria2.Checked)
            {
                disparo = estraA_P2.disparar(rnd);
            }
            else
            {
                disparo = estraB_P2.disparar(rnd);
            }
            

            if (this.ActualizarGrilla(2, disparo))
            {
                Player2DisparosExitosos++;
                monte_P2.TirosAcertados++;
                if (rb_EstrategiaCaza2.Checked)
                {
                    estraB_P2.cargarListaTirosPotenciales(disparo);
                }
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
                MessageBox.Show("Jugador 2 Ganaste! en " + Player2Intentos.ToString() + " intentos",
                    "Fin del Partido");
                btn_P1Disparar.Enabled = false;
                btn_P2Disparar.Enabled = false;
                monte_P2.PartidasGanadas++;
                monte_P2.ResultadoPartidaActual = 1;
                
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
            estraB_P1 = new EstrategiaB();
            estraB_P2 = new EstrategiaB();
            nfilas = 50;
            ncolumnas = 50;
            vector1 = new int[nfilas, ncolumnas];
            vector2 = new int[nfilas, ncolumnas];
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
            rb_Estrategia_Aleatoria.Checked = true;
            rb_EstrategiaAleatoria2.Checked = false;
            rb_estrategiaCaza.Checked = false;
            rb_EstrategiaCaza2.Checked = true;
            monte_P1.TirosAcertados = 0;
            monte_P2.TirosAcertados = 0;
            monte_P1.TirosFallados = 0;
            monte_P2.TirosFallados = 0;
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
           


        }



        private void CalcularMontecarlo()
        {
            monte_P1.NumeroPartidas++;
            monte_P2.NumeroPartidas++;
            monte_P1.PartidasPerdidas = monte_P1.NumeroPartidas - monte_P1.PartidasGanadas;
            monte_P2.PartidasPerdidas = monte_P2.NumeroPartidas - monte_P2.PartidasGanadas;
            efectividadTiros_p1 = monte_P1.calcularEfectividadTiros();
            efectividadTiros_p2 = monte_P2.calcularEfectividadTiros();
            efectividadMediaPartidas_p1 = monte_P1.calcularEfectividadMediaPartidas();
            efectividadMediaPartidas_p2 = monte_P2.calcularEfectividadMediaPartidas();
            efectividadMedia_p1 = monte_P1.calcularEfectividadMedia();
            efectividadMedia_p2 = monte_P2.calcularEfectividadMedia();
            mediaTirosTotales_P1=monte_P1.calcularMediaTirosTotales();
            mediaTirosTotales_P2= monte_P2.calcularMediaTirosTotales();
            mediaAcertados_P1= monte_P1.calcularMediaTirosAcertados();
            mediaAcertados_P2 = monte_P2.calcularMediaTirosAcertados();
            mediaFallados_P1= monte_P1.calcularMediaTirosFallados();
            mediaFallados_P2=monte_P2.calcularMediaTirosFallados();
            CompletarDatos();

        }
        public void CompletarDatos()
        {
            monte_P1.TotalTirosAcum += monte_P1.TotalTiros;
            monte_P1.TirosAcertadosAcum += monte_P1.TirosAcertados;
            monte_P1.TirosFalladosAcum += monte_P1.TirosFallados;
            txtGanadasP1.Text = monte_P1.PartidasGanadas.ToString();
            monte_P2.TotalTirosAcum += monte_P2.TotalTiros;
            monte_P2.TirosAcertadosAcum += monte_P2.TirosAcertados;
            monte_P2.TirosFalladosAcum += monte_P2.TirosFallados;
            txtGanadasP2.Text = monte_P2.PartidasGanadas.ToString();

            txtNroPartidaP1.Text = monte_P1.NumeroPartidas.ToString();
            txtNroPartidaP2.Text = monte_P2.NumeroPartidas.ToString();
            txtEfectividadTirosP1.Text = efectividadTiros_p1.ToString()+"%";
            efectividadTirosAnteriorP1 = efectividadTiros_p1;
            txtEfectividadTirosP2.Text = efectividadTiros_p2.ToString() + "%";
            efectividadTirosAnteriorP2 = efectividadTiros_p2;
            txtMediaPartidasP1.Text = efectividadMediaPartidas_p1.ToString();
            txtMediaPartidasP2.Text = efectividadMediaPartidas_p2.ToString();
            txtPerdidasP1.Text = monte_P1.PartidasPerdidas.ToString() ;
            txtPerdidasP2.Text = monte_P2.PartidasPerdidas.ToString();
            txt_efectividad_Acum_P1.Text = efectividadMedia_p1.ToString() + "%";
            txt_efectividad_Acum_P2.Text = efectividadMedia_p2.ToString() + "%";
            txt_tiros_totales_P1.Text = monte_P1.MediaTirosTotal.ToString();
            txt_tiros_totales_P2.Text = monte_P2.MediaTirosTotal.ToString();
            txt_Acum_Acertados_P1.Text = monte_P1.MediaTirosAcertados.ToString();
            txt_acertados_acum_P2.Text = monte_P2.MediaTirosAcertados.ToString();
            txt_Acum_Fallados_P1.Text = monte_P1.MediaTirosFallados.ToString();
            txt_fallados_acum_P2.Text= monte_P2.MediaTirosFallados.ToString();


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

        private void BtnSimular_Click(object sender, EventArgs e)
        {
            Simulacion s = new Simulacion();
            s.simular();
            string resultado;
            if (s.ganador == 0)
            {
                resultado = "Empate";
            }
            else
            {
                if(s.ganador==1)
                {
                    resultado = "Ganó el Jugador 1";
                }
                else
                {
                    resultado = "Ganó el Jugador 2";
                }
            }
            MessageBox.Show("Partidas Simuladas: " + s.partidas.ToString() +
                "\n" + "Estrategia Jugador 1: Aleatoria" +
                "\n" + "Estrategia Jugador 2: Busqueda y Caza" +
                "\n" + "Resultado: " + resultado +
                "\n" + "Estadisticas Jugador 1" +
                "\n" + "Partidas Ganadas: " + s.sim_monte_P1.PartidasGanadas +
                "\n" + "Partidas Perdidas: " + s.sim_monte_P1.PartidasPerdidas +
                "\n" + "Promedio Partidas Ganadas: " + s.sim_monte_P1.EfectividadMediaPartidas+
                "\n" + "Promedio Tiros por Partida: " + s.sim_monte_P1.MediaTirosTotal+
                "\n" + "Promedio Tiros Acertados por Partida: " + s.sim_monte_P1.MediaTirosAcertados+
                "\n" + "Promedio Tiros Fallados por Partida: " + s.sim_monte_P1.MediaTirosFallados+
                "\n" + "Promedio Efectividad: " + s.sim_monte_P1.EfectividadMediaPartidas+"%"+
                "\n" + "Estadisticas Jugador 2" +
                "\n" + "Partidas Ganadas: " + s.sim_monte_P2.PartidasGanadas +
                "\n" + "Partidas Perdidas: " + s.sim_monte_P2.PartidasPerdidas +
                "\n" + "Promedio Partidas Ganadas: " + s.sim_monte_P2.EfectividadMediaPartidas +
                "\n" + "Promedio Tiros por Partida: " + s.sim_monte_P2.MediaTirosTotal +
                "\n" + "Promedio Tiros Acertados por Partida: " + s.sim_monte_P2.MediaTirosAcertados +
                "\n" + "Promedio Tiros Fallados por Partida: " + s.sim_monte_P2.MediaTirosFallados +
                "\n" + "Promedio Efectividad: " + s.sim_monte_P2.EfectividadMediaPartidas + "%" + "\n",
                "Resultado de Simulacion Automática") ;

        }

        private void Label16_Click_1(object sender, EventArgs e)
        {

        }
    }
}
    

