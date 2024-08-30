using Task4Lab2;

class Program
{
    static void Main(string[] args)
    {
        // Створення вірусу першого покоління
        Virus firstGenerationVirus = new Virus(1.5f, 1, "First Gen Virus", "Type A");

        // Створення вірусів другого покоління
        Virus secondGenerationVirus1 = (Virus)firstGenerationVirus.Copy();
        secondGenerationVirus1.name = "Second Gen Virus 1";
        Virus secondGenerationVirus2 = (Virus)firstGenerationVirus.Copy();
        secondGenerationVirus2.name = "Second Gen Virus 2";

        Virus thirdGenerationVirus1 = (Virus)secondGenerationVirus1.Copy();
        thirdGenerationVirus1.name = "Third Gen Virus 1";
        Virus thirdGenerationVirus2 = (Virus)secondGenerationVirus1.Copy();
        thirdGenerationVirus2.name = "Third Gen Virus 2";
        Virus thirdGenerationVirus3 = (Virus)secondGenerationVirus2.Copy();
        thirdGenerationVirus3.name = "Third Gen Virus 3";

        Console.WriteLine(firstGenerationVirus);

    }
}