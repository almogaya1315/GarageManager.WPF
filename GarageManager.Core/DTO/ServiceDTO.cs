using GarageManager.Core.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Core.DTO
{
    public class ServiceDTO : BaseDTO
    {
        public ServiceDTO(int id) : base(id)
        {
            TicketNumber = id;
        }

        public int TicketNumber { get; set; }
    }
}
