using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6_4_
{
    internal class Novel : Book
    {
        private int _price;
        private string _gener;
        private string _publisher;
        private bool _status;

        public Novel(string title, string author, int yearOfPublish, int price, string gener, string publisher) : base(title, author, yearOfPublish)
        {
            Price = price;
            Gener = gener;
            Publisher = publisher;
        }

        /// <summary>
        /// Setter and getter of the price of the novel
        /// </summary>

        public int Price
        {
            get => _price;

            init
            {
                if (_price >= 0)
                {
                    _price = value;
                }
                else
                {
                    _price = 10;
                }
            }
        }

        /// <summary>
        /// Setter and getter of gener of the novel
        /// </summary>

        public string Gener
        {
            get => _gener;

            init
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _gener = value;
                }
                else
                {
                    _gener = "Gener";
                }
            }
        }

        /// <summary>
        /// Setter and getter of the publisher of the novel
        /// </summary>

        public string Publisher
        {
            get => _publisher;

            init
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _publisher = value;
                }
                else
                {
                    _publisher = "Gener";
                }
            }
        }

        /// <summary>
        /// Setter and getter of the status of book, opened or closed the book
        /// </summary>

        public bool Status
        {
            get => _status;
            set => _status = value;
        }

        /// <summary>
        /// Book closes if the book is opened (status == true)
        /// </summary>
        public override void CloseBook()
        {
            if (Status)
            {
                Status = false;
                Console.WriteLine($"{base.Title} закрыта");
            }
        }

        /// <summary>
        /// Book opens if the book is closed (status == false)
        /// </summary>
        public override void OpenBook()
        {
            if (!Status)
            {
                Status = true;
                Console.WriteLine($"{base.Title} открыта");
            }
        }

        public override string ToString()
        {
            return $"Novel:\n{base.ToString()}\nPrice: {Price}\nGener {Gener}\nPublisher: {Publisher}";
        }
    }
}
