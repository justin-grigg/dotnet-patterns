using System;
using System.Collections.Generic;
using System.Linq;

namespace DecoratorLib
{
    public class DailySpecialMenu : IMenu
    {
        private IMenu _menu;
        private IMenuItem _dailySpecialMenuItem;

        public IEnumerable<IMenuItem> Items => _menu.Items.Append(_dailySpecialMenuItem);

        public DailySpecialMenu(IMenu menu, IMenuItem dailySpecialMenu)
        {
            _menu = menu;
            _dailySpecialMenuItem = dailySpecialMenu;
        }
    }
}
