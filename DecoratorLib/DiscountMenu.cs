using System;
using System.Collections.Generic;
using System.Linq;

namespace DecoratorLib
{
    public class DiscountMenu : IMenu
    {
        private IMenu _menu;
        private double _discountPercentage;

        public IEnumerable<IMenuItem> Items => _menu.Items.Select(ToDiscountMenuItems);

        public DiscountMenu(IMenu menu, double discountPercentage)
        {
            _menu = menu;
            _discountPercentage = discountPercentage;
        }

        private IMenuItem ToDiscountMenuItems(IMenuItem menuItem)
        {
            return new DiscountMenuItem(menuItem.Name, menuItem.Price, _discountPercentage, menuItem.IsSpecial);
        }
    }
}
