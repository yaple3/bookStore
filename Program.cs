using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace bookStore
{
    class myStore
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.SetId(30);
            book1.SetTitle("Jesus and John Wayne");
            book1.SetAuthor("Kristin Kobes Du Mez");

            Book book2 = new Book();
            Console.WriteLine("Please enter the book ID: ");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book title: ");
            book2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the author: ");
            book2.SetAuthor(Console.ReadLine());

            Book book3 = new Book(18, "Drawing on the Right Side of the Brain", "Betty Edwards");

            Console.WriteLine("Please enter the book ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the author: ");
            string tempAuthor = Console.ReadLine();
            Book book4 = new Book(tempID, tempTitle, tempAuthor);

            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);    
            displayBooks(book4);

        }
        static void displayBooks(Book book)
        {
            Console.WriteLine("Here's your book information");
            Console.WriteLine($"Book ID: {book.GetId()}");
            Console.WriteLine($"Book Title: {book.GetTitle()}");
            Console.WriteLine($"Book Author: {book.GetAuthor()}");
        } 

    }
}

class Book
{
    private int _Id;

    private string _Title;

    private string _Author;

public Book()
    {

        _Id = 0;
        _Title = "";
        _Author = "";
    }

public Book(int i, string title, string author)
    {
        _Id = i;
        _Title = title;
        _Author = author;
    }
    public int GetId()
    {
        return _Id;
    }

    public void SetId(int identification)
    {
        _Id = identification;
    }
    public string GetTitle()
    {
        return _Title;
    }
    public void SetTitle(string title)
    {
        _Title = title;
    }
    public string GetAuthor()
    {
        return _Author;
    }

    public void SetAuthor(string author)
    {
        _Author = author;
    }


}
/*
10. Once you have the program working correctly, make sure you save all your changes.

11. Follow the directions to push your project to GitHub working-with-github.html and add a link to your repository to the dropbox.
 */