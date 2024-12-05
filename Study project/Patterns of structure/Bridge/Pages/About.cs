namespace OOP.Patterns_of_structure.Bridge.Pages
{
    internal class About : PageInterface
    {
        public About(ColorThemeInterface newColorThemeInterface) : base(newColorThemeInterface)
        {
        }

        public override void getContent()
        {
            Console.WriteLine("About page in " + this.ColorTheme.getColor());
        }
    }
}
