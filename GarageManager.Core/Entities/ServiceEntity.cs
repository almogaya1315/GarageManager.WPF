using GarageManager.Core.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Core.Entities
{
    [Table("Tbl_Services")]
    public class ServiceEntity : BaseEntity
    {
        public ServiceEntity(int id) : base(id)
        {
            TicketNumber = id;
        }

        [Required]
        public int TicketNumber { get; set; }
    }
}
