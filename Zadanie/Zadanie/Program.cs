Console.WriteLine("Hello, World!");
Console.WriteLine("Feature 1");
Console.WriteLine("Feature 2");
Console.WriteLine("Feature 3");
Console.WriteLine("Feature 4");

static double CalculateAverage(int[] values)
{
    double sum = 0;
    foreach (int val in values)
    {
        sum += val;
    }
    return sum / values.Length;
}

static int CalculateMax(int[] values)
{
    
}