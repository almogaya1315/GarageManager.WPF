using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Core.Bases
{
    public class BaseApplication
    {
        public BaseApplication()
        {
            Users = new List<BaseDTO>();
        }

        public List<BaseDTO> Users { get; set; }
    }
}
