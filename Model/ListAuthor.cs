using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListAuthor : List<Author>
    {
        public ListAuthor() { }
        public ListAuthor(IEnumerable<Author> list) : base(list) { }
        public ListAuthor(IEnumerable<BaseEntity> list) : base(list.Cast<Author>().ToList()) { }
    }
}
