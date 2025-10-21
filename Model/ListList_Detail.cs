using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListList_Detail : List<List_Detail>
    {
        public ListList_Detail() { }
        public ListList_Detail(IEnumerable<List_Detail> list) : base(list) { }
        public ListList_Detail(IEnumerable<BaseEntity> list) : base(list.Cast<List_Detail>().ToList()) { }
    }
}
