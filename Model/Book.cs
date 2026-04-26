using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book : BaseEntity
    {
        private string bookName;
        private DateTime? publicationDate;
        private double? price;
        private Author idAuthor;
        private bool discount;
        private string information;
        private string cover;
        private Language idLanguage;
        private string? bookLink;

        public string BookName { get => bookName; set => bookName = value; }
        public DateTime? PublicationDate { get => publicationDate; set => publicationDate = value; }
        public double? Price { get => price; set => price = value; }
        public Author IdAuthor { get => idAuthor; set => idAuthor = value; }
        public bool Discount { get => discount; set => discount = value; }
        public string Information { get => information; set => information = value; }
        public string Cover { get => cover; set => cover = value; }
        public Language IdLanguage { get => idLanguage; set => idLanguage = value; }
        public string? BookLink { get => bookLink; set => bookLink = value; }

        public override string ToString()
        {
            if(publicationDate == null)
            {
                return $"Book: {bookName}, Author: {idAuthor.PenName}, Language: {idLanguage.Name}, Discount: {discount}";
            }
            return $"Book: {bookName}, Author: {idAuthor.PenName}, Language: {idLanguage.Name}, Price: {price}, Publication Date: {publicationDate?.ToShortDateString()}, Discount: {discount}";
        }
    }
}
