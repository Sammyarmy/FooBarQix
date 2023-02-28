using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarQix
{
    public class Compute
    {
        public string compute(string input)
        {
            int intInput = int.Parse(input);
            string output = "";
            bool isTriggered = false;

            if (intInput % 3 == 0)
            {
                isTriggered = true;
                output = string.Concat(output, "Foo");
            }
            if (intInput % 5 == 0)
            {
                isTriggered = true;
                output = string.Concat(output, "Bar");
            }
            if (intInput % 7 == 0)
            {
                isTriggered = true;
                output = string.Concat(output, "Qix");
            }

            foreach (var item in input)
            {
                if (item == '3')
                {
                    output = string.Concat(output, "Foo");
                    isTriggered = true;
                }
                if (item == '5')
                {
                    output = string.Concat(output, "Bar");
                    isTriggered = true;
                }
                if (item == '7')
                {
                    output = string.Concat(output, "Qix");
                    isTriggered = true;
                }
            }

            if (!isTriggered)
            {
                output = string.Concat(output, input);
            }

            return output;
        }
    }
}
