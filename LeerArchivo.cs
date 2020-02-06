using AplicaciónEventos.Interfaces;
using System.IO;

namespace AplicaciónEventos
{
    public class LeerArchivo : ILeerArchivo
    {
        public string[] ObtenerListaEventos(string ruta)
        {
            string[] archivoTexto = File.ReadAllLines(@ruta);
            return archivoTexto;
        }
        
    }
}
