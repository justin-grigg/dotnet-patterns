using System;
using Xunit;
using DecoratorLib;
using System.Collections.Generic;
using System.Linq;

namespace DecoratorLibTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestMenuItems()
        {
            IMenu menu = new Menu(new List<IMenuItem>
            {
                new MenuItem("Chicken", 6.99),
                new MenuItem("Pizza", 3.99),
                new MenuItem("Salad", 4.99),
            });

            menu.Items.ToList().ForEach(f =>
            {
                Console.WriteLine($"{f.Name} {f.Price}");
            });

            Console.WriteLine($"Done: {System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }

        [Fact]
        public void TestDiscountMenuItems()
        {
            IMenu menu = new Menu(new List<IMenuItem>
            {
                new MenuItem("Chicken", 6.99),
                new MenuItem("Pizza", 3.99),
                new MenuItem("Salad", 4.99),
            });

            menu = new DiscountMenu(menu, 0.5);

            menu.Items.ToList().ForEach(f =>
            {
                Console.WriteLine($"{f.Name} {f.Price}");
            });

            Console.WriteLine($"Done: {System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }

        [Fact]
        public void TestDailySpecialMenuItems()
        {
            IMenu menu = new Menu(new List<IMenuItem>
            {
                new MenuItem("Chicken", 6.99),
                new MenuItem("Pizza", 3.99),
                new MenuItem("Salad", 4.99),
            });

            // discount applied to menu
            menu = new DiscountMenu(menu, 0.5);
            menu = new DailySpecialMenu(menu, new MenuItem("Milk", 0.99, true));

            menu.Items.ToList().ForEach(f =>
            {
                Console.WriteLine($"{f.Name} {f.Price}");
            });

            Console.WriteLine($"Done: {System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }

        [Fact]
        public void TestDailySpecialMenuItemsWithDiscount()
        {
            IMenu menu = new Menu(new List<IMenuItem>
            {
                new MenuItem("Chicken", 6.99),
                new MenuItem("Pizza", 3.99),
                new MenuItem("Salad", 4.99),
            });

            // add special before calculating discount
            menu = new DailySpecialMenu(menu, new MenuItem("Milk", 0.99, true));
            menu = new DiscountMenu(menu, 0.5);
            
            menu.Items.ToList().ForEach(f =>
            {
                Console.WriteLine($"{f.Name} {f.Price}");
            });

            Console.WriteLine($"Done: {System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }

        [Fact]
        public void TestMenuBuilder()
        {
            MenuBuilder menuBuilder = new MenuBuilder(new List<IMenuItem>
            {
                new MenuItem("Chicken", 6.99),
                new MenuItem("Pizza", 3.99),
                new MenuItem("Salad", 4.99),
            });

            IMenu menu = menuBuilder
                .WithDiscounts(0.5)
                .WithDailySpecial(new MenuItem("Milk", 0.99, true))
                .Build();

            menu.Items.ToList().ForEach(f =>
            {
                Console.WriteLine($"{f.Name} {f.Price}");
            });

            Console.WriteLine($"Done: {System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }
    }
}
