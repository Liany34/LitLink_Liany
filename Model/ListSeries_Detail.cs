using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListSeries_Detail : List<Series_Detail>
    {
        public ListSeries_Detail() { }
        public ListSeries_Detail(IEnumerable<Series_Detail> list) : base(list) { }
        public ListSeries_Detail(IEnumerable<BaseEntity> list) : base(list.Cast<Series_Detail>().ToList()) { }
    }
}
