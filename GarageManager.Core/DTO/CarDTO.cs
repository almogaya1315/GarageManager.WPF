using GarageManager.Core.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Core.DTO
{
    public class CarDTO : BaseDTO
    {
        public CarDTO(int id) : base(id)
        {
            LisencePlateNumber = id;
        }

        public int LisencePlateNumber { get; set; }
    }
}
