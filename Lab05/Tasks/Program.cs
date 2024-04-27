using CompositeClassLibrary;
using IteratorClassLibrary;

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