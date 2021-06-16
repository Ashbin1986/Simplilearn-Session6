using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices.Models
{
   public class UserCredentailsModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public string UserId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
