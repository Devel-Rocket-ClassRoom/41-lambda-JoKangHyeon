using System;

Console.WriteLine();
Console.WriteLine("## 1. Func 대리자");

Func<int> func1 = () => 1234;
Func<int, int> func2 = i => i * i;
Func<int, int, int> func3 = (x, y) => x + y;

Console.WriteLine(func1());
Console.WriteLine(func2(3));
Console.WriteLine(func3(3, 5));



Console.WriteLine();
Console.WriteLine("## 2. Action 대리자");

Action action1 = () => Console.WriteLine("안녕하세요!");
Action<string> action2 = str => Console.WriteLine(str);
Action<string, int> action3 = (str, repeat) =>
{
    for (int i = 0; i < repeat; i++)
    {
        Console.WriteLine(str);
    }
};

action1();
action2("Hello, Lambda!");
action3("반복!", 3);


Console.WriteLine();
Console.WriteLine("## 3. 익명 메서드와 람다식 비교");

Func<int, int> func4 = delegate (int x) { return x * x; };
Func<int, int> func5 = x => x * x;

Console.WriteLine(func4(2));
Console.WriteLine(func5(2));


