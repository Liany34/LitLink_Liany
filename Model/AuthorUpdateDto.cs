using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AuthorUpdateDto : UserUpdateDto
    {
        public string PenName { get; set; }
        public string InformationAboutAuthor { get; set; }
        public int IdGenre { get; set; }
    }
}