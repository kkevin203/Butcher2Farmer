using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public  class User : IdentityUser<string>
    {
        public override string UserName
        {
            get { return Email; }
            set { Email = value; }
        }
        public string Email { get; set; }

    }
}
