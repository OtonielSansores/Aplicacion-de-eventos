using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AplicaciónEventos.Tests
{

    [TestClass()]
    public class LeerArchivoTests
    {
        [TestMethod()]
        public void ObtenerListaEventos_LeerArchivo_Cadena()
        {
            //Arrange
            LeerArchivo leerArchivo = new LeerArchivo();
            string ruta = Directory.GetCurrentDirectory() + @"\texto.txt";

            //Act
            string[] respuesta = leerArchivo.ObtenerDatosArchivo(ruta);

            //Assert
            Assert.AreEqual(6, respuesta.Length);

        }
    }
}