﻿using System;
namespace Git1997
{
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
