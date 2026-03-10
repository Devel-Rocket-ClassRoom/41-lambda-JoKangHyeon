using System;
using System.Collections.Generic;

Console.WriteLine();
Console.WriteLine("## 1. 반복문 변수 캡처 주의사항");

Action[] actions = new Action[3];

for (int i = 0; i < actions.Length; i++)
{
    actions[i] = () => Console.Write(i);
}

for (int i = 0; i < actions.Length; i++)
{
    actions[i]();
}



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("## 2. 반복문 캡처 문제 해결");

actions = new Action[3];

for (int i = 0; i < actions.Length; i++)
{
    int loopVar = i;
    actions[i] = () => Console.Write(loopVar);
}

for (int i = 0; i < actions.Length; i++)
{
    actions[i]();
}


Console.WriteLine();
Console.WriteLine();
Console.WriteLine("## 3. 배열 정렬에 람다식 사용");

string[] names = { "김철수", "이영희", "박민수", "최지연" };
Array.Sort(names, (a, b) =>
{
    return a.Length - b.Length;
});
Console.WriteLine("이름 길이순 정렬:");
Console.WriteLine(string.Join('\n', names)); ;


Console.WriteLine();
Console.WriteLine("역순 정렬:");
Array.Sort(names, (a, b) =>
{
    return b.CompareTo(a);
});
Console.WriteLine(string.Join('\n', names)); ;



Console.WriteLine();
Console.WriteLine("## 4. List 메서드와 람다식");

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.Write("첫 번째 짝수: ");
Console.WriteLine(numbers.Find(i => i % 2 == 0));

Console.Write("모든 짝수: ");
Console.WriteLine(string.Join(", ", numbers.FindAll(i => i % 2 == 0)));

Console.WriteLine($"8보다 큰 수 존재: {numbers.Exists(i => i > 8)}");

Console.WriteLine($"모두 양수: {numbers.TrueForAll(i => i > 0)}");

Console.WriteLine($"제거된 짝수 개수: {numbers.RemoveAll(i => i % 2 == 0)}");

Console.Write("남은 숫자: ");
Console.WriteLine(string.Join(", ", numbers));