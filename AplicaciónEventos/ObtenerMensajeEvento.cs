using AplicaciónEventos.Interfaces;
using System;

namespace AplicaciónEventos
{
    public class ObtenerMensajeEvento
    {

        private readonly IMensaje _mensaje;
        private readonly IObtenerTiempo _obtenerTiempo;
        public ObtenerMensajeEvento(IObtenerTiempo obtenerTiempo, IMensaje mensaje)
        {
            _obtenerTiempo = obtenerTiempo;
            _mensaje = mensaje;
        }

        public string ObtenerMensaje(string evento, DateTime fechaIngresada, DateTime fechaComparar)
        {

            int diferenciaDeMeses = _obtenerTiempo.DiferenciaDeTiempoEnMeses(fechaIngresada, fechaComparar);
            int diferenciaDeDias = _obtenerTiempo.DiferenciaDeTiempoEnDias(fechaIngresada, fechaComparar);
            int diferenciaDeHoras = _obtenerTiempo.DiferenciaDeTiempoEnHoras(fechaIngresada, fechaComparar);
            int diferenciaDeMinutos = _obtenerTiempo.DiferenciaDeTiempoEnMinutos(fechaIngresada, fechaComparar);
            string tiempoMensaje = _obtenerTiempo.TiempoDeMensaje(fechaIngresada, fechaComparar);
            int lapsoTiempo = 0;
            string formatoTiempo = "";

            if ((fechaIngresada.Month != fechaComparar.Month) || (fechaIngresada.Year != fechaComparar.Year))
            {
                lapsoTiempo = diferenciaDeMeses;
                formatoTiempo = "Meses";
            }
            if (fechaIngresada.Month == fechaComparar.Month)
            {
                lapsoTiempo = diferenciaDeDias;
                formatoTiempo = "Días";
            }

            if (fechaIngresada.Day == fechaComparar.Day && fechaIngresada.Month == fechaComparar.Month && fechaIngresada.Year == fechaComparar.Year)
            {
                lapsoTiempo = diferenciaDeHoras;
                formatoTiempo = "Horas";
            }

            if (fechaIngresada.Hour == fechaComparar.Hour && fechaIngresada.Hour != 0 && 
                fechaIngresada.Day == fechaComparar.Day && fechaIngresada.Month == fechaComparar.Month && fechaIngresada.Year == fechaComparar.Year)
            {
                lapsoTiempo = diferenciaDeMinutos;
                formatoTiempo = "Minutos";
            }

            return _mensaje.CrearMensaje(evento, tiempoMensaje, lapsoTiempo, formatoTiempo);
        }
    }
}
