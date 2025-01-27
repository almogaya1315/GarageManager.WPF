using GarageManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Core.Bases
{
    public class BaseEntity : IEntity
    {
        protected int _id;
        [Key]
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public BaseEntity(int id)
        {
            _id = id;
        }

        public BaseEntity(IDto dto)
        {
            _id = dto.Id;
        }
    }
}
