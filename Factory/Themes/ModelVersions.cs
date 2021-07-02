using Factory.Factories;

namespace Factory.Themes
{
    public class LightTheme : IUIFactory
    {
        public Theme CreateTheme() => new() {ThemeType = "Light Theme"};
    }

    public class DarkTheme : IUIFactory
    {
        public Theme CreateTheme() => new() {ThemeType = "Dark Theme"};
    }
}