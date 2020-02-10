using AplicaciónEventos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AplicaciónEventos.Tests
{
    [TestClass()]
    public class ObtenerTiempoTests
    {
        [TestMethod()]
        public void DiferenciaDeTiempoEnMinutos_FechaIngresadaMinutosMenorAFechaCompara_DebeRegresarTrienta()
        {
            //Arrange
            ObtenerTiempo obtenerTiempo = new ObtenerTiempo();

            //Act
            int resultado = obtenerTiempo.DiferenciaDeTiempoEnMinutos(new DateTime(2020, 03, 02, 12, 10, 00), new DateTime(2020, 03, 02, 12, 40, 00));

            //Assert
            Assert.AreEqual(30, resultado);
        }

        [TestMethod()]
        public void DiferenciaDeTiempoEnMinutos_FechaIngresadaMinutosMayorAFechaCompara_DebeRegresarTrienta()
        {
            //Arrange
            ObtenerTiempo obtenerTiempo = new ObtenerTiempo();

            //Act
            int resultado = obtenerTiempo.DiferenciaDeTiempoEnMinutos(new DateTime(2020, 03, 02, 12, 40, 00), new DateTime(2020, 03, 02, 12, 10, 00));

            //Assert
            Assert.AreEqual(30, resultado);
        }

        [TestMethod()]
        public void DiferenciaDeTiempoEnHoras_FechaIngresadaHorasMenorAFechaCompara_DebeRegresarTres()
        {
            //Arrange
            ObtenerTiempo obtenerTiempo = new ObtenerTiempo();

            //Act
            int resultado = obtenerTiempo.DiferenciaDeTiempoEnHoras(new DateTime(2020, 03, 02, 09, 00, 00), new DateTime(2020, 03, 02, 12, 00, 00));

            //Assert
            Assert.AreEqual(3, resultado);
        }

        [TestMethod()]
        public void DiferenciaDeTiempoEnHoras_FechaIngresadaHorasMayorAFechaCompara_DebeRegresarTres()
        {
            //Arrange
            ObtenerTiempo obtenerTiempo = new ObtenerTiempo();

            //Act
            int resultado = obtenerTiempo.DiferenciaDeTiempoEnHoras(new DateTime(2020, 03, 02, 12, 00, 00), new DateTime(2020, 03, 02, 09, 00, 00));

            //Assert
            Assert.AreEqual(3, resultado);
        }

        [TestMethod()]
        public void DiferenciaDeTiempoEnDias_FechaIngresadaDiasMenorAFechaComparar_DebeRegresarTres()
        {
            //Arrange
            ObtenerTiempo obtenerTiempo = new ObtenerTiempo();

            //Act
            int resultado = obtenerTiempo.DiferenciaDeTiempoEnDias(new DateTime(2020, 03, 02, 12, 00, 00), new DateTime(2020, 03, 05, 12, 00, 00));

            //Assert
            Assert.AreEqual(3, resultado);
        }

        [TestMethod()]
        public void DiferenciaDeTiempoEnDias_FechaIngresadaDiasMayorAFechaComparar_DebeRegresarTres()
        {
            //Arrange
            ObtenerTiempo obtenerTiempo = new ObtenerTiempo();

            //Act
            int resultado = obtenerTiempo.DiferenciaDeTiempoEnDias(new DateTime(2020, 03, 05, 12, 00, 00), new DateTime(2020, 03, 02, 12, 00, 00));

            //Assert
            Assert.AreEqual(3, resultado);
        }

        [TestMethod()]
        public void DiferenciaDeTiempoEnMeses_FechaIngresadaMeseMenorAFechaComparar_DebeRegresarTres()
        {
            //Arrange
            ObtenerTiempo obtenerTiempo = new ObtenerTiempo();

            //Act
            int resultado = obtenerTiempo.DiferenciaDeTiempoEnMeses(new DateTime(2020, 03, 02, 12, 00, 00), new DateTime(2020, 06, 02, 12, 00, 00));

            //Assert
            Assert.AreEqual(3, resultado);
        }

        [TestMethod()]
        public void DiferenciaDeTiempoEnMeses_FechaIngresadaMeseMayorAFechaComparar_DebeRegresarTres()
        {
            //Arrange
            ObtenerTiempo obtenerTiempo = new ObtenerTiempo();

            //Act
            int resultado = obtenerTiempo.DiferenciaDeTiempoEnMeses(new DateTime(2020, 06, 02, 12, 00, 00), new DateTime(2020, 03, 02, 12, 00, 00));

            //Assert
            Assert.AreEqual(3, resultado);
        }

        [TestMethod()]
        public void TiempoDeMensaje_fechaIngresadaMenorAFechaAComparar_DebeRegresarTextoOcurrioHace()
        {
            //Arrange
            ObtenerTiempo obtenerTiempo = new ObtenerTiempo();

            //Act
            string resultado = obtenerTiempo.TiempoDeMensaje(new DateTime(2020, 03, 02, 12, 00, 00), new DateTime(2020, 06, 02, 12, 00, 00));

            //Assert
            Assert.AreEqual("ocurrió hace", resultado);
        }

        [TestMethod()]
        public void TiempoDeMensaje_fechaIngresadaMayorAFechaAComparar_DebeRegresarTextoOcurriraDentroDe()
        {
            //Arrange
            ObtenerTiempo obtenerTiempo = new ObtenerTiempo();

            //Act
            string resultado = obtenerTiempo.TiempoDeMensaje(new DateTime(2020, 06, 02, 12, 00, 00), new DateTime(2020, 03, 02, 12, 00, 00));

            //Assert
            Assert.AreEqual("ocurrirá dentro de", resultado);
        }
    }
}