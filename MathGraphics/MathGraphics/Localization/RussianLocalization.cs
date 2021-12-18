using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGraphics
{
    public class RussianLocalization : IUserLocalization
    {
        public string X0PlusDelta => "x0 + дельта";
        public string X0MinusDelta => "x0 - дельта";

        public string Y0PlusEpsilon => "y0 + эпсилон";
        public string Y0MinusEpsilon => "y0 - эпсилон";

        public string FillAllFields => "Заполните все поля!";
        public string IncorrectValue => "Некорректное значение!";
        public string DeltaMoreThanZero => "Дельта должен быть больше нуля!";
        public string EpsilonMoreThanZero => "Дельта должен быть больше нуля!";

        public string MinValue => "Минимальное значение X0 = {0}.";
        public string MaxValue => "Максимальное значение X0 = {0}.";

        public string WrongDeltaForX0 => "Дельта не подходит для данного x0.";
        public string WrongEpsilonForY0 => "Эпсилон не подходит для данного y0.";
        public string WrongX0ForY0 => "x0 не подходит для данного диапозона.";

        public string RightEpsilonAndDelta => "Эпсилон и дельта подобраны верно.";
        public string WrongEpsilonAndDelta => "Эпсилон и дельта подобраны не верно.";
    }
}
