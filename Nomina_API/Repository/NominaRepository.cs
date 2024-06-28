using Microsoft.EntityFrameworkCore;
using Nomina_API.Data;
using Nomina_API.Repository.IRepository;
using SharedModels;

namespace Nomina_API.Repository
{
    public class NominaRepository : Repository<Nomina>, INominaRepository
    {

        private readonly EmpresaContext _context;


        public NominaRepository(EmpresaContext context) : base(context)
        {
            _context = context;

        }

        public async Task<double> GetSalarioNeto(int id)
        {
            var ingreso = await _context.Set<Ingreso>()
                                    .Where(i => i.NumeroEmpleado == id)
                                    .Select(i => i.TotalIngresos)
                                    .FirstOrDefaultAsync();

            var deducciones = await _context.Set<Deduccion>()
                                            .Where(d => d.NumeroEmpleado == id)
                                            .Select(d => d.TotalDeducciones)
                                            .FirstOrDefaultAsync();

            var SalarioNeto = ingreso - deducciones;

            return SalarioNeto;
        }

        public async Task<bool> ObtenerNominaPorNumeroEmpleado(int id)
        {
            return await _context.Nominas.AnyAsync(i => i.NumeroEmpleado == id);
        }

        public async Task<Nomina> ObtenerRegistroNomina(int id)
        {
           return _context.Nominas.FirstOrDefault(i => i.NumeroEmpleado == id);
           
        }

        public async Task<Nomina> UpdateAsync(Nomina entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
