using System;
using System.Collections.Generic;
using AplicaciónEventos.Interfaces;

namespace AplicaciónEventos
{
    public class ConvertirDatosArchivo : IConvertirDatosArchivo
    {
        public List<Eventos> ConvertirAListaEventos(string[] datosArchivo)
        {
            Eventos evento;
            List<Eventos> listaEventos = new List<Eventos>();
            string[] dato;
            foreach (string datoArchivo in datosArchivo)
            {
                if (!ValidarDatosArchivo(datoArchivo))
                {
                    dato = datoArchivo.Split(',');
                    evento = new Eventos(dato[0], DateTime.Parse(dato[1]));
                    listaEventos.Add(evento);
                }                
            }

            return listaEventos;
        }

        private bool ValidarDatosArchivo(string datoArchivo)
        {
            return String.IsNullOrWhiteSpace(datoArchivo);
        }
    }
}
