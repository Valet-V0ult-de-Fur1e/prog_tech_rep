namespace OOP.Patterns_of_structure.Bridge.Pages
{
    internal class Contacts : PageInterface
    {
        public Contacts(ColorThemeInterface newColorThemeInterface) : base(newColorThemeInterface)
        {
        }

        public override void getContent()
        {
            Console.WriteLine("Contacts page in " + this.ColorTheme.getColor());
        }
    }
}
