using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListLanguage : List<Language>
    {
        public ListLanguage() { }
        public ListLanguage(IEnumerable<Language> list) : base(list) { }
        public ListLanguage(IEnumerable<BaseEntity> list) : base(list.Cast<Language>().ToList()) { }
    }
}
