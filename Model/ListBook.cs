using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListBook : List<Book>
    {
        public ListBook() { }
        public ListBook(IEnumerable<Book> list) : base(list) { }
        public ListBook(IEnumerable<BaseEntity> list) : base(list.Cast<Book>().ToList()) { }
    }
}
