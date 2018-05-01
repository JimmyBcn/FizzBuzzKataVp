namespace FizzBuzzKataVp
{
    public interface IFizzBuzzSpecification
    {
        bool IsSpecifiedBy(int i);

        string Text { get; }
    }
}
