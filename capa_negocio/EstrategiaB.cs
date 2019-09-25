using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class EstrategiaB
    {

        List<int[]> tirosPotenciales = new List<int[]>();
        Random rand = new Random();
        int[,] tableroControl;
        int columns;// numero de columnas
        int rows;//numero de filas
        Boolean hayTiros = false; //para que use target en vez de hunt()
        List<int[]> listaDisparos = new List<int[]>();

        public void recibirVector(int[,] vector)//recibe el vector y lo mete en una lista
        {
            tableroControl = new int[vector.GetLength(0), vector.GetLength(1)];
            tableroControl = vector;

            for (int i = 0; i < tableroControl.GetLength(0); i++)
            {
                for (int j = 0; j < tableroControl.GetLength(1); j++)
                {
                    int[] disparo = new int[2];
                    disparo[0] = i;
                    disparo[1] = j;
                    listaDisparos.Add(disparo);
                }
            }
        }

        public int[] disparar(Random rnd)//dispara aleatoreamente desde la lista y elimina el elemento ya utilizado en cada disparo
        {
            int[] disparo = new int[2];

            if (listaDisparos.Count != 0)
            {

                if (hayTiros)
                {
                    disparo = tirosPotenciales[0];
                    tirosPotenciales.Remove(disparo);
                    listaDisparos.Remove(disparo);
                    if (tirosPotenciales.Count() == 0)
                    {
                        hayTiros = false;
                    }
                }
                else
                {
                    int index = rnd.Next(0, listaDisparos.Count);
                    disparo = listaDisparos[index];
                    listaDisparos.RemoveAt(index);
                }
                
                
            }
            else
            {//cuando se acabaron los disparos me devuelve un vector de valores negativos
                disparo[0] = -1;
                disparo[1] = -1;
            }



            return disparo;

        }
        
        public void cargarListaTirosPotenciales(int[] tiroPegado) //este metodo se dispara cuando hunt() no fue AGUA, 
                                                                  //carga los puntos alrededor (arriba abajo derecha izquierda)
                                                                  //, es decir los potenciales disparos
        {
            int[] tiro_aux = new int[2];// este lo uso para ir metiendo los tiros en la lista, y lo voy sobreescribiendo            
            //el primer control de cada IF es para saber si esta fuera del tamaño de la matrix
            if ((tiroPegado[0] + 1) < tableroControl.GetLength(0)) // Derecha
            {

                tiro_aux[0] = tiroPegado[0] + 1;
                tiro_aux[1] = tiroPegado[1];
                if (listaDisparos.Contains(tiro_aux))
                {
                    tirosPotenciales.Add(tiro_aux);
                    hayTiros = true;
                }
                
                
            }
            if ((tiroPegado[1] + 1) < tableroControl.GetLength(1)) //Abajo
            {
                tiro_aux[0] = tiroPegado[0];
                tiro_aux[1] = tiroPegado[1] + 1;
                if (listaDisparos.Contains(tiro_aux))
                {
                    tirosPotenciales.Add(tiro_aux);
                    hayTiros = true;
                }
            }
            if ((tiroPegado[0] - 1) >= 0)//Izquierda
            {
                tiro_aux[0] = tiroPegado[0] - 1;
                tiro_aux[1] = tiroPegado[1];
                if (listaDisparos.Contains(tiro_aux))
                {
                    tirosPotenciales.Add(tiro_aux);
                    hayTiros = true;
                }
            }
            if ((tiroPegado[1] - 1) >= 0)//Arriba
            {
                tiro_aux[0] = tiroPegado[0];
                tiro_aux[1] = tiroPegado[1] - 1;
                if (listaDisparos.Contains(tiro_aux))
                {
                    tirosPotenciales.Add(tiro_aux);
                    hayTiros = true;
                }
            }
        }
        
    }
}

