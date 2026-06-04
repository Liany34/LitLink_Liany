using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ImageJsonDto
    {
        public int Id { get; set; }
        public string Base64Image { get; set; }
        public string FileName { get; set; }
    }
}
