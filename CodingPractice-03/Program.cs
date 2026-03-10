using System;
using System.Collections.Generic;

Console.WriteLine();
Console.WriteLine("## 1. 람다식을 매개변수로 전달");

List<int> FindNumbers(Predicate<int> predicate)
{
    List<int> numbers = new();

    for (int i = 1; i <= 100; i++)
    {
        if (predicate(i))
            numbers.Add(i);
    }

    return numbers;
}

Console.WriteLine("3의 배수:");
Console.WriteLine(string.Join(' ', FindNumbers(i => i % 3 == 0)));

Console.WriteLine("제곱수:");
Console.WriteLine(string.Join(' ', FindNumbers(i =>
{
    int sqrt = (int)Math.Sqrt(i);
    if (sqrt * sqrt == i)
        return true;
    return false;
})));



Console.WriteLine();
Console.WriteLine("## 2. Predicate 대리자");

Predicate<int> isEven = i => i % 2 == 0;
Predicate<int> isOdd = i => i % 2 != 0;

Console.WriteLine(isEven(4));
Console.WriteLine(isOdd(4));



Console.WriteLine();
Console.WriteLine("## 3. 클로저 - 외부 변수 캡처");

int factor = 2;
Func<int, int> multiplier = n => n * factor;

Console.WriteLine(multiplier(3));

factor = 10;
Console.WriteLine(multiplier(3));



Console.WriteLine();
Console.WriteLine("## 4. 클로저 - 캡처된 변수 수정");

int count = 0;
Action increment = () => count++;
increment();
increment();
increment();

Console.WriteLine(count);



Console.WriteLine();
Console.WriteLine("## 5. 클로저와 변수 수명 연장");

Func<int> CreateCounter()
{
    int count = 0;

    return () => count++;
}

Func<int> counter = CreateCounter();
Console.WriteLine(counter());
Console.WriteLine(counter());
Console.WriteLine(counter());