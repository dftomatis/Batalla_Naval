using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class Montecarlo
    {
        int numeroPartidas;
        int totalTiros;
        int tirosAcertados;
        int tirosFallados;
        float efectividadTiros;
        float efectividadMediaTiros;
        int partidasGanadas;
        int partidasPerdidas;
        float efectividadMediaPartidas;
        float efectividadTirosAnterior;
        float efectividadMediaTirosAnterior;
        float efectividadMediaPartidasAnterior;
        int resultadoPartidaActual;


        public int NumeroPartidas { get => numeroPartidas; set => numeroPartidas = value; }
        public int TotalTiros { get => totalTiros; set => totalTiros = value; }
        public int TirosAcertados { get => tirosAcertados; set => tirosAcertados = value; }
        public int TirosFallados { get => tirosFallados; set => tirosFallados = value; }
        public float EfectividadTiros { get => efectividadTiros; set => efectividadTiros = value; }
        public float EfectividadMediaTiros { get => efectividadMediaTiros; set => efectividadMediaTiros = value; }
        public int PartidasGanadas { get => partidasGanadas; set => partidasGanadas = value; }
        public int PartidasPerdidas { get => partidasPerdidas; set => partidasPerdidas = value; }
        
        public float EfectividadMediaPartidas { get => efectividadMediaPartidas; set => efectividadMediaPartidas = value; }
        public float EfectividadTirosAnterior { get => efectividadTirosAnterior; set => efectividadTirosAnterior = value; }
        public float EfectividadMediaTirosAnterior { get => efectividadMediaTirosAnterior; set => efectividadMediaTirosAnterior = value; }
        
        public float EfectividadMediaPartidasAnterior { get => efectividadMediaPartidasAnterior; set => efectividadMediaPartidasAnterior = value; }
        public int ResultadoPartidaActual { get => resultadoPartidaActual; set => resultadoPartidaActual = value; }

        public Montecarlo()
        {
            NumeroPartidas = 0;
            TotalTiros = 0;
            TirosAcertados=0;
            TirosFallados = 0;
            EfectividadTiros = 0;
            EfectividadMediaTiros = 0;
            PartidasGanadas = 0;
            PartidasPerdidas = 0;
            EfectividadMediaPartidas = 0;
            EfectividadTirosAnterior=0;
            EfectividadMediaTirosAnterior=0;
            EfectividadMediaPartidasAnterior=0;
            ResultadoPartidaActual = 0;
        }


        

        public float calcularEfectividadTiros()
        {
            EfectividadTiros = (float)((decimal)(TirosAcertados) / (decimal)(TotalTiros));
            EfectividadTiros= (float)(Decimal.Round((decimal)(EfectividadTiros), 4))*100;
            return EfectividadTiros;

        }
        public float calcularEfectividadMediaTiros()
        {
            EfectividadMediaTirosAnterior = EfectividadMediaTiros;
            EfectividadMediaTiros = (float)((decimal)1/ (decimal)NumeroPartidas)*(float)((decimal)(NumeroPartidas-1)* (decimal)EfectividadMediaTirosAnterior + (decimal)TirosAcertados);
            EfectividadMediaTiros= (float)(Decimal.Round((decimal)(EfectividadMediaTiros), 4));
            return EfectividadMediaTiros;

        }

        
        public float calcularEfectividadMediaPartidas()
        {
            EfectividadMediaPartidasAnterior = EfectividadMediaPartidas;
            EfectividadMediaPartidas = (float)((decimal)1 / (decimal)NumeroPartidas) * (float)((decimal)(NumeroPartidas - 1) * (decimal)EfectividadMediaPartidasAnterior + (decimal)ResultadoPartidaActual);
            EfectividadMediaPartidas = (float)Decimal.Round((decimal)(EfectividadMediaPartidas), 4);
            return EfectividadMediaPartidas;

        }

    }
}
