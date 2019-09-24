using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class EstrategiaA
    {

        //disparos aleatorios
        //necesito tener la grilla del enemigo y crear una grilla auxiliar que contenga los disparos que voy haciendo
        //se puede usar la misma grilla????

        
       
        int[,] tableroControl;
        int disparosExitosos;
        int disparosFallados;
        int intentos;
        List<int[]> listaDisparos = new List<int[]>();


        public void recibirVector(int[,] vector)//recibe el vector y lo mete en una lista
        {
            tableroControl = new int[vector.GetLength(0),vector.GetLength(1)];
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
                int index = rnd.Next(0,listaDisparos.Count);
                disparo = listaDisparos [index];
                listaDisparos.RemoveAt(index);
            }
            else
            {//cuando se acabaron los disparos me devuelve un vector de valores negativos
                disparo[0] = -1;
                disparo[1] = -1;
            }


            
            return disparo;

        }
        public void calcularIntentos(int[] disparo)
        {

            if (tableroControl[disparo[0], disparo[1]] > 1 && tableroControl[disparo[0], disparo[1]] < 7)
            {

                disparosExitosos += 1;
            }
            else
            {
                disparosFallados += 1;
            }
            intentos++;
        }

    }
}
