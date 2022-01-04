using System;
using System.Collections.Generic;

namespace Git1997
{
    class Program
    {
        static List<Gerente> gerentes = new List<Gerente>();
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
                    Console.WriteLine("Ingrese el Nombre del Empleado");
                    string Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el genero del empleado");
                    char Genero = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Ingrese el salario base del empleado");
                    double Salario = double.Parse(Console.ReadLine());
                    Console.WriteLine("Seleccione el tipo de empleado a crear");
                    Console.WriteLine("/t 1) Gerente");
                    Console.WriteLine("/t 1) Vededor");
                    Console.WriteLine("Tipo: ");
                    char TipoEmpleado = char.Parse(Console.ReadLine());
                    switch (TipoEmpleado)
                    {
                        case '1':
                            Console.WriteLine("Ingrese el puesto del Gerente: ");
                            string Puesto = Console.ReadLine();
                            Gerente gerente = new Gerente("Gerente", Nombre,Salario, Genero);
                            gerentes.Add(gerente);
                            break;
                        case '2':
                            Console.WriteLine();
                            break;
                        default:
                            Console.WriteLine("Tipo Invalido. ");
                            break;
                    }
                    break;
                case '2':
                    Console.WriteLine("------List de Empleados de la empresa-----");
                    foreach (var ger in gerentes)
                    {
                        Console.WriteLine("Datos del Gerente:");
                        Console.WriteLine($"\tNombre: {ger.Nombre}");
                        Console.WriteLine($"\tTipo gerente: {ger.TipoEmpleado}");
                        Console.WriteLine($"\tPuesto: {ger.Genero}");

                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine();

                    }
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
