using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextFlyoutRepro
{
    public static class ListsClass
    {
        public static ObservableCollection<MyClass> MainWindowlistOfItems { get; set; } = [];
        public static ObservableCollection<MyClass> ItemsWindowlistOfItems { get; set; } = [];
    }
}