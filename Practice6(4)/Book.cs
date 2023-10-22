using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6_4_
{
    internal abstract class Book : IBook
    {

        private readonly string _title;
        private string _author;
        private int _yearOfPublish;


        /// <summary>
        /// Setter and getter of the title of the book
        /// </summary>
        public string Title
        {
            get => _title;

            init
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _title = value;
                } else
                {
                    _title = "Title";
                }
            }
        }

        /// <summary>
        /// Setter and getter of the author of the book
        /// </summary>
        public string Author
        {
            get => _author;

            init
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _author = value;
                }
                else
                {
                    _author = "Author";
                }
            }
        }

        /// <summary>
        /// Setter and getter of the year of publish of the book
        /// </summary>
        public int YearOfPublish
        {
            get => _yearOfPublish;

            init
            {
                if (_yearOfPublish >= 0)
                {
                    _yearOfPublish = value;
                }
                else
                {
                    _yearOfPublish = DateTime.Now.Year;
                }
            }
        }

        protected Book(string title, string author, int yearOfPublish) 
        {
            Title = title;
            Author = author;
            YearOfPublish = yearOfPublish;
        }

        public abstract void CloseBook();

        public abstract void OpenBook();

        public override string ToString()
        {
            return $"Title: {Title}\nAuthor: {Author}\nYear of publish: {YearOfPublish}";
        }
    }
}
