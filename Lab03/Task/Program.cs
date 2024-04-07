using AdapterClassLibrary;
using DecoratorClassLibrary;
using BridgeClassLibrary;
using ProxyClassLibrary;
using CompositeClassLibrary;
using FlyweightClassLibrary;

// Task1
string baseDirectory = AppContext.BaseDirectory;
string fullPath = System.IO.Path.Combine(baseDirectory, "..", "..", "..",
"..", $"text.txt");
fullPath = System.IO.Path.GetFullPath(fullPath);

Logger logger = new Logger();
logger.Log("Hello, World!");
FileWriter writer = new FileWriter(fullPath);
FileLogger fileLogger = new FileLogger(writer);
fileLogger.Warn("Some Warning");
fileLogger.Log("Hello, World!");
writer.Close();
var text = File.ReadAllText(fullPath);
Console.WriteLine(text);
Console.WriteLine("---------");

//Task2
Hero palladin = new Palladin(50, 55);
palladin.DisplayInfo();
palladin = new Shield(palladin);
palladin.DisplayInfo();
palladin = new Sword(palladin);
palladin.DisplayInfo();
Console.WriteLine("---------");

//Task3
Triangle triangle = new Triangle(new RasterRenderer());
triangle.Draw();
Console.WriteLine("---------");

//Task4
ISmartTextReader reader = new SmartTextReader();
var textArray = reader.ReadText(fullPath);
for (int i = 0; i < textArray.GetLength(0); i++)
{
    for (int j = 0; j < textArray.GetLength(1); j++)
    {
        Console.Write(textArray[i, j]);
    }
    Console.WriteLine();
}

ISmartTextReader checker = new SmartTextChecker();
textArray = checker.ReadText(fullPath);
ISmartTextReader locker = new SmartTextReaderLocker("text");
textArray = locker.ReadText(fullPath);
Console.WriteLine("---------");

//Task5
var html = new LightElementNode("html", "block", "closed", new List<string>());
var head = new LightElementNode("head", "block", "closed", new List<string>());
var body = new LightElementNode("body", "block", "closed", new List<string>());

var title = new LightElementNode("title", "block", "closed", new List<string>());
var titleText = new LightTextNode("Title text");
title.Add(titleText);
head.Add(title);

var h1 = new LightElementNode("h1", "block", "closed", new List<string>());
var img = new LightElementNode("img", "line", "notClosed", new List<string>());
var h1Text = new LightTextNode("h1 Text");
h1.Add(img);
h1.Add(h1Text);
body.Add(h1);

var p = new LightElementNode("p", "block", "closed", new List<string>());
var pText = new LightTextNode("Some text.");
p.Add(pText);
body.Add(p);

html.Add(head);
html.Add(body);

Console.WriteLine(html.OuterHTML);
//Console.WriteLine(html.InnerHTML);
Console.WriteLine("---------");

//Task6
fullPath = System.IO.Path.Combine(baseDirectory, "..", "..", "..",
"..", $"file.txt");
fullPath = System.IO.Path.GetFullPath(fullPath);
FileReader.ConvertTextWithoutFly(fullPath);
FileReader.ConvertTextWithFly(fullPath);