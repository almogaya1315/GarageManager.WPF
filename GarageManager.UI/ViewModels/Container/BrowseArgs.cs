using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.UI.ViewModels.Container
{
    public class BrowseArgs
    {
        public BrowseArgsType Type { get; set; }

        public BrowseArgs(BrowseArgsType type)
        {
            Type = type;
        }
    }
}
