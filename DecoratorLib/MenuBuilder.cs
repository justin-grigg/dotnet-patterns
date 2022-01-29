using System;
using System.Collections.Generic;

namespace DecoratorLib
{
    public class MenuBuilder
    {
        private bool _withDiscount;
        private double _discountPercentage;
        private bool _withDailySpecial;
        private IMenuItem _dailySpecialMenuItem;
        private IEnumerable<IMenuItem> _menuItems;

        public MenuBuilder(IEnumerable<IMenuItem> menuItems)
        {
            _menuItems = menuItems;
        }

        public MenuBuilder WithDiscounts(double discountPercentage)
        {
            _withDiscount = true;
            _discountPercentage = discountPercentage;

            return this;
        }

        public MenuBuilder WithDailySpecial(IMenuItem dailySpecialMenu)
        {
            _withDailySpecial = true;
            _dailySpecialMenuItem = dailySpecialMenu;

            return this;
        }

        public IMenu Build()
        {
            IMenu menu = new Menu(_menuItems);

            // enforce that discount is applied first
            if (_withDiscount)
            {
                menu = new DiscountMenu(menu, _discountPercentage);
            }

            // discount not applied to daily special menu item
            if (_withDailySpecial)
            {
                menu = new DailySpecialMenu(menu, _dailySpecialMenuItem);
            }

            return menu;
        }
    }
}
