using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSpecialKata
{
    public class Rule
    {
        private int _number;
        private string _result;

        public Rule(int number, string result)
        {
            _number = number;
            _result = result;
        }

        public string Process(int number)
        {
            string result = string.Empty;

            if (number % _number == 0)
            {
                result = _result;
            }

            return result;
        }
    }
}
