using FactoryMethodClassLibrary;
using AbstractFactoryClassLibrary;
using SingletonClassLibrary;
using PrototypeClassLibrary;
using BuilderClassLibrary;
//Task1
IBuySubscription webSite = new WebSite();
Subscription domesticSubscription = webSite.BuySubscription();
domesticSubscription.DisplayInfo();
Console.WriteLine("---------");

//Task2
IDeviceFactory iproneFactory = new IProneFactory();
Device smartphone = iproneFactory.CreateSmartphone("15 Pro Max");
smartphone.DisplayInfo();
Console.WriteLine("---------");

//Task3
Authenticator a1 = Authenticator.GetInstance();
Authenticator a2 = Authenticator.GetInstance();
if (a1 == a2)
{
    Console.WriteLine("Singleton works, both variables contain the same instance.");
}
else
{
    Console.WriteLine("Singleton failed, variables contain different instances.");
}
a1.CheckAuthentication("admin", "111111");
Console.WriteLine("---------");

//Task4
Virus originalVirus = new Virus(1.5, 2, "Virus", "VirusSpecies1");
Virus virus1 = new Virus(0.8, 1, "Virus1", "VirusSpecies1 Variant");
Virus virus2 = new Virus(0.7, 1, "Virus2", "VirusSpecies1 Variant");

originalVirus.AddChild(virus1);
originalVirus.AddChild(virus2);

virus1.AddChild(new Virus(0.5, 0, "Virus1.1", "VirusSpecies1 Variant"));
virus2.AddChild(new Virus(0.6, 0, "Virus2.1", "VirusSpecies1 Variant"));

Virus clonedVirus = (Virus)originalVirus.Clone();
Console.WriteLine("Original Virus Info:");
originalVirus.DisplayInfo();
Console.WriteLine("\nCloned Virus Info:");
clonedVirus.DisplayInfo();
Console.WriteLine("---------");

//Task5
HeroBuilder heroBuilder = new HeroBuilder();
EnemyBuilder enemyBuilder = new EnemyBuilder();
Director director = new Director();
Hero hero = director.CreateHero(heroBuilder);
hero.DisplayInfo();
Console.WriteLine();
Enemy enemy = director.CreateEnemy(enemyBuilder);
enemy.DisplayInfo();


