using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListAdmin : List<Admin>
    {
        public ListAdmin() { }
        public ListAdmin(IEnumerable<Admin> list) : base(list) { }
        public ListAdmin(IEnumerable<BaseEntity> list) : base(list.Cast<Admin>().ToList()) { }
    }
}
