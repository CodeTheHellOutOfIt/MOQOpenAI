namespace AIMOQUnitTest.Services
{
    public class FibonacciSeriesService : IFibonacciSeriesService
    {
        public int[] GenerateFibonacciSeries(int input)
        {
            int[] fibonacciSeries = new int[input];
            int firstNumber = 0;
            int secondNumber = 1;
            int sum = 0;
            for (int i = 0; i < input; i++)
            {
                fibonacciSeries[i] = firstNumber;
                sum = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = sum;
            }
            return fibonacciSeries;
        }

        //generate a method that returns bool value if the input is even number
        public bool IsEvenNumber(int input)
        {
            return input % 2 == 0;
        }
    }
}
