using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    class Practice1
    {
        static void Main(string[] args)
        {
            //38번
            int a = 123;
            int b = -123;
            Console.WriteLine(a + b);
            //39번
            long c = 2147483647;
            long d = 2147483647;
            long sum = (c + d);
            Console.WriteLine(sum);
            //40번
            int e = 2;
            Console.WriteLine(-e);
            //41번 -- ASCII -> int -> ASCII
            Console.WriteLine(Convert.ToChar(Convert.ToInt32('A') + 1));
            //42번
            int f = 10;
            int g = 3;
            Console.WriteLine(f / g);
            //43번
            Console.WriteLine(f % g);
            //44번
            Console.WriteLine(++f);
            //45번
            int pls = f + g; int min = f - g;
            int mul = f * g; int div = f / g;
            int mod = f % g;
            Console.WriteLine($"덧{pls},뺄{min},곱{mul},몫{div},나{mod}");
            //46번 배열+평균+소숫점 표현
            int[] arr = new int[3] { 1, 2, 5};
            int sum2 = arr[0] + arr[1] + arr[2];
            float avg = sum2 / (float)3.0;
            Console.WriteLine($"덧{sum2},평균{avg}");
            //47번 //48번--비트시프트연산 생략
            //49번//51번
            int num1 = 1; int num2 = 2;
            if (num1 < num2) Console.WriteLine("1");
            else Console.WriteLine("0");
            //50번//52번//53번
            if (num1 == num2) Console.WriteLine("1");
            else Console.WriteLine("0");
            //54번,55번
            if (num1 > 0 && num2 > 0) Console.WriteLine("true");
            if (num1 < 0 || num2 > 0) Console.WriteLine("true");
            //56~62 생략 비트연산자
            //63번 조건연산자//64 생략
            string result = (f > g) ? "1" : "0";
            Console.WriteLine($"참이면 1 거짓은 0 : {result}");
            //65번,66번
            if (e%2==0){ Console.WriteLine($"{e},{true}"); } else Console.WriteLine($"{e},{false}");
            if (c % 2 == 0) { Console.WriteLine($"{c},{true}"); } else Console.WriteLine($"{c},{false}");
            if (g%3==0){ Console.WriteLine($"{g},{true}"); } else Console.WriteLine($"{g},{false}");
            //67번
            if (num2 > 0)
            {
                if (num2 % 2 == 0)
                {
                    Console.Write("even, ");
                }
                Console.WriteLine("plus");
            }
            else Console.WriteLine("odd, minus");
            //68번//69번
            Console.WriteLine("0~100까지 점수를 입력하세요");
            int input = Int32.Parse(Console.ReadLine());
            string grade = null;
            if (input > 100)  Console.WriteLine("값을 잘못 입력하셨습니다.");
            else if (input>=90){Console.WriteLine("A입니다."); grade = "A"; }
            else if (input>=70){Console.WriteLine("B입니다."); grade = "B"; }
            else if (input>=40){Console.WriteLine("C입니다."); grade = "C"; }
            else {Console.WriteLine("D입니다."); grade = "D"; }
            switch(Convert.ToChar(grade))// A,B,C,D를 아스키 코드로 변환
            {
                case 'A':
                    Console.WriteLine("best!!!");
                    break;
                case 'B':
                    Console.WriteLine("good!!");
                    break;
                case 'C':
                    Console.WriteLine("run!");
                    break;
                default:
                    Console.WriteLine("slowly");
                    break;
            }
        }
    }
}
