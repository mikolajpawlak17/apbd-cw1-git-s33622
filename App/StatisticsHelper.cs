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

    public static int CalculateMax(int[] values)
    {
        int max = values[0];
        foreach (var num in values)
        {
            if(num > max)  
                max = num;
        }
        return max;
    }
}