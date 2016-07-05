using System;

namespace calculator
{
    public static class TwoArgumentsCalculatorsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "button1":
                    return new Plus();
                    break;
                case "button2":
                    return new Minus();
                    break;
                case "button3":
                    return new Multiplication();
                    break;
                case "button4":
                    return new Division();
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}