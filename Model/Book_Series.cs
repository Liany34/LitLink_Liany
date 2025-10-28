using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book_Series : BaseEntity
    {
        private string nameSeries;

        public string NameSeries { get => nameSeries; set => nameSeries = value; }

        public override string ToString()
        {
            return NameSeries;
        }
    }
}
