using System;

namespace AplicaciónEventos
{
    public class Eventos
    {
        public Eventos(string evento, DateTime fecha)
        {
            Evento = evento;
            Fecha = fecha;
        }
        public string Evento { get; set; }

        public DateTime Fecha { get; set; }
    }

}
