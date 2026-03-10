using System;

Func<string, string> toUpper = str => str.ToUpper();
Func<string, string> mask = str => str.Substring(0, 2) + "***";
Func<string, string> greet = name => $"안녕하세요, {name}님!";

Console.Write("[대문자 변환] hello world → ");
ApplyAndPrint("hello world", toUpper);

Console.Write("[마스킹 처리] SecretCode → ");
ApplyAndPrint("SecretCode", mask);

Console.Write("[인사말 생성] 민수 → ");
ApplyAndPrint("민수", greet);



void ApplyAndPrint(string input, Func<string, string> formatter)
{
    Console.WriteLine(formatter(input));
}