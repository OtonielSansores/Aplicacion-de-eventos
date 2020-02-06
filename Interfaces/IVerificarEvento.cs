using System;

namespace AplicaciónEventos.Interfaces
{
    public interface IVerificarEvento
    {
        bool MenorAFechaActual(DateTime fecha);
        bool VerificarAnioDeEvento(DateTime fecha);
        bool VerificarMesDeEvento(DateTime fecha);
        bool VerificarDiaDeEvento(DateTime fecha);

        bool VerificarHoraDeEvento(DateTime fecha);
    }
}
