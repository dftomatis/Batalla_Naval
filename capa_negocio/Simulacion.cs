using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class Simulacion
    {


        int filas=10;
        int columnas=10;
        int[,] vector1;
        int[,] vector2;
        EstrategiaA estraA_P1;
        EstrategiaA estraA_P2;
        Montecarlo monte_P1;
        Montecarlo monte_P2;
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

        public void simular()
        {
            for (int i = 0; i < 5; i++)
            {
                partidas++;
                estraA_P1 = new EstrategiaA();
                estraA_P2 = new EstrategiaA();
                t = new Tablero();
                vector1 = new int[filas, columnas];
                vector1 = t.Cargar(filas, columnas);
                for (int t = 0; t < 10000; t++)
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
                    player1Intentos++;
                    if (vector2[disparo[0], disparo[1]] > 1 && vector2[disparo[0], disparo[1]] < 7)
                    {
                        turnoP1 = true;
                        player1DisparosExitosos++;
                    }
                    else
                    {
                        turnoP1 = false;
                        player1DisparosFallados++;
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
                    player2Intentos++;
                    if (vector1[disparo[0], disparo[1]] > 1 && vector1[disparo[0], disparo[1]] < 7)
                    {
                        turnoP2 = true;
                        player2DisparosExitosos++;
                    }
                    else
                    {
                        turnoP2 = false;
                        player2DisparosFallados++;
                    }

                }
                
            }
        }

    }
}
