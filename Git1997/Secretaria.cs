using System;
using System.Collections.Generic;
using System.Text;

namespace Git1997
{
    class Secretaria : Empleado
    { 
        public Secretaria()
        {

        }

        public Secretaria(string tipoSecretaria, string area)
        {
            TipoSecretaria = tipoSecretaria;
            Area = area;
        }

        public String TipoSecretaria { get; set; }
        public String Area { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD

        public override double CalCularSalario()
=======
        public override double CalcularSalario()
>>>>>>> 3e2ef74 (se agrego la clase secretaria)
=======
        public override double CalcularSalario()
>>>>>>> 3e2ef74 (se agrego la clase secretaria)
        {
            return base.Salario * 1.05;
        }
    }
}
