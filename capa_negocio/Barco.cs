using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class Barco
    {
        private int tipo;
        private int tamaño;

        public int Tipo { get => tipo; set => tipo = value; }
        public int Tamaño { get => tamaño; set => tamaño = value; }

        public Barco() {
            tipo = this.Tipo;
            tamaño = this.Tamaño;

        }
       
    }
}
