using SharedModels;

namespace Nomina_API.Repository.IRepository
{
    public interface IDeduccionRepository: IRepository<Deduccion>
    {

        Task<Deduccion> UpdateAsync(Deduccion entity);
    }
}
