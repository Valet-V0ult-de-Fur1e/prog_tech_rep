using OOP.OOP.Objects.Buildings;
using OOP.OOP.Objects.Items.Weapons;
using OOP.OOP.Objects.Units;

namespace OOP
{
    internal class Test
    {
        static void testOOP()
        {
            Bow wood_bow = new Bow("wood bow", -1, 2, 10, 90);
            Archer elf_archer = new Archer("Elf_Archer", 0, 0, 100, 100, wood_bow);
            Bow orc_bow = new Bow("orc bow", -1, -2, 5, 2);
            Archer orc_archer = new Archer("Orc_Archer", 0, 1, 200, 100, orc_bow);
            
            elf_archer.attack(orc_archer);
            elf_archer.attack(orc_archer);
            elf_archer.attack(orc_archer);

            MobileHome carriage = new MobileHome("Carriage", 10, 10, true);
            carriage.moveTo(10, 11);

            Fort fort = new Fort("Frozen_Fort", 10, -10, true);
            fort.attack(orc_archer);
            fort.attack(elf_archer);
        }
    }
}