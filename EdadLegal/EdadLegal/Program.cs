using System;

namespace EdadLegal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su nombre y pulse Enter:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba su edad y pulse Enter:");
            int edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Hola " + nombre + "," + " eres mayor de edad!");
                 //Se puede añadir un Console.ReadLine(); aquí también.
            }
            else
            {
                Console.WriteLine("Hola " + nombre + "," + " no eres mayor de edad... :(");
                 //Se puede añadir un Console.ReadLine(); aquí también.
            }
            Console.ReadLine();
        }
    }
}
