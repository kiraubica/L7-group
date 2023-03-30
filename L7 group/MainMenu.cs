using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_group
{
    public class MainMenu
    {
        private IDispatcherPresentationLayer dispatcherPresentationLayer;
        public MainMenu(IDispatcherPresentationLayer dispatcherPresentationLayer)
        {
            this.dispatcherPresentationLayer = dispatcherPresentationLayer;
        }

        public void Show()
        {
            while (true)
            {
                dispatcherPresentationLayer.ShowMainMenu();
            }
        }
    }
}
