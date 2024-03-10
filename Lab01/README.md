# Programming Principles that I used

## Single Responsibility, SRP
All classes have their own scope of responsibility, for example, the [Money](./ClassLibrary/Money.cs) class only has methods to handle money, and the [Product](./ClassLibrary/Product.cs) class only has methods to handle product information, so when you want to decrease the price of a product, the RemoveMoney method of the Money class is called in the DecreasePrice method.
## Open/Closed, OCP
The classes are designed to be extensible without modifying existing code. For instance, the class Money can be extensible adding a child class with a certain currency. Also I added class ProductInfo for extending the Product class and its convenient use in the Warehouse class.
## Liskov Substitution, LSP
The Product class has the field of class Money and in constructor we can pass a variable of type Money, MoneyUSD, etc. 
## Interface Segregation Principle, ISP
The IDisplay interface has a method for displaying data on the screen. It is implemented by classes Money, Product, ProductInfo, Warehouse. The IMoney interface has methods for adding and withdrawal of money, so only the Money class uses it. Thus, we have small interfaces that have only the necessary methods and that can be implemented by different classes.
## YAGNI
The classes contains basic methods for managing money, products, warehouses and reporting. Additional methods can be added as needed.
## KISS
Classes and methods are simple and focused on a single responsibility. They have only basic, simple methods.
## Fail Fast
The Money and ProductInfo classes have restrictions on some fields. For example, in the Money class, the _banknotes field mustn't be less than 0. If this requirement is not met, an ArgumentException exception is generated, which immediately stops the program execution and allows you to quickly identify and signal a problem.