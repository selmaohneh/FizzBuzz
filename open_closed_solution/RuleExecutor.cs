public class RuleExecutor
    {
        private readonly IEnumerable<IRule> _rules;

        public RuleExecutor(IEnumerable<IRule> rules)
        {
            _rules = rules;
        }

        public string ExecuteWith(int number)
        {
            foreach (IRule rule in _rules)
            {
                // first matching rule is taken.
                // another rule executor could take other conditions.
                if (rule.Matches(number))
                {
                    return rule.Word;
                }
            }

            return number.ToString();
        }
    }