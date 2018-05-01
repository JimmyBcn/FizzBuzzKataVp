namespace FizzBuzzKataVp
{
    public class Buzz : IFizzBuzzSpecification
    {
        public bool IsSpecifiedBy(int i)
        {
            return (i % 5 == 0);
        }

        public string Text
        {
            get
            {
                return "Buzz";
            }
        }
    }
}
