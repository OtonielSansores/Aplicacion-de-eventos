using System;
using System.IO;

namespace AplicaciónEventos
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] archivoTexto = File.ReadAllLines(@"C:\Users\otoniel.sansores\source\repos\AplicaciónEventos\AplicaciónEventos\texto.txt");
            
            string[] evento;

            foreach(string lineaTexto in archivoTexto)
            {
                evento = lineaTexto.Split(',');                
                Console.WriteLine(VerificarEvento(evento[0], evento[1]));                
            }
                     
            Console.ReadKey();
        }

        public static string VerificarEvento(string evento, string fecha)
        {
            string mensaje = "";
            DateTime fechaActual = DateTime.Now;
            DateTime fechaEvento = new DateTime();
            try
            {
                fechaEvento = DateTime.Parse(fecha);
            }
            catch
            {
                Console.WriteLine("El formato de la fecha es incorrecto");
            }
            
            if(fechaEvento < fechaActual)
            {
                if (fechaEvento.Month == fechaActual.Month)
                {
                    if (fechaEvento.Day == fechaActual.Day)
                    {
                        if (fechaEvento.Hour == fechaActual.Hour)
                        {
                            int horas = fechaActual.Hour - fechaEvento.Hour;
                            mensaje = String.Format("{0} ocurrió hace {1} HRS", evento, horas);
                        }
                        else
                        {
                            int minutos = fechaActual.Minute - fechaEvento.Minute;
                            mensaje = String.Format("{0} ocurrió hace {1} min", evento, minutos);
                        }

                    }
                    else
                    {
                        int mes = fechaActual.Month - fechaEvento.Month;
                        mensaje = String.Format("{0} ocurrió hace {1} Mes", evento, mes);
                    }
                }
                else
                {
                    int dias;
                    if(fechaEvento.Month > fechaActual.Month)
                    {
                         dias = fechaEvento.Month - fechaActual.Month;
                        
                    }
                    else
                    {
                         dias = fechaActual.Month - fechaEvento.Month;                       
                    }
                    mensaje = String.Format("{0} ocurrió hace {1} Dias", evento, dias);

                }
            }
            else
            {
                if (fechaEvento.Month == fechaActual.Month)
                {
                    if (fechaEvento.Day == fechaActual.Day)
                    {
                        if (fechaEvento.Hour == fechaActual.Hour)
                        {
                            int horas = fechaEvento.Hour - fechaActual.Hour;
                            mensaje = String.Format("{0} ocurrirá dentro de {1} HRS", evento, horas);
                        }
                        else
                        {
                            int minutos = fechaEvento.Minute - fechaActual.Minute;
                            mensaje = String.Format("{0} ocurrirá dentro de {1} min", evento, minutos);
                        }

                    }
                    else
                    {
                        int mes = fechaEvento.Month - fechaActual.Month;
                        mensaje = String.Format("{0} ocurrirá dentro de {1} Mes", evento, mes);
                    }
                }                
            }
            
            return mensaje;
        }        
    }
}