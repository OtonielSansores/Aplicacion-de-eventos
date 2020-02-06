using AplicaciónEventos.Interfaces;
using System;

namespace AplicaciónEventos
{
    public class VerificarEvento : IVerificarEvento
    {

        private readonly DateTime _fechaActual = DateTime.Now;


        public bool MenorAFechaActual(DateTime fecha)
        {
            if (fecha < _fechaActual)
            {
                return true;
            }
            else { return false; }
        }

        public bool VerificarAnioDeEvento(DateTime fecha)
        {
            if (fecha.Year == _fechaActual.Year)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificarMesDeEvento(DateTime fecha)
        {
            if (fecha.Month == _fechaActual.Month)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificarDiaDeEvento(DateTime fecha)
        {
            if (fecha.Day == _fechaActual.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificarHoraDeEvento(DateTime fecha)
        {
            if (fecha.Hour == _fechaActual.Hour)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
