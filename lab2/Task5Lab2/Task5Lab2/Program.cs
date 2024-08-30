using Task5Lab2;

var heroBuilder = new HeroBuilder();
var enemyBuilder = new EnemyBuilder();

var director = new Director();

director.Builder = heroBuilder;

director.CreateFullFeaturedPerson(180, 80, "Combat", "Sword", "Blue", "Brown");
heroBuilder.AddActions("Saving the cat from dogs");
heroBuilder.AddActions("Killing some russians"); 
heroBuilder.AddActions("Saving humanity");
var fullFeaturedHero = heroBuilder.GetHero();
Console.WriteLine("Full Featured Hero:");
Console.WriteLine(fullFeaturedHero.ListParts());

director.Builder = enemyBuilder;

director.CreateFullFeaturedPerson(170, 70, "Stealth", "Dagger", "Red", "Black");
enemyBuilder.AddActions("Causing chaos");
enemyBuilder.AddActions("Drug trading");
var fullFeaturedEnemy = enemyBuilder.GetEnemy();
Console.WriteLine("Full Featured Enemy:");
Console.WriteLine(fullFeaturedEnemy.ListParts());

Console.ReadKey();