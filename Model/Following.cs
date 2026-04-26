using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Following : BaseEntity
    {
        private Reader idReader;
        private Author idAuthor;

        public Reader IdReader { get => idReader; set => idReader = value; }
        public Author IdAuthor { get => idAuthor; set => idAuthor = value; }

        public override string ToString()
        {
            return $"{IdReader.Nickname} follows {IdAuthor.PenName}";
        }
    }
}
