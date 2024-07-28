using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_ICE_1
{
    public class Book
    {
        private int BookID;
        private string name, author, genre;
        private double price;

        public Book(int bookID, string name, string author, string genre, double price)
        {
            BookID = bookID;
            this.name = name;
            this.author = author;
            this.genre = genre;
            this.price = price;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.name;
                else if (index == 1)
                    return this.author;
                else if (index == 2)
                    return this.genre;
                else if (index == 3)
                    return this.BookID;
                else if (index == 4)
                    return this.price;
                return null;
            }
            set
            {
                if (index == 0)
                    this.name = (string)value;
                else if (index == 1)
                    this.author = (string)value;
                else if (index == 2)
                    this.genre = (string)value;
                else if (index == 3)
                    this.BookID = (int)value;
                else if (index == 4)
                    this.price = (double)value;
            }
        }
        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("name"))
                    return this.name;
                if (attrName.ToLower().Equals("author"))
                    return this.author;
                if (attrName.ToLower().Equals("genre"))
                    return this.genre;
                if (attrName.ToLower().Equals("bookid"))
                    return this.BookID;
                if (attrName.ToLower().Equals("price"))
                    return this.price;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("name"))
                    this.name = (string)value;
                if (attrName.ToLower().Equals("author"))
                    this.author = (string)value;
                if (attrName.ToLower().Equals("genre"))
                    this.genre = (string)value;
                if (attrName.ToLower().Equals("bookid"))
                    this.BookID = (int)value;
                if (attrName.ToLower().Equals("price"))
                    this.price = (double)value;
            }
        }
    }
}
