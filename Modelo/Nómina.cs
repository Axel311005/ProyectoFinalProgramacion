using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Nómina: Empleado
    {


        //Calculo de los Ingresos 

        

        public virtual double CalcularNorturnidad()
        {
            
            Nocturnidad = SalarioBase * 0.2;

            return Nocturnidad;
        }

        public virtual double CalcularRiesgoLaboral()
        {
            RiesgoLaboral = SalarioBase * 0.2;

            return RiesgoLaboral;
        }


        public virtual double CalcularSalarioPorDia()
        {
            double SalarioxDia = SalarioBase / 30;
            return SalarioxDia;
        }
        public  virtual double CalcularSalarioPorHora()
        {
           
            double SalarioxHora = CalcularSalarioPorDia() / 8;

            return SalarioxHora;
        }

        public virtual double CalcularPagoHorasExtras()
        {

            return CalcularSalarioPorHora()*2*HorasExtras;
        }

        public virtual double CalcularAntiguedad()
        {
            DateTime year = DateTime.Now;
            int YearActual = year.Year;

            int YearInicio = FechaContratacion.Year;
            int yearTotales= YearActual-YearInicio;
            if (yearTotales > 6)
            {
                return 0;
            }
            if (yearTotales < 4)
            {
                double antiguedad1 = SalarioBase / 12;
                return antiguedad1;
            }
            if (yearTotales > 5 || yearTotales<6)
            {
               double antiguedad2 = (CalcularSalarioPorDia() * 20) / 12;

                return antiguedad2;
            }
            
            else
                return 0;

        }

        public virtual double TotalIngresos()
        {
            double total = SalarioBase +CalcularRiesgoLaboral()+CalcularNorturnidad()
                +CalcularPagoHorasExtras()+ OtrosIngresos;

            return total;
        }

        public virtual double IngresoAnual()
        {
            return TotalIngresos() * 12;
        }


        // Calcular las deducciones 

        public virtual double CalcularInss()
        {
            return TotalIngresos() *0.07;
        }

        public virtual double CalcularIR()
        {

            if (IngresoAnual() > 500000.01)
            {
                double calculo3 = (IngresoAnual() - 500000)*0.30;
                double ir4 = (calculo3 + 82500) / 12;
                return ir4;
            }
            if (IngresoAnual() <= 500000 || IngresoAnual() >= 350000.01)
            {
                   double calculo2 = (IngresoAnual() - 350000)*0.25;
                    double ir3 = (calculo2 + 45000) / 12;
                   return ir3;

            }
            if (IngresoAnual() <= 350000 || IngresoAnual() >= 200000.01)
            {
                   double calculo1 = (IngresoAnual() - 200000) * 0.2;
                  double ir2 = (calculo1 + 15000)/12;
                   return ir2;
            }
            if (IngresoAnual() <= 200000 || IngresoAnual() >= 100000.01)
            {
                   double sobreexceso1 = 100000;
                   double TotalaDeducir1 = IngresoAnual() - sobreexceso1;
                   double ir1 = (TotalaDeducir1 * 0.15)/12;
                   return ir1;
            }
            else
            {
                return 0;
            }

        }

        public virtual double TotalDeducciones()
        {

            double totaldeducciones = CalcularIR() + CalcularInss() + OtrasDeducciones;

            return totaldeducciones;
        }

        public virtual double SalarioNeto()
        {
            return TotalIngresos()-TotalDeducciones();
        }


        

    }
}
