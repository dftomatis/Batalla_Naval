using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class Tablero
    {
        private int[,] tablero;

        public int[,] Cargar(int filas, int columnas)
        {
            tablero = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j =0; j<columnas; j++)
                {
                   
                    tablero[i,j] = 0; 
                }
                
                
            }
             CargarPortaAviones(tablero, 6, true);
             CargarPortaAviones(tablero, 6, false);
             CargarPortaAviones(tablero, 5, true);
             CargarPortaAviones(tablero, 5, false);
             CargarPortaAviones(tablero, 4, true);
             CargarPortaAviones(tablero, 4, false);
             CargarPortaAviones(tablero, 3, true);
             CargarPortaAviones(tablero, 3, false);
             CargarPortaAviones(tablero, 2, true);
             CargarPortaAviones(tablero, 2, false);
            
            return tablero;
        }

        public void CargarPortaAviones(int[,] tableroParaCargar, int barco, bool vertical)
        {
            int total_filas = tableroParaCargar.GetLength(0);
            int total_columnas = tableroParaCargar.GetLength(1);
            var aleatoria = new Random();
            int fila = aleatoria.Next(0, total_filas);
            int columna = aleatoria.Next(0, total_columnas);
            int fila_aux=0;
            int columna_aux = 0;
            Boolean bandera = false;
            

            if (vertical)
            {
                while ( bandera == false)
                {
                    fila = aleatoria.Next(0, total_filas);
                    columna = aleatoria.Next(0, total_columnas);
                    while (total_filas - fila <= barco)
                    {
                        fila = aleatoria.Next(0, total_filas);
                    }
                    fila_aux = fila;
                    for (int i = 0; i < barco; i++)
                    {
                        
                        if (tableroParaCargar[fila_aux, columna] == 1 || tableroParaCargar[fila_aux, columna] == 2)
                        {
                            bandera = false;
                            break;
                        }
                        else
                        {
                            bandera = true;
                        }
                        fila_aux += 1;
                    }
                }
                if (fila != 0)
                {
                    tableroParaCargar[fila - 1, columna] = 2;
                }
                for (int i = 0; i < barco; i++)
                {

                    tableroParaCargar[fila, columna] = 1;
                    if (columna != 0)
                    { 
                        tableroParaCargar[fila, columna - 1] = 2;
                    }
                    if (columna + 1 < total_columnas)
                    {
                        tableroParaCargar[fila, columna + 1] = 2;
                    }
                    fila += 1;
                }
                if (fila != total_filas)
                {
                    tableroParaCargar[fila , columna] = 2;
                }
                
            }
            else
            {
                while (bandera == false)
                {
                    fila = aleatoria.Next(0, total_filas);
                    columna = aleatoria.Next(0, total_columnas);
                    while(total_columnas - columna <= barco)
                    {
                        columna = aleatoria.Next(0, total_columnas);
                    }
                    columna_aux = columna;
                    for (int i = 0; i < barco; i++)
                    {
                        
                        if (tableroParaCargar[fila, columna_aux] == 1 || tableroParaCargar[fila, columna_aux] == 2)
                        {
                            bandera = false;
                            break;
                        }
                        else
                        {
                            bandera = true;
                        }
                        columna_aux += 1;
                    }
                }
                if (columna != 0)
                {
                    tableroParaCargar[fila, columna-1] = 2;
                }
                for (int i = 0; i < barco; i++)
                {
                    tableroParaCargar[fila, columna] = 1;
                    if (fila != 0)
                    {
                    tableroParaCargar[fila-1, columna] = 2;
                    }
                    if (fila + 1 < total_filas)
                    {
                        tableroParaCargar[fila + 1, columna] = 2;
                    }
                    columna += 1;
                }
                if (columna  != total_columnas)
                {
                    tableroParaCargar[fila, columna] = 2;
                }
               
            }
        }

    }
}
