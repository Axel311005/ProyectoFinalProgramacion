using Microsoft.EntityFrameworkCore;
using Nomina_API.Data;
using Nomina_API.Repository.IRepository;
using SharedModels;

namespace Nomina_API.Repository
{
    public class DeduccionRepository : Repository<Deduccion>, IDeduccionRepository
    {
        private readonly EmpresaContext _context;

        public DeduccionRepository(EmpresaContext context) : base(context) 
        {
            _context = context;
        }

        public async Task<double> CalcularInss(double TotalIngresos)
        {
            return await Task.Run(() => TotalIngresos * 0.07);
        }

        public async Task<double> CalcularIr(double IngresoAnual)
        {
            return await Task.Run(() => CalcularIrSinAsync(IngresoAnual));
        }

        private double CalcularIrSinAsync(double IngresoAnual)
        {
           
            double ir = 0;

            if (IngresoAnual > 500000.01)
            {
                double calculo3 = (IngresoAnual - 500000) * 0.30;
                ir = (calculo3 + 82500) / 12;
            }
            else if (IngresoAnual >= 350000.01)
            {
                double calculo2 = (IngresoAnual - 350000) * 0.25;
                ir = (calculo2 + 45000) / 12;
            }
            else if (IngresoAnual >= 200000.01)
            {
                double calculo1 = (IngresoAnual - 200000) * 0.2;
                ir = (calculo1 + 15000) / 12;
            }
            else if (IngresoAnual >= 100000.01)
            {
                double sobreexceso1 = 100000;
                double TotalaDeducir1 = IngresoAnual - sobreexceso1;
                ir = (TotalaDeducir1 * 0.15) / 12;
            }

            return ir;
        }
         public async Task<double> CalTotalDeduc(double INSS, double IR, double otrasDeducciones)
        {
            return await Task.Run(() => INSS + IR + otrasDeducciones);
        }

        public async Task<double> GetSalarioTotal(int id)
        {
            return await _context.Set<Ingreso>()
                             .Where(i => i.NumeroEmpleado == id)
                             .Select(i => i.TotalIngresos)
                             .FirstOrDefaultAsync();
        }

        public async Task<Deduccion> ObtenerRegistroDeduccion(int id)
        {
           return _context.Deducciones.FirstOrDefault(i => i.NumeroEmpleado == id);
            
        }

        public async Task<Deduccion> UpdateAsync(Deduccion entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> ObtenerDeduccionPorNumeroEmpleado(int id)
        {
            return await _context.Deducciones.AnyAsync(i => i.NumeroEmpleado == id);
        }
    }
}
