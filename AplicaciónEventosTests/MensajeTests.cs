using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AplicaciónEventos.Tests
{
    [TestClass()]
    public class MensajeTests
    {

        [TestMethod()]
        public void CrearMensaje_ParametrosAdecuados_DevolverMensaje()
        {
            //Arrange            
            Mensaje mensaje = new Mensaje();
            string mensajeEsperado = "Evento1 ocurrió hace 4 Días";

            //Act
            string resultado = mensaje.CrearMensaje("Evento1", "ocurrió hace",4, "Días");

            //Assert
            Assert.AreEqual(mensajeEsperado, resultado);
        }

        //[TestMethod()]
        //public void MostrarMensaje_PasarLitaDeMensajes_ImprimirEnPantallaMensajes()
        //{
        //    //Arrange            
        //    Mensaje mensaje = new Mensaje();
        //    string mensajeEsperado = "Evento2 ocurrió hace 6 Meses";

        //    //Act
        //    string resultado = mensaje.MensajePasado("Evento2", "6", "Meses");

        //    //Assert
        //    Assert.AreEqual(mensajeEsperado, resultado);
        //}
    }
}