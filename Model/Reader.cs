using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reader : User
    {
        private string nickname;
        private bool isFlaged;

        public string Nickname { get => nickname; set => nickname = value; }
        public bool IsFlaged { get => isFlaged; set => isFlaged = value; }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Nickname: {Nickname}";
        }
    }
}
