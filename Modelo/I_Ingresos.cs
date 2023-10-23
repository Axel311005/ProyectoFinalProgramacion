using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public interface I_Ingresos
    {
        public double Antiguedad { get; set; }
        public double RiesgoLaboral { get; set; }
        public double Nocturnidad { get; set; }
        public double OtrosIngresos { get; set; }
        public int HorasExtras { get; set; }


    }
}
