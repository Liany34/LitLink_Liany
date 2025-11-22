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
        private int? price;
        private Author idAuthor;
        private Genre idGenre;
        private bool discount;
        private string information;
        private string cover;
        private Language idLanguage;

        public string BookName { get => bookName; set => bookName = value; }
        public DateTime? PublicationDate { get => publicationDate; set => publicationDate = value; }
        public int? Price { get => price; set => price = value; }
        public Author IdAuthor { get => idAuthor; set => idAuthor = value; }
        public Genre IdGenre { get => idGenre; set => idGenre = value; }
        public bool Discount { get => discount; set => discount = value; }
        public string Information { get => information; set => information = value; }
        public string Cover { get => cover; set => cover = value; }
        public Language IdLanguage { get => idLanguage; set => idLanguage = value; }

        public override string ToString()
        {
            return $"Book: {bookName}, Author: {idAuthor.FirstName} {idAuthor.LastName}, Genre: {idGenre.Name}, Language: {idLanguage.Name}, Price: {price}, Publication Date: {publicationDate?.ToShortDateString()}, Discount: {discount}";
        }
    }
}
