using Task2;

class Program
{
    static void Main()
    {
        Hero warrior = new Warrior();
        Hero mage = new Mage();
        Hero paladin = new Paladin();

        warrior = new Armor(warrior);
        warrior = new Weapon(warrior);
        warrior = new Artifact(warrior);

        mage = new Weapon(mage);
        mage = new Artifact(mage);

        paladin = new Armor(paladin);
        paladin = new Artifact(paladin);

        Console.WriteLine("Warrior with inventory:");
        warrior.Display();

        Console.WriteLine("\nMage with inventory:");
        mage.Display();

        Console.WriteLine("\nPaladin with inventory:");
        paladin.Display();
    }
}