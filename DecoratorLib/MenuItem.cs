using System;
namespace DecoratorLib
{
    public class MenuItem : IMenuItem
    {
        private string _name;
        private double _price;
        private bool _isSpecial;

        public MenuItem(string Name, double Price, bool IsSpecial = false)
        {
            _name = Name;
            _price = Price;
            _isSpecial = IsSpecial;
        }

        public string Name => _name;

        public double Price => _price;

        public bool IsSpecial => _isSpecial;
    }
}
