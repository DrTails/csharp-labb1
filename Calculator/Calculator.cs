using System;
namespace Calculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int NumberInMemory { get; set; }

        public Calculator()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            NumberInMemory = 0;
        }

        public override string ToString()
        {
            return "First number: " + FirstNumber + "\n" +
                "Second number: " + SecondNumber + "\n" +
                "Number in memory: " + NumberInMemory;
        }

        public int SumNumbers() 
        {
            return FirstNumber + SecondNumber;
        }

        public int MultiplyNumbers() 
        {
            return FirstNumber * SecondNumber;
        }

        public int SumInBetween() 
        {
            int sum = 0;

            for (int i = FirstNumber; i <= SecondNumber; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}
