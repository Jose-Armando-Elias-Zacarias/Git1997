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
                    Console.WriteLine("Ingrese el Nombre del Empleado");
                    string Nombre = Console.ReadLine();
                    Gerente gerente = new Gerente(Gerente, Nombre, Salario, Genero, Puesto);
                    Console.WriteLine("Ingrese el genero del empleado");
                    string Genero = Console.ReadLine();
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
                            break;
                        case '2':
                            Console.WriteLine();
                            foreach (var ger  in  gerentes )
                            {
                                Console.WriteLine(ger.Nombre);
                                Consola.WriteLine(ger.TipoEmpleado);
                                Consola.WriteLine(ger.PuestoGerente);
                                Consola.WriteLine(ger.CalcularSalario());
                            }
                            break;
                        default:
                            Console.WriteLine("Tipo Invalido. ");
                            break;
                    }
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
