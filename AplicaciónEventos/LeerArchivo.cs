using AplicaciónEventos.Interfaces;
using System.IO;

namespace AplicaciónEventos
{
    public class LeerArchivo : ILeerArchivo
    {
        public string[] ObtenerDatosArchivo(string ruta)
        {
            string[] datosArchivoTexto = File.ReadAllLines(ruta);
            return datosArchivoTexto;
        }

    }
}
