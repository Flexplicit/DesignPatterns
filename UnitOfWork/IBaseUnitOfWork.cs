using System.Threading.Tasks;

namespace UnitOfWork
{
    public interface IBaseUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}