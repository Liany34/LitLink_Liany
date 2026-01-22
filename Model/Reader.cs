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

        public string Nickname { get => nickname; set => nickname = value; }
        public bool PremiumSubscription { get => premiumSubscription; set => premiumSubscription = value; }

        public override string ToString()
        {
            if(PremiumSubscription)
            {
                return $"Name: {FirstName} {LastName}, Nickname: {Nickname}, Premium Subscription: Yes";
            }
            return $"Name: {FirstName} {LastName}, Nickname: {Nickname}, Premium Subscription: No";
        }
    }
}
