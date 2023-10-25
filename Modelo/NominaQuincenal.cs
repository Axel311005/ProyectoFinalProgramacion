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

        public override double CalcularSalarioPorDia()
        {
            double SalarioxDia = SalarioBase / 30;
            return SalarioxDia;
        }
        public override double CalcularSalarioPorHora()
        {
            double SalarioxHora = CalcularSalarioPorDia() / 8;

            return SalarioxHora;
        }

        public override double CalcularPagoHorasExtras()
        {
            return base.CalcularPagoHorasExtras();
        }

        public override double CalcularAntiguedad()
        {
            
            if (YearsTrabajados > 6)
            {
                return 0;
            }
            if (YearsTrabajados < 4)
            {
                double antiguedad1 = SalarioBase / 24;
                return antiguedad1;
            }
            if (YearsTrabajados > 5 || YearsTrabajados < 6)
            {
                double antiguedad2 = (CalcularSalarioPorDia() * 20) / 24;

                return antiguedad2;
            }

            else
                return 0;
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
            double anual = IngresoAnual();
            double ir = 0;  

            if (anual > 500000.01)
            {
                double calculo3 = (anual - 500000) * 0.30;
                ir = (calculo3 + 82500) / 24;
            }
            else if (anual >= 350000.01)
            {
                double calculo2 = (anual - 350000) * 0.25;
                ir = (calculo2 + 45000) / 24;
            }
            else if (anual >= 200000.01)
            {
                double calculo1 = (anual - 200000) * 0.2;
                ir = (calculo1 + 15000) / 24;
            }
            else if (anual >= 100000.01)
            {
                double sobreexceso1 = 100000;
                double TotalaDeducir1 = anual - sobreexceso1;
                ir = (TotalaDeducir1 * 0.15) / 24;
            }
            else
            {
                ir = 0; 
            }

            return ir;
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
