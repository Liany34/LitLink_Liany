using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Intrest_Reader : BaseEntity
    {
        private Reader idReader;
        private Intrest idIntrest;

        public Reader IdReader { get => idReader; set => idReader = value; }
        public Intrest IdIntrest { get => idIntrest; set => idIntrest = value; }
    }
}
