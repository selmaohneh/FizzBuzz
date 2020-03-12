public interface IRule
    {
        string Word { get; }
        bool Matches(int number);
    }

    public class FizzRule : IRule
    {
        public string Word => "Fizz";

        public bool Matches(int number)
        {
            return number % 3 == 0;
        }
    }

    public class BuzzRule : IRule
    {
        public string Word => "Buzz";

        public bool Matches(int number)
        {
            return number % 5 == 0;
        }
    }

    public class FizzBuzzRule : IRule
    {
        private readonly FizzRule _fizzRule;
        private readonly BuzzRule _buzzRule;

        public string Word => "FizzBuzz";

        public FizzBuzzRule(FizzRule fizzRule, BuzzRule buzzRule)
        {
            _fizzRule = fizzRule;
            _buzzRule = buzzRule;
        }

        public bool Matches(int number)
        {
            return _fizzRule.Matches(number) && _buzzRule.Matches(number);
        }
    }