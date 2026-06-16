using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserUpdateDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public DateTime Birthdate { get; set; }
        public string PicturePath { get; set; }

        public string FileName { get; set; }
        public string Base64Image { get; set; }
    }
}
