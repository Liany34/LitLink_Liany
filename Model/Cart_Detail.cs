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
        private int purchasePrice;
        private DateTime? purchaseDate = null;
        private bool isPurchased;

        public Cart IdCart { get => idCart; set => idCart = value; }
        public Book IdBook { get => idBook; set => idBook = value; }
        public int PurchasePrice { get => purchasePrice; set => purchasePrice = value; }
        public DateTime? PurchaseDate { get => purchaseDate; set => purchaseDate = value; }
        public bool IsPurchased { get => isPurchased; set => isPurchased = value; }

        public override string ToString()
        {
            if(isPurchased)
            {
                return $"Cart Id: {idCart.Id}, Book Title: {idBook.BookName}, Purchase Price: {purchasePrice}, Purchase Date: {purchaseDate}";
            }
            return $"Cart Id: {idCart.Id}, Book Title: {idBook.BookName}, Purchase Price: {purchasePrice}, Is Purchased: Not Yet";
        }
    }
}
