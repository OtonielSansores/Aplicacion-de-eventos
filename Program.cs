using AplicaciónEventos.Interfaces;
using System;

namespace AplicaciónEventos
{
    public class Program
    {

        static void Main(string[] args)
        {
            IVerificarEvento verificarEvento = new VerificarEvento();
            IMensaje mensaje = new Mensaje();

            LeerArchivo leerArchivo = new LeerArchivo();
            CalcularFecha calcularFecha = new CalcularFecha(verificarEvento, mensaje);
            string[] eventos = leerArchivo.ObtenerListaEventos(@"C: \Users\otoniel.sansores\source\repos\AplicaciónEventos\AplicaciónEventos\texto.txt");
            calcularFecha.ObtenerFechaEvento(eventos);
            
            Console.ReadKey();
        }
    }
}