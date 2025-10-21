using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListPermission : List<Permission>
    {
        public ListPermission() { }
        public ListPermission(IEnumerable<Permission> list) : base(list) { }
        public ListPermission(IEnumerable<BaseEntity> list) : base(list.Cast<Permission>().ToList()) { }
    }
}
