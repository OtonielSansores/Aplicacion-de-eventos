using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AplicaciónEventos.Tests
{
    [TestClass()]
    public class ObtenerMensajeEventoTests
    {
        private Mensaje _mensaje;
        private ObtenerTiempo _obtenerTiempo;
        private ObtenerMensajeEvento _obtenerMensajeEvento;

        [TestInitialize]
        public void OnSetup()
        {
            _mensaje = new Mensaje();
            _obtenerTiempo = new ObtenerTiempo();
        }


        [TestMethod()]
        public void ObtenerMensaje_CuandoLaComparacionDeLosMesesSonDiferentes_ElFormatoDeTiempoDebeSerMeses()
        {
            //Arrange
            _obtenerMensajeEvento = new ObtenerMensajeEvento(_obtenerTiempo, _mensaje);
            string esperado = "Evento2 ocurrió hace 3 Meses";

            //Act
            string resultado = _obtenerMensajeEvento.ObtenerMensaje("Evento2", new DateTime(2020, 02, 06), new DateTime(2020, 05, 06));

            //Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void ObtenerMensaje_CuandoLaComparacionDeLosAñosSonDiferentes_ElFormatoDeTiempoDebeSerMeses()
        {
            //Arrange
            _obtenerMensajeEvento = new ObtenerMensajeEvento(_obtenerTiempo, _mensaje);
            string esperado = "Evento2 ocurrió hace 3 Meses";

            //Act
            string resultado = _obtenerMensajeEvento.ObtenerMensaje("Evento2", new DateTime(2019, 12, 06), new DateTime(2020, 03, 06));

            //Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void ObtenerMensaje_CuandoLaComparacionDeLosMesesSonIguales_ElFormatoDeTiempoDebeSerDias()
        {
            //Arrange
            _obtenerMensajeEvento = new ObtenerMensajeEvento(_obtenerTiempo, _mensaje);
            string esperado = "Evento2 ocurrió hace 8 Días";

            //Act
            string resultado = _obtenerMensajeEvento.ObtenerMensaje("Evento2", new DateTime(2020, 03, 02), new DateTime(2020, 03, 10));

            //Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void ObtenerMensaje_CuandoLaComparacionDeLosDiasMesesAñosSonIguales_ElFormatoDeTiempoDebeSerHoras()
        {
            //Arrange
            _obtenerMensajeEvento = new ObtenerMensajeEvento(_obtenerTiempo, _mensaje);
            string esperado = "Evento2 ocurrió hace 3 Horas";

            //Act
            string resultado = _obtenerMensajeEvento.ObtenerMensaje("Evento2", new DateTime(2020, 03, 02, 09, 00, 00), new DateTime(2020, 03, 02, 12, 00, 00));

            //Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void ObtenerMensaje_CuandoLaComparacionDeLasHorasDiasMesesAñosSonIguales_ElFormatoDeTiempoDebeSerminutos()
        {
            //Arrange
            _obtenerMensajeEvento = new ObtenerMensajeEvento(_obtenerTiempo, _mensaje);
            string esperado = "Evento2 ocurrió hace 30 Minutos";

            //Act
            string resultado = _obtenerMensajeEvento.ObtenerMensaje("Evento2", new DateTime(2020, 03, 02, 12, 10, 00), new DateTime(2020, 03, 02, 12, 40, 00));

            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}