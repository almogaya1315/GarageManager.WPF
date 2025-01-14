using GarageManager.Core.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Core.DTO
{
    public class UserDTO : BaseDTO
    {
        public UserDTO(int id) : base(id)
        {
            SocialSecurityNumber = id;  
        }

        public int SocialSecurityNumber { get; set; }
    }
}
