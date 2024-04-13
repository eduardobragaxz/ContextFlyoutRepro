using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextFlyoutRepro
{
    public class MyClass
    {
        public void OpenWindow()
        {
            ItemsWindow itemsWindow = new(this);
            itemsWindow.Activate();
        }
    }
}
