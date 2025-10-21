using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Author : User
    {
        private string penName;
        private Genre genre;
        private string informationAboutAuthor;

        public string PenName { get => penName; set => penName = value; }
        public Genre Genre { get => genre; set => genre = value; }
        public string InformationAboutAuthor { get => informationAboutAuthor; set => informationAboutAuthor = value; }
    }
}
