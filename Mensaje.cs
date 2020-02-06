using AplicaciónEventos.Interfaces;
using System;

namespace AplicaciónEventos
{
    public class Mensaje : IMensaje
    {
        public string MensajeFuturo(string evento, string lapsoTiempo, string formatoTiempo)
        {
            return String.Format("{0} ocurrirá dentro de {1} {2}", evento, lapsoTiempo, formatoTiempo);
        }

        public string MensajePasado(string evento, string lapsoTiempo, string formatoTiempo)
        {
            return String.Format("{0} ocurrió hace {1} {2}", evento, lapsoTiempo, formatoTiempo);
        }
    }
}
