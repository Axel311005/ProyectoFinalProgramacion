using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Nomina_API.Data;
using Nomina_API.Repository.IRepository;
using SharedModels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace Nomina_API.Repository
{
    public class IngresoRepository : Repository<Ingreso>, I_IngresoRepository
    {
        private readonly EmpresaContext _context;
       

        public IngresoRepository(EmpresaContext context) : base(context)
        {
            _context = context;
            
        }

        public async Task<double> CaclHorasExtras(double horas, double salarioBase)
        {
            return await Task.Run(() => ((salarioBase / 30) / 8) * 2 * horas);
        }

        public async Task<double> CalcAntiguedad(int years, double salarioBase)
        {
            return await Task.Run(() =>
            {
                double antiguedad = 0;

                if (years >= 1 && years <= 3)
                {
                    antiguedad = salarioBase / 12;
                }
                else if (years >= 4 && years <= 6)
                {
                    antiguedad = ((salarioBase / 30) * 20) / 12;
                }

                return antiguedad;
            });
        }

        public async Task<double> CalcNoctunidadRisgoLab(double salarioBase)
        {
            return await Task.Run(() => salarioBase * 0.2);
        }

        public async Task<double> CalSalario(double salarioBase, double antiguedad, double riesgoLaboral, double nocturnidad, double horasExtras, double otrosIngresos)
        {
            return await Task.Run(() => salarioBase + riesgoLaboral + antiguedad + nocturnidad + horasExtras + otrosIngresos);
        }

        public async Task<int> GetYearsTrabajadosById(int id)
        {
            return await _context.Set<Empleado>()
                        .Where(e => e.NumeroEmpleado == id)
                        .Select(e => e.YearsTrabajados)
                        .FirstOrDefaultAsync();
        }

        public async Task<bool> ObtenerIngresoPorNumeroEmpleado(int id)
        {
            return await _context.Ingresos.AnyAsync(i => i.NumeroEmpleado == id);
        }

        public async Task<Ingreso> ObtenerRegistroIngreso(int id)
        {

            return _context.Ingresos.FirstOrDefault(i => i.NumeroEmpleado == id);
            
           

        }

        public async Task<Ingreso> UpdateAsync(Ingreso entity)
        {
            
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }




    }
}
