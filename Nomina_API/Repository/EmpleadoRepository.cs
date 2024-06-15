using Microsoft.EntityFrameworkCore;
using Nomina_API.Data;
using Nomina_API.Repository.IRepository;
using SharedModels;

namespace Nomina_API.Repository
{
    public class EmpleadoRepository : Repository<Empleado>, IEmpleadoRepository
    {
        private readonly EmpresaContext _context;

        public EmpleadoRepository(EmpresaContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Empleado> UpdateAsync(Empleado entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

        
    }
}
