using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.UI.ViewModels.Container
{
    public class ViewModelBrowser
    {
        private ContainerViewModel _container { get; set; }

        public ViewModelBrowser(ContainerViewModel container)
        {
            _container = container;
        }

        public void Browse(BrowseArgs args)
        {
            _container.Browsed(args);
        }
    }
}
