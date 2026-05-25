using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Genre_Reader : BaseEntity
    {
        private Reader idReader;
        private Genre idGenre;

        public Reader IdReader { get => idReader; set => idReader = value; }
        public Genre IdGenre { get => idGenre; set => idGenre = value; }

        public override string ToString()
        {
            return $"Reader Id: {IdReader.Nickname}, Intrest Id: {IdGenre.Name}";
        }
    }
}
