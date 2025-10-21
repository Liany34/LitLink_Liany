using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListUser : List<User>
    {
        public ListUser() { }
        public ListUser(IEnumerable<User> list) : base(list) { }
        public ListUser(IEnumerable<BaseEntity> list) : base(list.Cast<User>().ToList()) { }
    }
}
