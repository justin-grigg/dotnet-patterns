namespace DecoratorLib
{
    public interface IMenuItem
    {
        string Name { get; }
        double Price { get; }
        bool IsSpecial { get; }
    }
}