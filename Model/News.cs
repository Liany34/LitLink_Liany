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
        private string content;
        private DateTime publishDate;
        private string titel;

        public User IdUser { get => idUser; set => idUser = value; }
        public string Content { get => content; set => content = value; }
        public DateTime PublishDate { get => publishDate; set => publishDate = value; }
        public string Titel { get => titel; set => titel = value; }

        public override string ToString()
        {
            return $"{Titel} by {IdUser.Username} at {PublishDate}: {Content}";
        }
    }
}
