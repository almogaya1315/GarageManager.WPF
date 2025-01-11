using GarageManager.Core.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Core.Entities
{
    public class CustomerEntity : BaseEntity
    {
        public CustomerEntity(int id) : base(id)
        {
            SocialSecurityNumber = id;
        }

        public int SocialSecurityNumber { get; set; }
    }
}
