using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSpecialKata
{
    public class FizzBuzz
    {
        private List<Rule> _rules;

        public FizzBuzz()
        {
            _rules = new List<Rule>();
        }

        public void AddRule(Rule rule) 
        {
            _rules.Add(rule);
        }

        public string Process(int number)
        {
            string result = string.Empty;
            
            result = ExecuteRules(number);
            result = result.TrimEnd();

            if (string.IsNullOrWhiteSpace(result))
            {
                result = number.ToString();
            }

            return result;
        }

        private string ExecuteRules(int number)
        {
            string result = string.Empty;
            string ruleResult;

            foreach (Rule rule in _rules)
            {
                ruleResult = rule.Process(number);
                result += ruleResult;

                if (!string.IsNullOrEmpty(ruleResult))
                {
                    result += " ";
                }
            }

            return result;
        }
    }
}
