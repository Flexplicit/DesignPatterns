using UnitOfWork.Repositories;

namespace UnitOfWork
{
    public class AppUnitOfWork : BaseUnitOfWork, IAppUnitOfWork
    {
        public IThemeRepository ThemeRepository => GetUowObject(() => new ThemeRepository());
    }
}