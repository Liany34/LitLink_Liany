using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListPermissions_for_Administer : List<Permissions_for_Administer>
    {
        public ListPermissions_for_Administer() { }
        public ListPermissions_for_Administer(IEnumerable<Permissions_for_Administer> list) : base(list) { }
        public ListPermissions_for_Administer(IEnumerable<BaseEntity> list) : base(list.Cast<Permissions_for_Administer>().ToList()) { }
    }
}
