namespace OOP.LocationGenerator
{
    internal class Location
    {
        private protected string floorMaterial;
        private protected string name;
        private protected string musicalTheme;

        public void setFloorMaterial(string floorMaterial)
        {
            this.floorMaterial = floorMaterial;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setMusicalTheme(string musicalTheme)
        {
            this.musicalTheme = musicalTheme;
        }
        public string toString()
        {
            return string.Format("Location(name={0}, floorMaterial={1}, musicalTheme={2})', this.getName(), this.getId())", this.name, this.floorMaterial, this.musicalTheme);
        }
    }
}
