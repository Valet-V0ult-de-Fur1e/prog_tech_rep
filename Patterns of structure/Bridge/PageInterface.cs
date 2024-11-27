namespace OOP.Patterns_of_structure.Bridge
{
    abstract class PageInterface
    {
        protected ColorThemeInterface ColorTheme { get; set; }
        public PageInterface(ColorThemeInterface newColorThemeInterface) 
        {
            ColorTheme = newColorThemeInterface;
        }
        public abstract void getContent();
    }
}
