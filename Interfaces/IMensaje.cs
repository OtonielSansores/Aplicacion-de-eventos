namespace AplicaciónEventos.Interfaces
{
    public interface IMensaje
    {
        string MensajeFuturo(string evento, string lapsoTiempo, string formatoTiempo);

        string MensajePasado(string evento, string lapsoTiempo, string formatoTiempo);
    }
}
