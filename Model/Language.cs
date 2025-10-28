using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Language : BaseEntity
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return Name;
        }
    }
}
