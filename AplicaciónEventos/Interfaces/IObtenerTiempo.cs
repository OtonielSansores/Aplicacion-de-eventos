using System;

namespace AplicaciónEventos.Interfaces
{
    public interface IObtenerTiempo
    {
        int DiferenciaDeTiempoEnMinutos(DateTime fechaIngresada, DateTime fechaComparar);
        int DiferenciaDeTiempoEnHoras(DateTime fechaIngresada, DateTime fechaComparar);
        int DiferenciaDeTiempoEnDias(DateTime fechaIngresada, DateTime fechaComparar);
        int DiferenciaDeTiempoEnMeses(DateTime fechaIngresada, DateTime fechaComparar);         
        string TiempoDeMensaje(DateTime fechaIngresada, DateTime fechaComparar);
    }
}