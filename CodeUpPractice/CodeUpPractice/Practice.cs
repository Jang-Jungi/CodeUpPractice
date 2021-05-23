using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeUpPractice
{
    class Practice
    {
        static void Main(string[] args)
        {
            //1번~8번
            Console.WriteLine("Hello");
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello\nWorld");
            Console.WriteLine("'Hello'");
            Console.WriteLine("\"Hello World\"");
            Console.WriteLine("\"!@#$%^&*()\"");
            Console.WriteLine("\"C:\\Download\\hello.cpp\"");
            Console.Write("\u250C\u252C\u2510\n\u251C\u253C\u2524\n"); // 이하 생략
            
            //10번~
            int input = 15;
            Console.WriteLine(input);
            float input1 = 3.141592f;
            Console.WriteLine(input1);
            //Console.WriteLine(input1); -- 정수, 소숫점 분리하여 출력 모르겠음
            int input3 = 75254;
            Console.WriteLine("{0:0000}",input3); //정수 출력, 빈자리는 0 출력
            Console.WriteLine("{0:N4}", input1); // 정수+소숫점 N:2자리 N4: 4자리

            // Math.Round(값,위치) 반올림, Math.Ceiling 올림, Math.Truncate 버림
            Console.WriteLine(Math.Round(input1, 3));

            int a = 4; int b = 1;
            Console.WriteLine($"a = {a}, b = {b}");
            int input2 = 1;
            Console.Write($"{input2},{input2},{input2}\n");

            //날짜
            DateTime dt = new DateTime(2021,05,23);
            Console.WriteLine(dt.ToString("yyyy-MM-dd-hh:mm:ss"));

            DateTime DT = new DateTime(2021, 05, 22);
            Console.WriteLine(DT.ToString("yyyy년MM월dd일hh시mm분"));

            int h = 1; int m = 2; int s = 30;
            Console.WriteLine($"{h}{ h.ToString("시:")}{m}{m.ToString("분")}{s}{s.ToString("초")}");

            DateTime DT1 = new DateTime(2021,05,21);
            Console.WriteLine(DT1.ToString("yyyy.MM.dd"));
            Console.WriteLine(DT1.ToString("dd-MM-yyyy"));

            // 주민번호에서 hypen기호를 빼는 방법
            string 주민번호 = "110011-0000000";
            Console.WriteLine($"{주민번호.Substring(0,6)}{주민번호.Substring(7,7)}");

            //문자열 입력
            char[] Char = { 'p', 'i', 'g' }; // 문자열 char 선언 방법 기억
            Console.WriteLine(Char);
            //char[] Char1 = { 'a', 'A' };-- 문자열 순서 바꾸는건 모르겠음

            char[] words = { 'b', 'o', 'y' };
            string str = new string(words); // 생성자로 연결하는 방법
            string str1 = string.Concat(words); // 메소드로 합치는 방법 join도 같음
            Console.WriteLine(words);


        }
    }
}
