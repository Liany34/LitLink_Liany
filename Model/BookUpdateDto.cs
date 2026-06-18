using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BookUpdateDto
    {
        public int Id { get; set; }

        public string BookName { get; set; }
        public DateTime? PublicationDate { get; set; }
        public double? Price { get; set; }
        public string Information { get; set; }
        public string BookLink { get; set; }
        public bool IsFlaged { get; set; }

        public int IdAuthor { get; set; }
        public int IdLanguage { get; set; }

        public string? CoverPath { get; set; }

        public string? FileName { get; set; }
        public string? Base64Image { get; set; }
    }
}
