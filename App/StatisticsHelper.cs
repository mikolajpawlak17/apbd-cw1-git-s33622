namespace App;

public class StatisticsHelper
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0) return 0.0;
        double sum = 0;
        foreach (var num in numbers) 
            sum += num;
        return sum / numbers.Length;
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