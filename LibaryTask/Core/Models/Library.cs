using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Library
    {
        Book[] Books = new Book[] {};


        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }
        public Book[] FindAllBooksByName(string name)
        {
            Book[] filterdedBooks = new Book[] {};
            foreach (Book book in Books)
            {
                if (book.Name == name)
                {
                    Array.Resize(ref filterdedBooks,filterdedBooks.Length +1);
                    filterdedBooks[filterdedBooks.Length-1] = book;
                }
            }
            return filterdedBooks;
        }

        public Book[] RemoveAllBooksByName(string name)
        {
            Book[] filterdedBooks = new Book[] { };
            foreach (Book book in Books)
            {
                if (book.Name != name)
                {
                    Array.Resize(ref filterdedBooks, filterdedBooks.Length + 1);
                    filterdedBooks[filterdedBooks.Length - 1] = book;
                }
            }

            Books = filterdedBooks;

            return Books;
        }
        public Book[] SearchBooks(string name,string authorName,int pageCount)
        {
            
            Book[] filterdedBooks = new Book[] { };
            bool check = false;
           
            
                foreach (Book book in Books)
                {
                    if (book.Name == name || book.AuthorName == authorName || book.PageCount == pageCount)
                    {
                        check = true;
                        Array.Resize(ref filterdedBooks, filterdedBooks.Length + 1);
                        filterdedBooks[filterdedBooks.Length - 1] = book;
                    }
                }
                
                return filterdedBooks;

                
        }
        public Book[] GetAllBooks()
        {
            return Books;
        }
       
    }
}
