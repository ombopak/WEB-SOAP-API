using SOAP_SERVICE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOAP_SERVICE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class BookService : IBookService
    {
        public List<Book> books = new List<Book>();
        public int nextId = 1;

        public BookService()
        {
            books.Add(new Book { Id = nextId++, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" });
            books.Add(new Book { Id = nextId++, Title = "To Kill a Mockingbird", Author = "Harper Lee" });
            books.Add(new Book { Id = nextId++, Title = "Pride and Prejudice", Author = "Jane Austen" });
        }

        public string AddBook(Book book)
        {
            try
            {
                books.Add(book);
                string msg = "Success to add book!";
                return msg;
            }
            catch
            {
                string msg = "Failed to add book";
                return msg;

            }


        }

        public string DeleteBook(int Id)
        {
            try
            {
            books.RemoveAll(b => b.Id == Id);
                string msg = "Success delete book";
                return msg;
            }
            catch
            {
                string msg = "Failed to delete book";
                return msg;
            }
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public string UpdateBook(Book book)
        {
            var existingBook = books.FirstOrDefault(b => b.Id == book.Id);

            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                return "Success Update Book";
            }
            else
            {
                return "Failed to Update Book";
            }
        }
    }
}
