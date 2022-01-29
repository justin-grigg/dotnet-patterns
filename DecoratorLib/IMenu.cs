using System.Collections.Generic;

namespace DecoratorLib
{
    public interface IMenu
    {
        public IEnumerable<IMenuItem> Items { get; }
    }
}