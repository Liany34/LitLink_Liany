using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListBook_List : List<Book_List>
    {
        public ListBook_List() { }
        public ListBook_List(IEnumerable<Book_List> list) : base(list) { }
        public ListBook_List(IEnumerable<BaseEntity> list) : base(list.Cast<Book_List>().ToList()) { }
    }
}
