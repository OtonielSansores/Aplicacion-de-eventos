using System.Collections.Generic;

namespace AplicaciónEventos.Interfaces
{
    public interface IMensaje
    {        
        string CrearMensaje(string evento, string tiempoMensaje, int lapsoTiempo, string formatoTiempo);

        void MostrarMensaje(List<string> mensajes);
    }
}
