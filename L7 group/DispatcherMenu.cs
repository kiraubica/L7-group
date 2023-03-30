using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_group
{
    public class DispatcherMenu
    {
        private IDispatcherPresentationLayer dispatcherPresentationLayer;
        public DispatcherMenu(IDispatcherPresentationLayer dispatcherPresentationLayer)
        {
            this.dispatcherPresentationLayer = dispatcherPresentationLayer;
        }

        public void Show()
        {
            while (true)
            {
                dispatcherPresentationLayer.ShowDispatcherMenu();
            }
        }
    }
}
