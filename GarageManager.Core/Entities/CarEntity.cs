using GarageManager.Core.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Core.Entities
{
    public class CarEntity : BaseEntity
    {
        public CarEntity(int id) : base(id)
        {
            LisencePlateNumber = id;
        }

        public int LisencePlateNumber { get; set; }
    }
}
