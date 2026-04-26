using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListReviews : List<Reviews>
    {
        public ListReviews() { }
        public ListReviews(IEnumerable<Reviews> list) : base(list) { }
        public ListReviews(IEnumerable<BaseEntity> list) : base(list.Cast<Reviews>().ToList()) { }
    }
}
