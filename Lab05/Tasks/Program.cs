using CompositeClassLibrary;
using IteratorClassLibrary;
using CommandClassLibrary;
using CompositeClassLibrary.StateClasses;

// Iterator
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
Console.WriteLine("--------------------------");
Console.WriteLine("Depth: ");
var depthFirstIterator = new DepthFirstIterator(html);
while (depthFirstIterator.MoveNext())
{
    Console.WriteLine(depthFirstIterator.Current.OuterHTML);
}
Console.WriteLine("--------------------------");
Console.WriteLine("Breadth: ");
var breadthFirstIterator = new BreadthFirstIterator(html);
while (breadthFirstIterator.MoveNext())
{
    Console.WriteLine(breadthFirstIterator.Current.OuterHTML);
}
Console.WriteLine("--------------------------");

// Template Method
var div = new LightElementNode("div", "block", "closed", new List<string> { "class1", "class2" });
var divText = new LightTextNode("Some text.");
div.Add(divText);
Console.WriteLine("--------------------------");

// Command
var addNodeCommand = new AddNodeCommand(div, h1);
addNodeCommand.Execute();
Console.WriteLine(div.OuterHTML);
Console.WriteLine("--------------------------");
var removeNodeCommand = new RemoveNodeCommand(h1, img);
removeNodeCommand.Execute();
Console.WriteLine(div.OuterHTML);
Console.WriteLine("--------------------------");
var changeTextCommand = new ChangeTextCommand(divText, "div text");
changeTextCommand.Execute();
Console.WriteLine(div.OuterHTML);
Console.WriteLine("--------------------------");

// State
var p2 = new LightElementNode("p", "block", "closed", new List<string> { "class1", "class2" });
var p2Text = new LightTextNode("Some text.");
p2.Add(p2Text);
Console.WriteLine("\n" + p2.OuterHTML);
Console.WriteLine("--------------------------");
p2.TransitionTo(new HoveredState());
Console.WriteLine(p2.OuterHTML);
Console.WriteLine("--------------------------");
p2.TransitionTo(new ClickedState());
Console.WriteLine(p2.OuterHTML);
Console.WriteLine("--------------------------");