using SharedModels;

namespace Nomina_API.Repository.IRepository
{
    public interface IEmpleadoRepository : IRepository<Empleado>
    {
        Task<Empleado> UpdateAsync(Empleado entity);

    }
}
