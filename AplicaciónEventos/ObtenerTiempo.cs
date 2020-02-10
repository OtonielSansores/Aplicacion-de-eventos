using System;
using AplicaciónEventos.Interfaces;

namespace AplicaciónEventos
{
    public class ObtenerTiempo : IObtenerTiempo
    {           
        public int DiferenciaDeTiempoEnMinutos(DateTime fechaIngresada, DateTime fechaComparar)
        {
            int diferenciaDeMinutos;

            if (fechaIngresada.Minute < fechaComparar.Minute)
                diferenciaDeMinutos = fechaComparar.Minute - fechaIngresada.Minute;
            else
                diferenciaDeMinutos = fechaIngresada.Minute - fechaComparar.Minute;

            return diferenciaDeMinutos;
        }

        public int DiferenciaDeTiempoEnHoras(DateTime fechaIngresada, DateTime fechaComparar)
        {
            int diferenciaDeHoras;

            if (fechaIngresada.Hour < fechaComparar.Hour)
                diferenciaDeHoras = fechaComparar.Hour - fechaIngresada.Hour;
            else
                diferenciaDeHoras = fechaIngresada.Hour - fechaComparar.Hour;

            return diferenciaDeHoras;
        }
        public int DiferenciaDeTiempoEnDias(DateTime fechaIngresada, DateTime fechaComparar)
        {
            int diferenciaDeDias;

            if (fechaIngresada.Day < fechaComparar.Day)            
                diferenciaDeDias = fechaComparar.Day - fechaIngresada.Day;            
            else            
                diferenciaDeDias = fechaIngresada.Day - fechaComparar.Day;

            return diferenciaDeDias;
        }        

        public int DiferenciaDeTiempoEnMeses(DateTime fechaIngresada, DateTime fechaComparar)
        {
            int diferenciaDeMeses;
            int diferenciaDeAños;

            if (fechaIngresada < fechaComparar)
            {
                diferenciaDeAños = fechaComparar.Year - fechaIngresada.Year;
                diferenciaDeMeses = (12 - fechaIngresada.Month) + fechaComparar.Month + ((diferenciaDeAños - 1) * 12);
            }
            else
            {
                diferenciaDeAños = fechaIngresada.Year - fechaComparar.Year;
                diferenciaDeMeses = (12 - fechaComparar.Month) + fechaIngresada.Month + ((diferenciaDeAños - 1) * 12);
            }

            return diferenciaDeMeses;
        }

        public string TiempoDeMensaje(DateTime fechaIngresada, DateTime fechaComparar)
        {
            string tiempoMensaje;

            if (fechaIngresada < fechaComparar)            
                tiempoMensaje = "ocurrió hace";            
            else            
                tiempoMensaje = "ocurrirá dentro de";
            
            return tiempoMensaje;
        }
    }
}
