using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListFollowing : List<Following>
    {
       public ListFollowing() { }
       public ListFollowing(IEnumerable<Following> list) : base(list) { }
      public ListFollowing(IEnumerable<BaseEntity> list) : base(list.Cast<Following>().ToList()) { }
    }
}
