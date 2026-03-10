using System;

int[] numbers = { 10, 25, 7, 42, 18, 33 };
Console.WriteLine($"배열: {string.Join(", ", numbers)}");

int sum = ProcessArray(numbers, arr =>
{
    int sum = 0;
    foreach (int i in arr)
        sum += i;
    return sum;
});
Console.WriteLine($"합계: {sum}");

int max = ProcessArray(numbers, arr =>
{
    int max = int.MinValue;
    foreach (int i in arr)
    {
        if (i > max)
            max = i;
    }
    return max;
});
Console.WriteLine($"최댓값: {max}");

int min = ProcessArray(numbers, arr =>
{
    int min = int.MaxValue;
    foreach (int i in arr)
    {
        if (i < min)
            min = i;
    }
    return min;
});
Console.WriteLine($"최솟값: {min}");

int evenCount = ProcessArray(numbers, arr =>
{
    int evenCount = 0;
    foreach (int i in arr)
    {
        if (i % 2 == 0)
            evenCount++;
    }
    return evenCount;
});
Console.WriteLine($"짝수 개수: {evenCount}");



int ProcessArray(int[] data, Func<int[], int> processor)
{
    return processor(data);
}

