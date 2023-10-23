using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public interface IDeducciones
    {
        public double INSS { get; set; }
        public double IR { get; set; }
        public double OtrasDeducciones { get; set; }


    }
}
