using System;
namespace DecoratorLib
{
    public class DiscountMenuItem : IMenuItem
    {
        private string _name;
        private double _price;
        private double _discountPercentage;
        private bool _isSpecial;

        public DiscountMenuItem(string Name, double Price, double DiscountPercentage, bool IsSpecial = false)
        {
            _name = Name;
            _price = Price;
            _discountPercentage = DiscountPercentage;
            _isSpecial = IsSpecial;
        }

        public string Name => _name;

        public double Price => _price * _discountPercentage;

        public bool IsSpecial => _isSpecial;
    }
}
