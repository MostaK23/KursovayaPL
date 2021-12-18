using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGraphics
{
    public class EnglishLocalization : IUserLocalization
    {
        public string X0PlusDelta => "x0 + delta";

        public string X0MinusDelta => "x0 - delta";

        public string Y0PlusEpsilon => "y0 + epsilon";

        public string Y0MinusEpsilon => "y0 - epsilon";

        public string FillAllFields => "Fill all fields!";

        public string IncorrectValue => "Incorrect value!";

        public string DeltaMoreThanZero => "Delta must be more than zero!";

        public string EpsilonMoreThanZero => "Epsilon must be more than zero!";

        public string MinValue => "Min value is {0}";

        public string MaxValue => "Max value is {0}";

        public string WrongDeltaForX0 => "Wrong delta for this x0";

        public string WrongEpsilonForY0 => "Wrong epsilon for y0";

        public string WrongX0ForY0 => "Wrong x0";

        public string RightEpsilonAndDelta => "Epsilon and delta are correct.";

        public string WrongEpsilonAndDelta => "Epsilon and delta are incorrect.";
    }
}
