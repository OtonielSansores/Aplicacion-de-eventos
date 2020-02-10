using System.Collections.Generic;

namespace AplicaciónEventos.Interfaces
{
    public interface IConvertirDatosArchivo
    {
        List<Eventos> ConvertirAListaEventos(string[] datosArchivo);
    }
}
