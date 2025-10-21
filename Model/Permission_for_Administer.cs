using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Permissions_for_Administer : BaseEntity
    {
        private User idAdministrator;
        private Permission idPermission;

        public User IdAdministrator { get => idAdministrator; set => idAdministrator = value; }
        public Permission IdPermission { get => idPermission; set => idPermission = value; }
    }
}
