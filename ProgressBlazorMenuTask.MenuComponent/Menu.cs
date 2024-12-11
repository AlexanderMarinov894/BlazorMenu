using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressBlazorMenuTask.MenuComponent
{
    // Classes

    public class MenuModel 
    {
        public List<MenuItemModel>? Items { get; set; }
    }
    public class MenuItemModel
    {
        public required string Text { get; set; }
        public List<MenuItemModel>? Items { get; set; }
    }

    // Enums

    public enum MenuOpenType 
    {
        MouseEnter,
        Click
    }
}
