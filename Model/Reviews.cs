using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reviews : BaseEntity
    {
        private Reader idReader;
        private string text;
        private int stars;
        private Book idBook;
        private bool isFlaged;

        public Reader IdReader { get => idReader; set => idReader = value; }
        public string Text { get => text; set => text = value; }
        public int Stars { get => stars; set => stars = value; }
        public Book IdBook { get => idBook; set => idBook = value; }
        public bool IsFlaged { get => isFlaged; set => isFlaged = value; }

        public override string ToString()
        {
            return $"{IdReader.Nickname} gave the book - {IdBook.BookName} {Stars} stars, and wrote: {Text}";
        }

        public string StarString
        {
            get
            {
                return new string('★', Stars).PadRight(5, '☆');
            }
        }
    }
}
