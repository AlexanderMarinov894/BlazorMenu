using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressBlazorMenuTask.MenuComponent
{
    public class MenuModel 
    {
        public List<MenuItemModel>? Items { get; set; }
    }
    public class MenuItemModel
    {
        public required string Text { get; set; }
        public List<MenuItemModel>? Items { get; set; }
    }

    public enum MenuOpenType 
    {
        MouseEnter,
        Click
    }
}
