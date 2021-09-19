using System;

namespace Git1997
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio del proyecto!");
            Console.WriteLine("Proyecto para la administracion de empleados.");
            Console.WriteLine("-----------MENU--------------");
            Console.WriteLine("1) Agregar empleados.");
            Console.WriteLine("2) Lista de empleados.");
            Console.WriteLine("3) Salir");
            Console.WriteLine("Seleccione una opcion: ");
            char Opcion = char.Parse(Console.ReadLine());
            switch (Opcion)
            {
                case '1':
                    Console.WriteLine("------Agregar Empleado-----");
                    break;
                case '2':
                    Console.WriteLine("------List de Empleados-----");
                    break;
                case '3':
                    Console.WriteLine("------Saliendo-----");
                    break;
                default:
                    Console.WriteLine("------Opcion Invalida----");
                    break;
            }
        }
    }
}
