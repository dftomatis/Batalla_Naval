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
            Barco b = new Barco();
            tablero = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j =0; j<columnas; j++)
                {
                   
                    tablero[i,j] = 0; 
                }
                
                
            }
            for (int i = 6; i>1; i--)
            {
                b.Tipo = i;
                b.Tamaño = i;
                CargarBarco(tablero, b);
                CargarBarco(tablero, b);
            }
            

            return tablero;
        }

        public void CargarBarco(int[,] tableroParaCargar, Barco barco)
        {
            int total_filas = tableroParaCargar.GetLength(0);
            int total_columnas = tableroParaCargar.GetLength(1);
            int fila=0;
            int columna=0;
            int fila_aux=0;
            int columna_aux = 0;
            double orden = (int)(aleatoria.NextDouble() * 1000000);
            //double limit = aleatoria.NextDouble() * 10;
            Boolean bandera = false;

            
            if (orden % 2 == 0) //si el modulo = 0 ordena vertical, si no ordena horizontal
            {
                while ( bandera == false)
                {
                    fila = aleatoria.Next(0, total_filas);
                    columna = aleatoria.Next(0, total_columnas);
                    while (total_filas - fila  < barco.Tamaño)
                    {
                        fila = aleatoria.Next(0, total_filas);
                    }
                    fila_aux = fila;
                    for (int i = 0; i < barco.Tamaño; i++)
                    {
                        
                        if (tableroParaCargar[fila_aux, columna] == 12 || tableroParaCargar[fila_aux, columna] == 14 || tableroParaCargar[fila_aux, columna] == 15)
                        {
                           bandera = false;
                           break;                                                       
                        }
                        else
                        {
                                if (tableroParaCargar[fila_aux, columna] > 1 && tableroParaCargar[fila_aux, columna] < 7)
                                {
                                    bandera = false;
                                    break;
                                }
                                else
                                {
                                    bandera = true;
                                }

                            
                            
                        }
                        fila_aux += 1;
                    }
                }
                
                    if (fila != 0 && (tableroParaCargar[fila - 1, columna] < 2 || tableroParaCargar[fila - 1, columna] > 6))
                    {

                        if (tableroParaCargar[fila - 1, columna] == 13)
                        {
                            tableroParaCargar[fila - 1, columna] = 14;
                        }
                        else
                        {
                            tableroParaCargar[fila - 1, columna] = 12;
                        }

                    }
                
                for (int i = 0; i < barco.Tamaño; i++)
                {

                    tableroParaCargar[fila, columna] = barco.Tipo;
                   /* if (columna != 0)
                    { 
                        tableroParaCargar[fila, columna - 1] = 15;
                    }
                    if (columna + 1 < total_columnas)
                    {
                        tableroParaCargar[fila, columna + 1] = 15;
                    }*/
                    fila += 1;
                }
                if (fila == total_filas)
                { }
                else
                {
                   

                        if (tableroParaCargar[fila, columna] < 2 || tableroParaCargar[fila, columna] > 6)
                        {
                            if (tableroParaCargar[fila, columna] == 13)
                            {
                                tableroParaCargar[fila, columna] = 14;
                            }
                            else
                            {
                                tableroParaCargar[fila, columna] = 12;
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
                    while(total_columnas - columna < barco.Tamaño)
                    {
                        columna = aleatoria.Next(0, total_columnas);
                    }
                    columna_aux = columna;
                    for (int i = 0; i < barco.Tamaño; i++)
                    {
                        
                        if (tableroParaCargar[fila, columna_aux] == 13 || tableroParaCargar[fila, columna_aux] == 14 || tableroParaCargar[fila, columna_aux] == 16)
                        {
                            bandera = false;
                            break;  
                        }
                        else
                        {
                           
                                if (tableroParaCargar[fila, columna_aux] > 1 && tableroParaCargar[fila, columna_aux] < 7)
                                {
                                    bandera = false;
                                    break;
                                }
                                else
                                {
                                    bandera = true;
                                }
                            
                        }
                        columna_aux += 1;
                    }
                }
              
                    if (columna != 0 && (tableroParaCargar[fila, columna - 1] < 2 || tableroParaCargar[fila, columna-1] > 6 ))
                    {
                        if (tableroParaCargar[fila, columna - 1] == 12)
                        {
                            tableroParaCargar[fila, columna - 1] = 14;
                        }
                        else
                        {
                            tableroParaCargar[fila, columna - 1] = 13;
                        }

                    }
                
                for (int i = 0; i < barco.Tamaño; i++)
                {
                    tableroParaCargar[fila, columna] = barco.Tipo;
                   /* if (fila != 0)
                    {
                    tableroParaCargar[fila-1, columna] = 16;
                    }
                    if (fila + 1 < total_filas)
                    {
                        tableroParaCargar[fila + 1, columna] = 16;
                    }*/
                    columna += 1;
                }
                if (columna == total_columnas)
                {
                    
                }
                else
                {
                    
                        if (tableroParaCargar[fila, columna] < 2 || tableroParaCargar[fila, columna] > 6)
                        {
                            if (tableroParaCargar[fila, columna] == 12)
                            {
                                tableroParaCargar[fila, columna] = 14;
                            }
                            else
                            {
                                tableroParaCargar[fila, columna] = 13;
                            }
                        }
                    
                }

               
            }
        }

    }
}
