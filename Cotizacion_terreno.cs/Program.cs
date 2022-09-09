using System;


namespace Cotizacion_terreno.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            int operacion;

            Console.Write("Ingrese el ancho del terreno: ");
            int ancho = Convert.ToInt32(Console.ReadLine());
                
            Console.Write("Ingrese la longitud del terreno: ");
            int Longitud = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el costo del metro cuadrado del terreno: ");
            int costo = Convert.ToInt32(Console.ReadLine());

            operacion = ancho * Longitud * costo;

            Console.WriteLine("El valor del terreno es: " + operacion);

            
            Console.ReadLine();



        }
    }
}
