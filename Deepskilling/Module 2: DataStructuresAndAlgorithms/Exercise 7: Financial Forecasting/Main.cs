class Program
{
    static void Main()
    {
        double futureValue =
            ForecastCalculator.PredictFutureValue(
                10000,
                0.10,
                5);

        Console.WriteLine(
            "Future Value: " + futureValue);
    }
}