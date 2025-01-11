using GarageManager.Core.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Core.Entities
{
    public class ServiceEntity : BaseEntity
    {
        public ServiceEntity(int id) : base(id)
        {
            TicketNumber = id;
        }

        public int TicketNumber { get; set; }
    }
}
