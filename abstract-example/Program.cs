// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Book mistborn = new Book("Mistborn", "Brandon Sanderson");
mistborn.Display();
Console.WriteLine(mistborn.IsAvailable());

Book mere_christianity = new Book("Mere Christianity", "C.S. Lewis");
mere_christianity.Display();