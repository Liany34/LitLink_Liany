using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book_Series : BaseEntity
    {
        private int code;
        private string nameSeries;

        public int Code { get => code; set => code = value; }
        public string NameSeries { get => nameSeries; set => nameSeries = value; }
    }
}
