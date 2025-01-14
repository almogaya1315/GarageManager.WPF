using GarageManager.Core.Bases;
using GarageManager.Core.Entities;
using GarageManager.Core.Enums;
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

        public CarDTO(CarEntity entity) : base(entity.Id)
        {
            LisencePlateNumber = entity.Id;
            Type = entity.Type;
        }

        public int LisencePlateNumber { get; set; }
        public eCarTypes Type { get; set; }
    }
}
