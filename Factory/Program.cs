using System;
using Factory.Themes;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            new WebsiteBackground(new DarkTheme());
            new WebsiteBackground(new LightTheme());
            new WebsiteTextColor(new DarkTheme());
            
        }
    }
}