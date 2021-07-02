using Factory.Factories;

namespace Factory.Themes
{
    public class WebsiteBackground
    {
        public WebsiteBackground(IUIFactory uiFactory) => uiFactory.CreateTheme();
    }
        
    public class WebsiteTextColor
    {
        public WebsiteTextColor(IUIFactory uiFactory) => uiFactory.CreateTheme();
    }
}