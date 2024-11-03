using SharedModels;

namespace Nomina_API.Repository.IRepository
{
    public interface INominaRepository : IRepository<Nomina>
    {
        Task<Nomina> UpdateAsync(Nomina entity);
        Task<double> GetSalarioNeto(int id);
        Task<Nomina> ObtenerRegistroNomina(int id);
        Task<bool>  ObtenerNominaPorNumeroEmpleado(int id);

    }
}
