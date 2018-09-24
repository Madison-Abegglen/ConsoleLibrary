using System;
using ConsoleLibrary.Models;

namespace ConsoleLibrary
{
  class Program
  {
    static void Main(string[] args)
    {
      var library = new Library("LIBRARY!");
      var mobyDick = new Book("Moby Dick", "Herman Melville", "1", "1470");
      var lotr = new Book("The Fellowship", "Grey beard", "2196848-161", "1954");
      var hp = new Book("Harry Potter and the Chamber of Secrets", "JK Rowling", "215646897846549845195798496848-1251561161", "1998", false);
      var cosmo = new Magazine("Cosmopolitan", "Some editor I don't know the name of", "234322-322", "2018");
      var vogue = new Magazine("Vogue", "Another editor I dont know", "234322-521", "2018");
      var nyTimes = new Magazine("New York Times", "Cool guy, idk", "234322-181", "2018");
      library.AddBook(mobyDick);
      library.AddBook(lotr);
      library.AddBook(hp);
      library.AddMagazine(cosmo);
      library.AddMagazine(vogue);
      library.AddMagazine(nyTimes);

      Console.WriteLine(library.Name);
      library.ViewBooks();
      library.ViewMagazines();

      var inthelibrary = true;
      while (inthelibrary)
      {
        Console.Clear();
        Console.WriteLine("Welcome to " + library.Name);
        Console.WriteLine("things you can do here");
        Console.WriteLine("1 - Checkout book");
        Console.WriteLine("2 - Return book");
        Console.WriteLine("3 - Checkout Magazine");
        Console.WriteLine("4 - Return Magazine");
        Console.WriteLine("5 - Quit");
        Console.WriteLine("What would you like to do?");

        var userInput = Console.ReadLine();
        if (Int32.TryParse(userInput, out int choice))
        {
          switch (choice)
          {
            case 1:
              library.CheckoutBookMenu();
              break;
            case 2:
              library.ReturnBookMenu();
              break;
            case 3:
              library.CheckoutMagazineMenu();
              break;
            case 4:
              library.ReturnMagazineMenu();
              break;
            case 5:
              inthelibrary = false;
              Console.Clear();
              Console.WriteLine("Bye Felicia");
              break;
            default:
              System.Console.WriteLine("Invalid Choice Try again");
              break;
          }

        }

      }



    }
  }
}