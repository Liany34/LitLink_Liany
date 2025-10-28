using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListPermissions_for_Administrator : List<Permissions_for_Administrator>
    {
        public ListPermissions_for_Administrator() { }
        public ListPermissions_for_Administrator(IEnumerable<Permissions_for_Administrator> list) : base(list) { }
        public ListPermissions_for_Administrator(IEnumerable<BaseEntity> list) : base(list.Cast<Permissions_for_Administrator>().ToList()) { }
    }
}
