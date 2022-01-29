using System;
using System.Collections.Generic;

namespace DecoratorLib
{
    public class Menu : IMenu
    {
        public IEnumerable<IMenuItem> Items { get; }

        public Menu(IEnumerable<IMenuItem> menuItems)
        {
            Items = menuItems;
        }
    }
}
