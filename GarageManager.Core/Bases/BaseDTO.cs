using GarageManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Core.Bases
{
    public class BaseDTO : IDto
    {
        protected int _id;
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

        public BaseDTO(int id)
        {
            _id = id;
        }

        public BaseDTO(IEntity entity)
        {
            _id = entity.Id;
        }
    }
}
