using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class NominaQuincenal: Nómina
    {
        public double SalarioQuincenal()
        {
            return SalarioBase / 2;
        }
        public override double CalcularNorturnidad()
        {
            return (base.CalcularNorturnidad())/2;
        }

        public override double CalcularRiesgoLaboral()
        {
            return (base.CalcularRiesgoLaboral())/2;
        }

        public override double CalcularPagoHorasExtras()
        {
            return base.CalcularPagoHorasExtras();
        }

        public override double CalcularAntiguedad()
        {
            return (base.CalcularAntiguedad())/2;
        }

        public override double TotalIngresos()
        {

            double total = SalarioQuincenal() + CalcularRiesgoLaboral() + CalcularNorturnidad()
                + CalcularPagoHorasExtras() + OtrosIngresos;

            return total;

           
        }

        public override double IngresoAnual()
        {
            return TotalIngresos()*24;
        }

        public override double CalcularInss()
        {
            return TotalIngresos() * 0.07;
        }

        public override double CalcularIR()
        {

            if (IngresoAnual() > 500000.01)
            {
                double calculo3 = (IngresoAnual() - 500000) * 0.30;
                double ir4 = (calculo3 + 82500) / 24;
                return ir4;
            }
            if (IngresoAnual() <= 500000 || IngresoAnual() >= 350000.01)
            {
                double calculo2 = (IngresoAnual() - 350000) * 0.25;
                double ir3 = (calculo2 + 45000) / 24;
                return ir3;

            }
            if (IngresoAnual() <= 350000 || IngresoAnual() >= 200000.01)
            {
                double calculo1 = (IngresoAnual() - 200000) * 0.2;
                double ir2 = (calculo1 + 15000) / 24;
                return ir2;
            }
            if (IngresoAnual() <= 200000 || IngresoAnual() >= 100000.01)
            {
                double sobreexceso1 = 100000;
                double TotalaDeducir1 = IngresoAnual() - sobreexceso1;
                double ir1 = (TotalaDeducir1 * 0.15) / 24;
                return ir1;
            }
            else
            {
                return 0;
            }

        }

        public override double TotalDeducciones()
        {

            double totaldeducciones = CalcularIR() + CalcularInss() + OtrasDeducciones;

            return totaldeducciones;
        }

        public override double SalarioNeto()
        {
            return TotalIngresos() - TotalDeducciones();
        }
    }
}
