using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ReaderUpdateDto : UserUpdateDto
    {
        public string Nickname { get; set; }
        public bool IsFlaged { get; set; }
    }
}
