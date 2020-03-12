public class FizzBuzz
    {
        private int _number;

        public string Parse(int number)
        {
            _number = number;

            if (IsDivisibleBy(3) && IsDivisibleBy(5))
            {
                return "FizzBuzz";
            }

            if (IsDivisibleBy(3))
            {
                return "Fizz";
            }

            if (IsDivisibleBy(5))
            {
                return "Buzz";
            }

            return number.ToString();
        }

        private bool IsDivisibleBy(int numberToDivide)
        {
            return _number % numberToDivide == 0;
        }
    }