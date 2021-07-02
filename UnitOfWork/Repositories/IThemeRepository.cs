namespace UnitOfWork.Repositories
{
    public interface IThemeRepository
    {
        public void GetMostUsedTheme();
        
        public void GetCoolThemes();

        public void GetMyCurrentTheme();
    }
}