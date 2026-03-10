using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

Action<string> systemLogger = CreateLogger("시스템");
Action<string> networkLogger = CreateLogger("네트워크");

systemLogger("서버를 시작합니다.");
systemLogger("초기화가 완료되었습니다.");
networkLogger("클라이언트가 접속했습니다.");
systemLogger("요청을 처리합니다.");
networkLogger("데이터를 수신했습니다.");
networkLogger("클라이언트가 종료했습니다.");



Action<string> CreateLogger(string category)
{
    int log = 1;
    return (message) => Console.WriteLine($"[{category} #{log++}] {message}");
}