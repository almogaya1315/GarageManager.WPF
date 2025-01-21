using GarageManager.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.UI.Models
{
    internal class CustomerModel : CustomerDTO
    {
        public CustomerModel(int id, string fullName) : base(id, fullName)
        {
               
        }
    }
}
