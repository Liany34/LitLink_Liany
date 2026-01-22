using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cart_Detail : BaseEntity
    {
        private Cart idCart;
        private Book idBook;

        public Cart IdCart { get => idCart; set => idCart = value; }
        public Book IdBook { get => idBook; set => idBook = value; }

        public override string ToString()
        {
            return $"Cart Id: {idCart.Id}, Book Title: {idBook.BookName}";
        }
    }
}
