namespace App;

public class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0) return 0.0;
        double total = 0;
        foreach (var num in values) 
            total += num;
        return total / values.Length;
    }

    public static int GetMax(int[] numbers)
    {
        int max = numbers[0];
        foreach (var num in numbers)
        {
            if(num > max)  
                max = num;
        }
        return max;
    }
}