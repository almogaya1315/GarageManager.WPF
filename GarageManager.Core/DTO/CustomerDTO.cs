using GarageManager.Core.Bases;
using GarageManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Core.DTO
{
    public class CustomerDTO : BaseDTO
    {
        public CustomerDTO(int id) : base(id)
        {
            SocialSecurityNumber = id;
        }

        public CustomerDTO(int id, string fullName) : this(id) 
        {
            FullName = fullName;
        }

        public CustomerDTO(CustomerEntity entity) : base(entity.Id)
        {
            SocialSecurityNumber = entity.Id;
            FullName = entity.FullName;
        }

        public int SocialSecurityNumber { get; set; }
        public string FullName { get; set; }
    }
}
