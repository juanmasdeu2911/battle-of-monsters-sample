namespace Lib.ProblemSolving;

public static class Challenge1
{
    public static Challenge1Result FractionsCalculator(int[] numbers)
    {
        //1) Declare all variables to be used on the algorithm
        decimal positiveCounter = 0;
        decimal negativeCounter = 0;
        decimal zeroCounter = 0;
        int vectorLength = numbers.Length;
        Challenge1Result result = new Challenge1Result();

        //2) for each number in the array, I define if it is positive, zero or negative and increment the corresponding counter
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                positiveCounter++;
            }
            else
            {
                if (numbers[i] < 0)
                {
                    negativeCounter++;
                }
                else
                {
                    zeroCounter++;
                }
            }
        }

        //3) Load the result object with the results
        //I need to use Round function with 6 decimal positions to return
        //the result (first run the tests to fail)
        result.Positives = decimal.Round(positiveCounter / vectorLength, 6);
        result.Negatives = decimal.Round(negativeCounter / vectorLength, 6);
        result.Zeros = decimal.Round(zeroCounter / vectorLength, 6);

        return result;
    }
}

public class Challenge1Result
{
    public decimal Positives { get; set; }
    public decimal Negatives { get; set; }
    public decimal Zeros { get; set; }
}