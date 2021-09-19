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
            Console.WriteLine("2) Salir");
        }
    }
    abstract class Empleado
    {
        public Empleado()
        {

        }

        protected Empleado(string tipoEmpleado, string nombre, char genero, double salario)
        {
            TipoEmpleado = tipoEmpleado;
            Nombre = nombre;
            Genero = genero;
            Salario = salario;
        }

        public string TipoEmpleado { get; set; }
        public string Nombre { get; set; }
        public char Genero { get; set; }
        public double Salario { get; set; }
        public abstract double CalCularSalario();



    }
}
