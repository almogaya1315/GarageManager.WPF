using GarageManager.Core.Bases;
using GarageManager.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Core.Entities
{
    [Table("Tbl_Cars")]
    public class CarEntity : BaseEntity
    {
        public CarEntity(int id) : base(id)
        {
            LisencePlateNumber = id;
        }

        [Required]
        public int LisencePlateNumber { get; set; }

        [Required]
        public eCarTypes Type { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        //[ForeignKey("Customer")]
        //public int CustomerId { get; set; }
        //public CustomerEntity? Customer { get; set; }
    }
}
