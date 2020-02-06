using AplicaciónEventos.Interfaces;
using System;

namespace AplicaciónEventos
{
    public class CalcularFecha
    {

        private string[] _evento;
        private readonly IVerificarEvento _verificarEvento;
        private readonly IMensaje _mensaje;        
        private readonly DateTime _fechaActual = DateTime.Now;

        public CalcularFecha(IVerificarEvento verificarEvento, IMensaje mensaje)
        {
            _verificarEvento = verificarEvento;
            _mensaje = mensaje;            
        }
       

        public void ObtenerFechaEvento(string[] eventos)
        {
            foreach (string evento in eventos)
            {
                _evento = evento.Split(',');
                CalcularFechaEvento(_evento[0], _evento[1]);
            }
        }

        public string CalcularFechaEvento(string evento, string fecha)
        {
            string mensaje = "";
            if (_verificarEvento.MenorAFechaActual(DateTime.Parse(fecha)))
            {
                CalcularFechaEventoMenorAFechaActual(evento, fecha);
            }
            else
            {
                CalcularFechaEventoMayorAFechaActual(evento, fecha);
            }
            return mensaje;

        }

        public void CalcularFechaEventoMenorAFechaActual(string evento, string fecha)
        {
            string tipo = "";

            if (!_verificarEvento.VerificarMesDeEvento(DateTime.Parse(fecha)))
                tipo = "Mes";
            else
                if (!_verificarEvento.VerificarDiaDeEvento(DateTime.Parse(fecha)))
                    tipo = "Dia";
                else
                    if (!_verificarEvento.VerificarHoraDeEvento(DateTime.Parse(fecha)))
                        tipo = "Hora";

            switch (tipo)
            {
                case "Mes":
                    int mes = _fechaActual.Month - DateTime.Parse(fecha).Month;
                    Console.WriteLine(_mensaje.MensajePasado(evento, "" + mes, "Meses"));
                    break;
                case "Dia":
                    int dia = _fechaActual.Day - DateTime.Parse(fecha).Day;
                    Console.WriteLine(_mensaje.MensajePasado(evento, "" + dia, "dias"));
                    break;
                case "Hora":
                    int hora = _fechaActual.Hour - DateTime.Parse(fecha).Hour;
                    Console.WriteLine(_mensaje.MensajePasado(evento, "" + hora, "Horas"));
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

        public void CalcularFechaEventoMayorAFechaActual(string evento, string fecha)
        {
            string tipo = "";

            if (!_verificarEvento.VerificarMesDeEvento(DateTime.Parse(fecha)))
                tipo = "Mes";
            else
                if (!_verificarEvento.VerificarDiaDeEvento(DateTime.Parse(fecha)))
                    tipo = "Dia";
                else
                    if (!_verificarEvento.VerificarHoraDeEvento(DateTime.Parse(fecha)))
                        tipo = "Hora";

            switch (tipo)
            {
                case "Mes":
                    int mes = DateTime.Parse(fecha).Month - _fechaActual.Month;
                    Console.WriteLine(_mensaje.MensajeFuturo(evento, "" + mes, "Meses"));
                    break;
                case "Dia":
                    int dia = DateTime.Parse(fecha).Day - _fechaActual.Day;
                    Console.WriteLine(_mensaje.MensajeFuturo(evento, "" + dia, "dias"));
                    break;
                case "Hora":
                    int hora = DateTime.Parse(fecha).Hour - _fechaActual.Hour;
                    Console.WriteLine(_mensaje.MensajeFuturo(evento, "" + hora, "Horas"));
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }       
    }
}
