﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class Simulacion
    {


        int filas=100;
        int columnas=100;
        int[,] vector1;
        int[,] vector2;
        EstrategiaA estraA_P1;
        EstrategiaA estraA_P2;
        Montecarlo sim_monte_P1=new Montecarlo();
        Montecarlo sim_monte_P2= new Montecarlo();
        Barco b;
        Tablero t;
        Boolean partido = true;
        Boolean turno=true;
        Boolean turnoP1 = true;
        Boolean turnoP2 = false;
        public int player1DisparosExitosos=0;
        public int player1DisparosFallados=0;
        public int player1Intentos =0;
        public int player2DisparosExitosos=0;
        public int player2DisparosFallados =0;
        public int player2Intentos=0;
        Boolean ganador;
        float efectividadTiros_p1=0;
        float efectividadMediaTiros_p1=0;
        float efectividadPartidas_p1=0;
        float efectividadMediaPartidas_p1=0;
        float efectividadTiros_p2=0;
        float efectividadMediaTiros_p2=0;
        float efectividadPartidas_p2=0;
        float efectividadMediaPartidas_p2=0;
        public int partidas = 0;
        int disparosOK1 = 0;
        int disparosOK2 = 0;

        public void simular()
        {
            for (int i = 0; i < 1000; i++)
            {
                sim_monte_P1.ResultadoPartidaActual = 0;
                sim_monte_P2.ResultadoPartidaActual = 0;
                disparosOK1 = 0;
                disparosOK2 = 0;
                turnoP1 = true;
                partido = true;
                partidas++;
                estraA_P1 = new EstrategiaA();
                estraA_P2 = new EstrategiaA();
                t = new Tablero();
                vector1 = new int[filas, columnas];
                vector1 = t.Cargar(filas, columnas);
                for (int t = 0; t < 100000; t++)
                { }
                vector2 = new int[filas, columnas];
                vector2 = t.Cargar(filas, columnas);
                estraA_P1.recibirVector(vector2);
                estraA_P2.recibirVector(vector1);

                while (partido)
                {
                    if (turnoP1)
                    {
                        while (turnoP1)
                        {
                            Disparar(1);

                        }
                    }
                    else
                    {
                        while (turnoP2)
                        {
                            Disparar(2);

                        }
                    }
                }
                CalcularMontecarlo();

            }
            
        }

        private void Disparar(int jugador)
        {
            Random rnd = new Random();
            int[] disparo = new int[2];
            if (jugador == 1)
            {
                disparo = estraA_P1.disparar(rnd);
            }
            else
            {
                disparo = estraA_P2.disparar(rnd);

            }
             ActualizarGrilla(jugador, disparo);
            
        }

        private void ActualizarGrilla(int jugador, int[] disparo)
        {
            

            if (jugador == 1)
            {
                
                if (disparo[0] == -1 && disparo[1] == -1)
                {
                    
                    partido = false;
                }
                else
                {
                    sim_monte_P1.TotalTiros++;
                    if (vector2[disparo[0], disparo[1]] > 1 && vector2[disparo[0], disparo[1]] < 7)
                    {
                        turnoP1 = true;
                        sim_monte_P1.TirosAcertados++;
                        disparosOK1++;
                        
                    }
                    else
                    {
                        turnoP1 = false;
                        turnoP2 = true;
                        sim_monte_P1.TirosFallados++;
                    }

                }
               
                
            }
            else
            {
                if (disparo[0] == -1 && disparo[1] == -1)
                {
                    
                    
                    partido = false;
                }
                else
                {
                    sim_monte_P2.TotalTiros++;
                    if (vector1[disparo[0], disparo[1]] > 1 && vector1[disparo[0], disparo[1]] < 7)
                    {
                        turnoP2 = true;
                        sim_monte_P2.TirosAcertados++;
                        disparosOK2++;
                    }
                    else
                    {
                        turnoP2 = false;
                        turnoP1 = true;
                        sim_monte_P2.TirosFallados++;
                    }

                }
                
            }
            if (disparosOK1 == 40)
            {
                sim_monte_P1.PartidasGanadas++;
                sim_monte_P1.ResultadoPartidaActual = 1;
                turnoP2 = false;
                turnoP1 = false;
                partido = false;
            }
            else
            {
                if (disparosOK2 == 40)
                {
                    sim_monte_P2.PartidasGanadas++;
                    sim_monte_P2.ResultadoPartidaActual = 1;
                    turnoP2 = false;
                    turnoP1 = false;
                    partido = false;
                }
            }
           
        }



        private void CalcularMontecarlo()
        {
            sim_monte_P1.NumeroPartidas++;
            sim_monte_P2.NumeroPartidas++;
            sim_monte_P1.PartidasPerdidas = sim_monte_P1.NumeroPartidas - sim_monte_P1.PartidasGanadas;
            sim_monte_P2.PartidasPerdidas = sim_monte_P2.NumeroPartidas - sim_monte_P2.PartidasGanadas;
            efectividadTiros_p1 = sim_monte_P1.calcularEfectividadTiros();
            efectividadTiros_p2 = sim_monte_P2.calcularEfectividadTiros();
            efectividadMediaTiros_p1 = sim_monte_P1.calcularEfectividadMediaTiros();
            efectividadMediaTiros_p2 = sim_monte_P2.calcularEfectividadMediaTiros();
            efectividadMediaPartidas_p1 = sim_monte_P1.calcularEfectividadMediaPartidas();
            efectividadMediaPartidas_p2 = sim_monte_P2.calcularEfectividadMediaPartidas();
            

        }

    }
}
