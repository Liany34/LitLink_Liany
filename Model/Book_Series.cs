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
        private User idUser;

        public string NameSeries { get => nameSeries; set => nameSeries = value; }
        public User IdUser { get => idUser; set => idUser = value; }

        public override string ToString()
        {
            return $"Book Series: {NameSeries}, Author: {IdUser.Username}";
        }
    }
}
