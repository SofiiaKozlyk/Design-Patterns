using ChainOfResponsibilityClassLibrary;
using MediatorClassLibrary;
using ObserverClassLibrary;
using StrategyClassLibrary;
using MementoClassLibrary;

// Task1 
Console.WriteLine("---------Task 1");
SupportHandler firstHandler = new FirstSupportHandler();
SupportHandler secondHandler = new SecondSupportHandler();
SupportHandler thirdHandler = new ThirdSupportHandler();
SupportHandler fourthHandler = new FourthSupportHandler();

firstHandler.SetNextHandler(secondHandler);
secondHandler.SetNextHandler(thirdHandler);
thirdHandler.SetNextHandler(fourthHandler);
bool continueSelection = true;

while (continueSelection)
{
    Console.WriteLine("If you have any problems, please contact support:");
    Console.WriteLine("1 - Technical problem #1.");
    Console.WriteLine("2 - Technical problem #2.");
    Console.WriteLine("3 - Technical problem #3");
    Console.WriteLine("4 - Technical problem #4");
    Console.WriteLine("0 - Exit");

    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
        case "2":
        case "3":
        case "4":
            firstHandler.HandleRequest(input);
            break;
        case "0":
            continueSelection = false;
            break;
        default:
            Console.WriteLine("Incorrect option entered, please try again.");
            break;
    }
}

// Task2
Console.WriteLine("---------Task 2");
Runway[] runways = { new Runway(), new Runway() };
Aircraft aircraft1 = new Aircraft("Plane1");
Aircraft aircraft2 = new Aircraft("Plane2");
Aircraft aircraft3 = new Aircraft("Plane3");
Aircraft[] aircrafts = { aircraft1, aircraft2, aircraft3 };

CommandCentre commandCentre = new CommandCentre(runways, aircrafts);
commandCentre.LandingAircraft(aircraft1);
commandCentre.LandingAircraft(aircraft1);
Console.WriteLine("---");
commandCentre.LandingAircraft(aircraft2);
Console.WriteLine("---");
commandCentre.LandingAircraft(aircraft3);
Console.WriteLine("---");
commandCentre.TakingOffAircraft(aircraft1);
commandCentre.TakingOffAircraft(aircraft1);
Console.WriteLine("---");
commandCentre.LandingAircraft(aircraft3);

// Task3
Console.WriteLine("---------Task 3");
var h1 = new LightElementNode("h1", "block", "closed", new List<string>());
var h1Text = new LightTextNode("Hello, world!");
h1.Add(h1Text);
IEventListener click = new EventListener("click", (LightElementNode) => Console.WriteLine($"{LightElementNode.Tag} was clicked!"));
h1.AddEventListener(click);
h1.InvokeEvent("click");
IEventListener mouseover = new EventListener("mouseover", (LightElementNode) => Console.WriteLine($"Mouse is over {LightElementNode.Tag}!"));
h1.AddEventListener(mouseover);
h1.InvokeEvent("mouseover");

// Task4 
Console.WriteLine("---------Task 4");
var fileSystemImageLoad = new FileSystemImageLoad();
var networkImageLoad = new NetworkImageLoad();
Image image = new Image(fileSystemImageLoad);
image.LoadImage("D:\\image.png");
image.SetImageLoadStrategy(networkImageLoad);
image.LoadImage("https://i.natgeofe.com/n/4f5aaece-3300-41a4-b2a8-ed2708a0a27c/domestic-dog_thumb_square.jpg");

// Task5
Console.WriteLine("---------Task 5");
TextDocument document = new TextDocument("Document1", "Initial content");
TextEditor editor = new TextEditor(document);
Console.WriteLine("Content: " + document);
editor.Save();
document.Content = "Modified content";
Console.WriteLine("Content: " + document);
editor.Save();
document.Content = "New content";
Console.WriteLine("Content: " + document);
editor.Undo();
editor.Undo();
editor.Undo();