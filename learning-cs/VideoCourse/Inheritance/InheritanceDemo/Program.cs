using System.ComponentModel.DataAnnotations;
using InheritanceDemo;

Post post1 = new Post("Thanks for the birthday wishes.", "Aldair Zamora", true);
ImagePost imagePost1 = new ImagePost("Checkout my new shoes", "Aldair Zamora", true, "https://myimage.local");

Console.WriteLine(post1.ToString());
Console.WriteLine(imagePost1.ToString());

Console.ReadLine(); 