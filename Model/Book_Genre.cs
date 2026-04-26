using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book_Genre : BaseEntity
    {
        private Book idBook;
        private Genre idGenre;
        
        public Book IdBook { get => idBook; set => idBook = value; }
        public Genre IdGenre { get => idGenre; set => idGenre = value; }

        public override string ToString()
        {
            return $"Book: {IdBook.BookName}, Genre: {IdGenre.Name}";
        }
    }
}
