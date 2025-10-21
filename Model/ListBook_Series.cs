using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListBook_Series : List<Book_Series>
    {
        public ListBook_Series() { }
        public ListBook_Series(IEnumerable<Book_Series> list) : base(list) { }
        public ListBook_Series(IEnumerable<BaseEntity> list) : base(list.Cast<Book_Series>().ToList()) { }
    }
}
