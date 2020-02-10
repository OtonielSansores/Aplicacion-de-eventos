using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AplicaciónEventos.Tests
{
    [TestClass()]
    public class ConvertirDatosArchivoTests
    {
        [TestMethod()]
        public void ConvertirAListaEventos_AgregaEventosAUnaLista_ListaDeEventos()
        {
            //Arrange 
            string[] DatosArchivo = new string[4];
            DatosArchivo[0] = "Evento1, 01/02/20";
            DatosArchivo[1] = "Evento2, 01/05/20";
            DatosArchivo[2] = "Evento3, 01/05/20 12:20:00";
            DatosArchivo[3] = "Evento4, 01/02/20 3:00:00";            

            ConvertirDatosArchivo convertirDatosArchivo = new ConvertirDatosArchivo();

            //Act
            List<Eventos> resultado = convertirDatosArchivo.ConvertirAListaEventos(DatosArchivo);

            //Assert
            Assert.AreEqual(4, resultado.Count);
        }

        [TestMethod()]
        public void ConvertirAListaEventos_DatosArchivoVacio_ListaVacia()
        {
            //Arrange 
            string[] DatosArchivo = new string[4];

            ConvertirDatosArchivo convertirDatosArchivo = new ConvertirDatosArchivo();

            //Act
            List<Eventos> resultado = convertirDatosArchivo.ConvertirAListaEventos(DatosArchivo);

            //Assert
            Assert.AreEqual(0, resultado.Count);
        }               
    }
}