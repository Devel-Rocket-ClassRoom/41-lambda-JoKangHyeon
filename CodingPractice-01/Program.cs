using System;

Console.WriteLine();
Console.WriteLine("## 1. 가장 간단한 람다식");

PrintMessage print = () => Console.WriteLine("안녕하세요.");
print();



Console.WriteLine();
Console.WriteLine("## 2. 매개변수와 반환값이 있는 람다식");

Transformer transformer = x => x * x;
Console.WriteLine(transformer(3));
Console.WriteLine(transformer(4));



Console.WriteLine();
Console.WriteLine("## 3. 여러 매개변수가 있는 람다식\r\n");

IsLonger isLong = (string str, int size) => str.Length > size;
Console.WriteLine(isLong("안녕하세요.", 5));
Console.WriteLine(isLong("반갑습니다.", 10));



Console.WriteLine();
Console.WriteLine("## 4. 문장 람다");

Greeting greeting = () =>
{
    Console.WriteLine("안녕하세요.");
    Console.WriteLine("반갑습니다.");
};

greeting();



Console.WriteLine();
Console.WriteLine("## 5. 문장 람다에서 값 반환");

Calculator calculator = (int a, int b) =>
{
    int result = a + b;
    Console.WriteLine($"{a} + {b} = {result}");
    return result;
};

int sum = calculator(3, 5);
Console.WriteLine($"합계: {sum}");

delegate void PrintMessage();

delegate int Transformer(int x);

delegate bool IsLonger(string str, int size);

delegate void Greeting();

delegate int Calculator(int x, int y);