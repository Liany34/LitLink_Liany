using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User : BaseEntity
    {
        private string firstName;
        private string lastName;
        private string? phoneNumber;
        private string? email;
        private string username;
        private string pass;
        private DateTime birthdate;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string? PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string? Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Pass { get => pass; set => pass = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }

        public override string ToString()
        {
            if(PhoneNumber == null && Email != null)
            {
                return $"ID: {Id}, Name: {FirstName} {LastName}, BirthDate: {Birthdate}, Email: {Email}, Username: {Username}";
            }
            if(PhoneNumber != null && Email == null)
            {
                return $"ID: {Id}, Name: {FirstName} {LastName}, BirthDate: {Birthdate}, Phone Number: {PhoneNumber}, Username: {Username}";
            }
            return $"ID: {Id}, Name: {FirstName} {LastName}, BirthDate: {Birthdate}, Phone Number: {PhoneNumber}, Email: {Email}, Username: {Username}";
        }
    }
}
