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
    [Table("Tbl_Customers")]
    public class CustomerEntity : BaseEntity
    {
        public CustomerEntity(int id) : base(id)
        {
            SocialSecurityNumber = id;
        }

        [Required]
        public int SocialSecurityNumber { get; set; }

        [StringLength(500)]
        public string? FullName { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }
        public virtual CarEntity? Car { get; set; }

        [StringLength(200)]
        public string Adress { get; set; }
    }
}
