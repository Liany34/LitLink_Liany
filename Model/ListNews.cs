using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListNews : List<News>
    {
        public ListNews() { }
        public ListNews(IEnumerable<News> list) : base(list) { }
        public ListNews(IEnumerable<BaseEntity> list) : base(list.Cast<News>().ToList()) { }
    }
}
