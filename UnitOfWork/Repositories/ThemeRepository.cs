using System;

namespace UnitOfWork.Repositories
{
    public class ThemeRepository : IThemeRepository
    {
        // These would obviously be database queries
        public void GetMostUsedTheme() => throw new NotImplementedException();
        public void GetCoolThemes() => throw new NotImplementedException();
        public void GetMyCurrentTheme() => throw new NotImplementedException();
    }
}