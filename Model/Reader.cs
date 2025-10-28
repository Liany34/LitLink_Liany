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
        private bool premiumSubscription;
        private DateTime dateOfBirth;

        public string Nickname { get => nickname; set => nickname = value; }
        public bool PremiumSubscription { get => premiumSubscription; set => premiumSubscription = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Nickname: {Nickname}, Date of Birth: {DateOfBirth.ToShortDateString()}, Premium Subscription: {PremiumSubscription}";
        }
    }
}
