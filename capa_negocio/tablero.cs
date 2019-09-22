using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class Tablero
    {
        Random aleatoria = new Random();
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
            CargarPortaAviones(tablero, 6);
            CargarPortaAviones(tablero, 6);
            CargarPortaAviones(tablero, 5);
            CargarPortaAviones(tablero, 5);
            CargarPortaAviones(tablero, 4);
            CargarPortaAviones(tablero, 4);
            CargarPortaAviones(tablero, 3);
            CargarPortaAviones(tablero, 3);
            CargarPortaAviones(tablero, 2);
            CargarPortaAviones(tablero, 2);

            return tablero;
        }

        public void CargarPortaAviones(int[,] tableroParaCargar, int barco)
        {
            int total_filas = tableroParaCargar.GetLength(0);
            int total_columnas = tableroParaCargar.GetLength(1);
            int fila=0;
            int columna=0;
            int fila_aux=0;
            int columna_aux = 0;
            double orden = (int)(aleatoria.NextDouble() * 1000000);
            double limit = aleatoria.NextDouble() * 10;
            Boolean bandera = false;

            
            if (orden % 2 == 0)
            {
                while ( bandera == false)
                {
                    fila = aleatoria.Next(0, total_filas);
                    columna = aleatoria.Next(0, total_columnas);
                    while (total_filas - fila  < barco)
                    {
                        fila = aleatoria.Next(0, total_filas);
                    }
                    fila_aux = fila;
                    for (int i = 0; i < barco; i++)
                    {
                        
                        if (tableroParaCargar[fila_aux, columna] == 1 || tableroParaCargar[fila_aux, columna] == 2 || tableroParaCargar[fila, columna_aux] == 4)
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
                if (fila != 0 && tableroParaCargar[fila - 1, columna] !=1)
                {
                    if (tableroParaCargar[fila - 1, columna] == 3)
                    {
                        tableroParaCargar[fila - 1, columna] = 4;
                    }
                    else
                    {
                        tableroParaCargar[fila - 1, columna] = 2;
                    }
                    
                }
                for (int i = 0; i < barco; i++)
                {

                    tableroParaCargar[fila, columna] = 1;
                   /* if (columna != 0)
                    { 
                        tableroParaCargar[fila, columna - 1] = 2;
                    }
                    if (columna + 1 < total_columnas)
                    {
                        tableroParaCargar[fila, columna + 1] = 2;
                    }*/
                    fila += 1;
                }
                if (fila == total_filas)
                { }
                else
                {
                    if (tableroParaCargar[fila, columna] != 1)
                    {
                        if (tableroParaCargar[fila, columna] == 3)
                        {
                            tableroParaCargar[fila, columna] = 4;
                        }
                        else
                        {
                            tableroParaCargar[fila, columna] = 2;
                        }
                    }
                }
                
            }
            else
            {
                while (bandera == false)
                {
                    fila = aleatoria.Next(0, total_filas);
                    columna = aleatoria.Next(0, total_columnas);
                    while(total_columnas - columna < barco)
                    {
                        columna = aleatoria.Next(0, total_columnas);
                    }
                    columna_aux = columna;
                    for (int i = 0; i < barco; i++)
                    {
                        
                        if (tableroParaCargar[fila, columna_aux] == 1 || tableroParaCargar[fila, columna_aux] == 3 || tableroParaCargar[fila, columna_aux] == 4)
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
                if (columna != 0 && tableroParaCargar[fila, columna - 1] != 1)
                {
                    if (tableroParaCargar[fila, columna - 1] == 2)
                    {
                        tableroParaCargar[fila, columna - 1] = 4;
                    }
                    else
                    {
                        tableroParaCargar[fila, columna - 1] = 3;
                    }
                    
                }
                for (int i = 0; i < barco; i++)
                {
                    tableroParaCargar[fila, columna] = 1;
                   /* if (fila != 0)
                    {
                    tableroParaCargar[fila-1, columna] = 2;
                    }
                    if (fila + 1 < total_filas)
                    {
                        tableroParaCargar[fila + 1, columna] = 2;
                    }*/
                    columna += 1;
                }
                if (columna == total_columnas)
                {
                    
                }
                else
                {
                    if (tableroParaCargar[fila, columna] != 1)
                    {
                        if (tableroParaCargar[fila, columna] == 2)
                        {
                            tableroParaCargar[fila, columna] = 4;
                        }
                        else
                        {
                            tableroParaCargar[fila, columna] = 3;
                        }
                    }
                }

               
            }
        }

    }
}
