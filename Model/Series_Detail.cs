using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Series_Detail : BaseEntity
    {
        private Book_Series idSeries;
        private Book idBook;

        public Book_Series IdSeries { get => idSeries; set => idSeries = value; }
        public Book IdBook { get => idBook; set => idBook = value; }
    }
}
