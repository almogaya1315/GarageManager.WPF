using GarageManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Core.Bases
{
    public class BaseService : IService
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

        public BaseService(int id)
        {
            _id = id;
        }
    }
}
