using System.Threading.Tasks;
using UnitOfWork.Repositories;

namespace UnitOfWork
{
    public interface IAppUnitOfWork : IBaseUnitOfWork
    {
        IThemeRepository ThemeRepository { get; }
    }
}