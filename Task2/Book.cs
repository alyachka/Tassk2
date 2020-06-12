using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Book
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Внимание! Неверное значение");
                }
            }
        }

        private int pageAmmount;
        public int PageAmmount
        {
            get
            {
                return pageAmmount;
            }
            set
            {
                if (value > 0)
                {
                    pageAmmount = value;
                }
                else
                {
                    throw new ArgumentException("Внимание! Неверное значение");
                }
            }
        }

        private string publisher;
        public string Publisher
        {
            get
            {
                return publisher;
            }
            set
            {
                if (value != null)
                {
                    publisher = value;
                }
                else
                {
                    throw new ArgumentException("Внимание! Неверное значение");
                }
            }
        }

        private DateTime? publishDate;
        public DateTime? PublishDate
        {
            get
            {
                return publishDate;
            }
            set
            {
                if (value != null)
                {
                    publishDate = value;
                }
                else
                {
                    throw new ArgumentException("Внимание! Неверное значение");
                }
            }
        }

        private DateTime? writtenDate;
        public DateTime? WrittenDate
        {
            get
            {
                return writtenDate;
            }
            set
            {
                if (value != null)
                {
                    writtenDate = value;
                }
                else
                {
                    throw new ArgumentException("Внимание! Неверное значение");
                }

            }
        }

        private Author author;
        public Author Author
        {
            get
            {
                return author;
            }
            set {
                if (value != null )
                {
                    author = value;
                }
                else
                {
                    throw new ArgumentException("Внимание! Неверное значение");
                }
            }
        }

        public Book(string newName, int newPageAmmount, string newPublisher, DateTime? newPublishDate, DateTime? newWrittenDate, Author newAuthor)
        {
            Name = newName;
            PageAmmount = newPageAmmount;
            Publisher = newPublisher;
            PublishDate = newPublishDate;
            WrittenDate = newWrittenDate;
            Author = newAuthor;

        }

        public override string ToString()
        {
            return $"{Name} {PageAmmount} {Publisher} {PublishDate} {WrittenDate} {Author.Name} {Author.Surname}";
        }


    }
}
