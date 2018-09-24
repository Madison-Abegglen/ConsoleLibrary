using System;
using System.Collections.Generic;

namespace ConsoleLibrary.Models
{
  public class Library
  {
    // name for library
    //private by default if accessor not specified
    public string Name { get; private set; }
    // this is a list called magazines. yep
    List<Magazine> Magazines = new List<Magazine>();
    // this list is a list called books. yea  
    List<Book> Books = new List<Book>();
    // used to view current books in books list
    public void ViewMagazines()
    {
      for (int i = 0; i < Magazines.Count; i++)
      {
        Magazine magazine = Magazines[i];
        string availableText = (magazine.Available ? "Available" : "Not available");
        System.Console.WriteLine($"{i + 1} - {magazine.Title} {availableText}");
      }
    }
    public void ViewBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        Book book = Books[i];
        string availableText = (book.Available ? "Available" : "Not Available");
        System.Console.WriteLine($"{i + 1} - {book.Title} {availableText}");
      }
    }
    public void AddMagazine(Magazine magazine)
    {
      Magazines.Add(magazine);
    }
    // used to add books, and yea 
    public void AddBook(Book book)
    {
      Books.Add(book);
    }

    // sets the name i guess ???
    public Library(string name)
    {
      Name = name;
    }
    // gets the user's chosen book and literally takes it from the book list

    // gets the user-selected magazine 
    private Magazine GetMagazineFromUserChoice()
    {
      if (Int32.TryParse(Console.ReadLine(), out int n))
      {
        n = n - 1;
        if (n < 0 || n >= Magazines.Count)
        {
          return null;
        }
        return Magazines[n];
      }
      return null;
    }
    private Book GetBookFromUserChoice()
    {
      if (Int32.TryParse(Console.ReadLine(), out int n))
      {
        n = n - 1;
        if (n < 0 || n >= Books.Count)
        {
          return null;
        }
        return Books[n];
      }
      return null;
    }

    // ba dum, the checkout menu !
    public void CheckoutBookMenu()
    {
      var checkingoutabook = true;
      while (checkingoutabook)
      {
        Console.Clear();
        ViewBooks();
        Console.WriteLine($"{Books.Count + 1} - GO BACK");
        Book book = GetBookFromUserChoice();

        if (book == null)
        {
          checkingoutabook = false;
        }
        else
        {
          book.Available = false;
        }

      }
    }

    public void CheckoutMagazineMenu()
    {
      var checkingoutamagazine = true;
      while (checkingoutamagazine)
      {
        Console.Clear();
        ViewMagazines();
        Console.WriteLine($"{Magazines.Count + 1} - GO BACK");
        Magazine magazine = GetMagazineFromUserChoice();

        if (magazine == null)
        {
          checkingoutamagazine = false;
        }
        else
        {
          magazine.Available = false;
        }

      }
    }


    public void ReturnBookMenu()
    {
      var checkingoutabook = true;
      while (checkingoutabook)
      {
        Console.Clear();
        ViewBooks();
        Console.WriteLine($"{Books.Count + 1} - GO BACK");
        Book book = GetBookFromUserChoice();

        if (book == null)
        {
          checkingoutabook = false;
        }
        else
        {
          book.Available = true;
        }

      }
    }

    public void ReturnMagazineMenu()
    {
      var checkingoutamagazine = true;
      while (checkingoutamagazine)
      {
        Console.Clear();
        ViewMagazines();
        Console.WriteLine($"{Magazines.Count + 1} - GO BACK");
        Magazine magazine = GetMagazineFromUserChoice();

        if (magazine == null)
        {
          checkingoutamagazine = false;
        }
        else
        {
          magazine.Available = true;
        }

      }
    }
  }
}