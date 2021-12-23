using System;
namespace Git1997
{
    class Gerente : Empleado
    {
        private const double BONO_GERENTE = 0.15;
        public Gerente()
        {

        }
        public Gerente(string tipoEmpleado, string nombre, double salario, char genero)
        {
            Salario = salario;
            Nombre = nombre;
            Genero = genero;
            TipoEmpleado = tipoEmpleado;
        }
        public override double CalCularSalario()
        {
            double BonoIncentivo = Salario * 0.05;
            double BonoGerente = Salario * BONO_GERENTE;
            return Salario + BonoIncentivo + BonoGerente;
        }
     
    }
}
