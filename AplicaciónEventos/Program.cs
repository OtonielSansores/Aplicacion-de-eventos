using AplicaciónEventos.Interfaces;
using System;
using System.Collections.Generic;

namespace AplicaciónEventos
{
    public class Program
    {

        static void Main(string[] args)
        {            
            IMensaje mensaje = new Mensaje();
            ILeerArchivo leerArchivo = new LeerArchivo();
            IConvertirDatosArchivo convertirDatos = new ConvertirDatosArchivo();
            IObtenerTiempo obtenerTiempo = new ObtenerTiempo(); 
            ObtenerMensajeEvento obtenerMensajeEvento = new ObtenerMensajeEvento(obtenerTiempo, mensaje);
            List<string> mensajesEventos = new List<string>();
            DateTime fechaComparar = new DateTime(2020,04,02,12,40,00);

            string[] eventos = leerArchivo.ObtenerDatosArchivo(@"C:\Users\otoniel.sansores\source\repos\AplicaciónEventos\AplicaciónEventos\texto.txt");
            List<Eventos> listaEventos = convertirDatos.ConvertirAListaEventos(eventos);

            foreach (Eventos evento in listaEventos)
            {
                mensajesEventos.Add(obtenerMensajeEvento.ObtenerMensaje(evento.Evento, evento.Fecha, fechaComparar));
            }

            mensaje.MostrarMensaje(mensajesEventos);
            
            Console.ReadKey();
        }
    }
}