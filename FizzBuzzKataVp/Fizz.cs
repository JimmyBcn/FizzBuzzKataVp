namespace FizzBuzzKataVp
{
    public class Fizz : IFizzBuzzSpecification
    {
        public bool IsSpecifiedBy(int i)
        {
            return (i % 3 == 0);
        }

        public string Text
        {
            get
            {
                return "Fizz";
            }
        }
    }
}
