using OOP.Spawner.Interfaces;

namespace OOP.LocationGenerator.OutsideBuilder
{
    internal class OutsideBuilder : LocationBuilder
    {
        private protected Location location;

        public OutsideBuilder()
        {
            this.location = new Location();
        }

        public void buildFloorMaterial()
        {
            location.setFloorMaterial("земля");
        }

        public void buildName()
        {
            location.setName("поле");
        }

        public void buildSetMusicalTheme()
        {
            location.setMusicalTheme("По полям синий трактор едет к нам.mp3");
        }

        public Location getResult()
        {
            return location;
        }
    }
}
