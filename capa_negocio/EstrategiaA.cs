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

        Random aleatoria = new Random();
        int fila;
        int columna;
        int[,] tableroControl;
        int[] disparo = new int[2];
        public int[] disparar(int filas, int columnas)
        {


           

            fila = aleatoria.Next(0, filas);
            columna = aleatoria.Next(0, columnas);
            disparo[0] = fila;
            disparo[1] = columna;
            return disparo;

        }


    }
}
