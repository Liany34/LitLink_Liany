using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class News : BaseEntity
    {
        private User idUser;
        private string text;
        private DateTime time;

        public User IdUser { get => idUser; set => idUser = value; }
        public string Text { get => text; set => text = value; }
        public DateTime Time { get => time; set => time = value; }

        public override string ToString()
        {
            return $"News by {IdUser.Username} at {Time}: {Text}";
        }
    }
}
