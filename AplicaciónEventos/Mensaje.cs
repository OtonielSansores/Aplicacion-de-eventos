using AplicaciónEventos.Interfaces;
using System;
using System.Collections.Generic;

namespace AplicaciónEventos
{
    public class Mensaje : IMensaje
    {
        /// <summary>
        /// Crea el mensaje.
        /// </summary>
        /// <param name="evento">Nombre del evento.</param>
        /// <param name="tiempoMensaje">Tiempo del mensaje pasado o futuro</param>
        /// <param name="lapsoTiempo">Diferencia de lapso de tiempo entre las dos fechas.</param>
        /// <param name="formatoTiempo">Meses, Días, Horas o Minutos.</param>
        /// <returns></returns>
        public string CrearMensaje(string evento, string tiempoMensaje, int lapsoTiempo, string formatoTiempo)
        {
            return String.Format("{0} {1} {2} {3}", evento, tiempoMensaje, lapsoTiempo, formatoTiempo);
        }

        public void MostrarMensaje(List<string> mensajes)
        {
            foreach(string mensaje in mensajes)
            {
                Console.WriteLine(mensaje);
            }
        }
    }
}