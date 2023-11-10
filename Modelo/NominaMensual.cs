using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System;





namespace Modelo
{
    public class NominaMensual
    {


        //Calculo de los Ingresos 

        

        //public virtual double CalcularNorturnidad()
        //{
            
        //    Nocturnidad = SalarioBase * 0.2;

        //    return Nocturnidad;
        //}

        //public virtual double CalcularRiesgoLaboral()
        //{
        //    RiesgoLaboral = SalarioBase * 0.2;

        //    return RiesgoLaboral;
        //}


        //public virtual double CalcularSalarioPorDia()
        //{
        //    double SalarioxDia = SalarioBase / 30;
        //    return SalarioxDia;
        //}
        //public  virtual double CalcularSalarioPorHora()
        //{
           
        //    double SalarioxHora = CalcularSalarioPorDia() / 8;

        //    return SalarioxHora;
        //}

        //public virtual double CalcularPagoHorasExtras()
        //{
        //    if(HorasExtras != 0)
        //    {
        //        return CalcularSalarioPorHora() * 2 * HorasExtras;
        //    }
        //    else
        //        return 0;
            
        //}

        //public virtual double CalcularAntiguedad()
        //{
        //    double antiguedad = 0;

        //    if (YearsTrabajados >= 1 && YearsTrabajados <= 3)
        //    {
        //        antiguedad = SalarioBase / 12;
        //    }
        //    else if (YearsTrabajados >= 4 && YearsTrabajados <= 6)
        //    {
        //        antiguedad = (CalcularSalarioPorDia() * 20) / 12;
        //    }

        //    return antiguedad;

        //}

        //public virtual double TotalIngresos()
        //{
        //    double total = SalarioBase +CalcularRiesgoLaboral()+CalcularNorturnidad()
        //        + CalcularPagoHorasExtras() + OtrosIngresos;

        //    return total;
        //}

        //public virtual double IngresoAnual()
        //{
        //    return TotalIngresos() * 12;
        //}


        //// Calcular las deducciones 

        //public virtual double CalcularInss()
        //{
        //    return TotalIngresos() *0.07;
        //}

        //public virtual double CalcularIR()
        //{


        //    double anual = IngresoAnual();
        //    double ir = 0;  

        //    if (anual > 500000.01)
        //    {
        //        double calculo3 = (anual - 500000) * 0.30;
        //        ir = (calculo3 + 82500) / 12;
        //    }
        //    else if (anual >= 350000.01)
        //    {
        //        double calculo2 = (anual - 350000) * 0.25;
        //        ir = (calculo2 + 45000) / 12;
        //    }
        //    else if (anual >= 200000.01)
        //    {
        //        double calculo1 = (anual - 200000) * 0.2;
        //        ir = (calculo1 + 15000) / 12;
        //    }
        //    else if (anual >= 100000.01)
        //    {
        //        double sobreexceso1 = 100000;
        //        double TotalaDeducir1 = anual - sobreexceso1;
        //        ir = (TotalaDeducir1 * 0.15) / 12;
        //    }

        //    return ir;
        //}

        //public virtual double TotalDeducciones()
        //{

        //    double totaldeducciones = CalcularIR() + CalcularInss() + OtrasDeducciones;

        //    return totaldeducciones;
        //}

        //public virtual double SalarioNeto()
        //{
        //    return TotalIngresos()-TotalDeducciones();
        //}

        
    }
}
