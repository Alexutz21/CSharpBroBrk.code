using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    public class Book
    {
        //a class is a specification, the class tell us what the data type is
        //we define the data type of class Book
        public string title;    
        public string author;
        public int pages;
        public string color;
        //after we created data types we create objects
        //objects are instance of the class
        
        public static void Book1()
        {
            Book book1 = new Book();    //this is how we create a object (a instance of the class Book)
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;
            book1.color = "Purple";
            Console.WriteLine(book1.title + " is writen by " + book1.author + " and has " + book1.pages + " pages.");

        }
        public static void Book2()
        {
            Book book2 = new Book();    //we create anothe object with name book2 in class Book
            book2.title = "Star Wars";
            book2.author = "Luke Skywalker";
            book2.pages = 380;
            book2.color = "Red";
            Console.WriteLine(book2.title + " is writen by " + book2.author + " and has " + book2.pages + " pages.");

        }
        public static void BookRunExample()
        {
            Book1();
            Book2();
            Console.WriteLine();
        }
    }
}
