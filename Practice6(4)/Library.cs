using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6_4_
{
    internal class Library
    {
        private Book[] _books;

        public Book[] Books
        {
            get => _books;
            set => _books = value;
        }

        /// <summary>
        /// Creates an array of the Books that will contain differents books.
        /// </summary>
        public Library()
        {
            _books = new Book[0];
        }

        /// <summary>
        /// Adds the book to the array.
        /// </summary>
        public void AddBook(Book book)
        {
            Array.Resize(ref _books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }

        /// <summary>
        /// Deletes the book from the array.
        /// </summary>
        public void DeleteBook(int index) {
            if (index >= 0 && index < Books.Length)
            {
                Array.Copy(Books, index + 1, Books, index, Books.Length - index - 1);
                Array.Resize(ref _books, Books.Length - 1);
            } else
            {
                Console.WriteLine("Something wrong");
            }
        }

        /// <summary>
        /// Edits the book in the array.
        /// </summary>
        public void EditBooks(int index, Book newBook)   
        {
            if(index >= 0 && index < Books.Length){
                Books[index] = newBook;                
            } else {
                Console.WriteLine("Something wrong");
            }
     
        }
    }
}
