using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGraphics
{
    public interface IUserLocalization
    {
        string X0PlusDelta { get; }

        string X0MinusDelta { get; }

        string Y0PlusEpsilon { get; }

        string Y0MinusEpsilon { get; }

        string FillAllFields { get; }

        string IncorrectValue { get; }

        string DeltaMoreThanZero { get; }

        string EpsilonMoreThanZero { get; }

        string MinValue { get; }

        string MaxValue { get; }

        string WrongDeltaForX0 { get; }

        string WrongEpsilonForY0 { get; }

        string WrongX0ForY0 { get; }

        string RightEpsilonAndDelta { get; }

        string WrongEpsilonAndDelta { get; }
    }
}
