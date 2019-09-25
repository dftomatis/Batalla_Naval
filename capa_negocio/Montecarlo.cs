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
        int totalTirosAcum;
        int tirosAcertados;
        float tirosAcertadosAnterior;
        int tirosAcertadosAcum;
        int tirosFallados;
        int tirosFalladosAcum;
        float efectividadTiros;
        float efectividadTirosAcumAnterior;
        float efectividadTirosAcum;
        float efectividadMediaTiros;
        int partidasGanadas;
        int partidasPerdidas;
        float efectividadMediaPartidas;
        float efectividadMediaTirosAnterior;
        float efectividadMediaPartidasAnterior;
        int resultadoPartidaActual;
        float totalTirosAnterior;
        float mediaTirosTotal;
        float mediaTirosAcertados;
        float tirosFalladosAnterior;
        float mediaTirosFallados;


        public int NumeroPartidas { get => numeroPartidas; set => numeroPartidas = value; }
        public int TotalTiros { get => totalTiros; set => totalTiros = value; }
        public int TirosAcertados { get => tirosAcertados; set => tirosAcertados = value; }
        public int TirosFallados { get => tirosFallados; set => tirosFallados = value; }
        public float EfectividadTiros { get => efectividadTiros; set => efectividadTiros = value; }
        public float EfectividadMediaTiros { get => efectividadMediaTiros; set => efectividadMediaTiros = value; }
        public int PartidasGanadas { get => partidasGanadas; set => partidasGanadas = value; }
        public int PartidasPerdidas { get => partidasPerdidas; set => partidasPerdidas = value; }
        
        public float EfectividadMediaPartidas { get => efectividadMediaPartidas; set => efectividadMediaPartidas = value; }
        
        public float EfectividadMediaTirosAnterior { get => efectividadMediaTirosAnterior; set => efectividadMediaTirosAnterior = value; }
        
        public float EfectividadMediaPartidasAnterior { get => efectividadMediaPartidasAnterior; set => efectividadMediaPartidasAnterior = value; }
        public int ResultadoPartidaActual { get => resultadoPartidaActual; set => resultadoPartidaActual = value; }
        public int TotalTirosAcum { get => totalTirosAcum; set => totalTirosAcum = value; }
        public int TirosAcertadosAcum { get => tirosAcertadosAcum; set => tirosAcertadosAcum = value; }
        public int TirosFalladosAcum { get => tirosFalladosAcum; set => tirosFalladosAcum = value; }
        public float EfectividadTirosAcum { get => efectividadTirosAcum; set => efectividadTirosAcum = value; }
        public float EfectividadTirosAcumAnterior { get => efectividadTirosAcumAnterior; set => efectividadTirosAcumAnterior = value; }
        
        public float TirosAcertadosAnterior { get => tirosAcertadosAnterior; set => tirosAcertadosAnterior = value; }
        public float TotalTirosAnterior { get => totalTirosAnterior; set => totalTirosAnterior = value; }
        public float MediaTirosTotal { get => mediaTirosTotal; set => mediaTirosTotal = value; }
        public float MediaTirosAcertados { get => mediaTirosAcertados; set => mediaTirosAcertados = value; }
        public float TirosFalladosAnterior { get => tirosFalladosAnterior; set => tirosFalladosAnterior = value; }
        public float MediaTirosFallados { get => mediaTirosFallados; set => mediaTirosFallados = value; }

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
            EfectividadTirosAcumAnterior = 0;
            EfectividadMediaTirosAnterior =0;
            EfectividadMediaPartidasAnterior=0;
            ResultadoPartidaActual = 0;
            TotalTirosAcum = 0;
            TirosAcertadosAcum = 0;
            TirosFalladosAcum = 0;
            EfectividadTirosAcum = 0;
            TotalTirosAnterior = 0;
            MediaTirosTotal = 0;
            TirosAcertadosAnterior = 0;
            MediaTirosAcertados = 0;
            TirosFalladosAnterior = 0;
            MediaTirosFallados = 0;
        }


        

        public float calcularEfectividadTiros()
        {
            
            EfectividadTiros = (float)((decimal)(TirosAcertados) / (decimal)(TotalTiros));
            EfectividadTiros= (float)(Decimal.Round((decimal)(EfectividadTiros), 4))*100;
            return EfectividadTiros;

        }
        public float calcularEfectividadMedia()
        {
            EfectividadTirosAcumAnterior = EfectividadTirosAcum;
            EfectividadTirosAcum = (float)((decimal)1 / (decimal)NumeroPartidas) * (float)((decimal)(NumeroPartidas - 1) * (decimal)EfectividadTirosAcumAnterior + (decimal)EfectividadTiros);
            EfectividadTirosAcum = (float)(Decimal.Round((decimal)(EfectividadTirosAcum), 4));
            return EfectividadTirosAcum;

        }
       

        
        public float calcularEfectividadMediaPartidas()
        {
            EfectividadMediaPartidasAnterior = EfectividadMediaPartidas;
            EfectividadMediaPartidas = (float)((decimal)1 / (decimal)NumeroPartidas) * (float)((decimal)(NumeroPartidas - 1) * (decimal)EfectividadMediaPartidasAnterior + (decimal)ResultadoPartidaActual);
            EfectividadMediaPartidas = (float)Decimal.Round((decimal)(EfectividadMediaPartidas), 4);
            return EfectividadMediaPartidas;

        }

        public float calcularMediaTirosTotales()
        {
            TotalTirosAnterior = MediaTirosTotal;
            MediaTirosTotal = (float)((decimal)1 / (decimal)NumeroPartidas) * (float)((decimal)(NumeroPartidas - 1) * (decimal)TotalTirosAnterior + (decimal)TotalTiros);
            MediaTirosTotal = (float)Decimal.Round((decimal)(MediaTirosTotal), 4);
            return MediaTirosTotal;

        }
        public float calcularMediaTirosAcertados()
        {
            TirosAcertadosAnterior = MediaTirosAcertados;
            MediaTirosAcertados = (float)((decimal)1 / (decimal)NumeroPartidas) * (float)((decimal)(NumeroPartidas - 1) * (decimal)TirosAcertadosAnterior + (decimal)TirosAcertados);
            MediaTirosAcertados = (float)Decimal.Round((decimal)(MediaTirosAcertados), 4);
            return MediaTirosAcertados;
           
        }
        public float calcularMediaTirosFallados()
        {
            TirosFalladosAnterior = MediaTirosFallados;
            MediaTirosFallados = (float)((decimal)1 / (decimal)NumeroPartidas) * (float)((decimal)(NumeroPartidas - 1) * (decimal)TirosFalladosAnterior + (decimal)TirosFallados);
            MediaTirosFallados = (float)Decimal.Round((decimal)(MediaTirosFallados), 4);
            return MediaTirosFallados;

        }

    }
}
