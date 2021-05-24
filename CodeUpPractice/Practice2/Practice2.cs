using System;

namespace Practice2
{
    class Practice2
    {
        static void Main(string[] args)
        {
            //70번
            Console.WriteLine("70번 계절 판독기 1~12월 중 숫자만 입력하세요");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 12: Console.WriteLine("겨울"); break;
                case 1: Console.WriteLine("겨울"); break;
                case 2: Console.WriteLine("겨울"); break;
                case 3: Console.WriteLine("봄"); break;
                case 4: Console.WriteLine("봄"); break;
                case 5: Console.WriteLine("봄"); break;
                case 6: Console.WriteLine("여름"); break;
                case 7: Console.WriteLine("여름"); break;
                case 8: Console.WriteLine("여름"); break;
                case 9: Console.WriteLine("가을"); break;
                case 10: Console.WriteLine("가을"); break;
                case 11: Console.WriteLine("가을"); break;
            }
            //71번 -- goto 문 사용
            Console.WriteLine("71번 자연수 판독 프로그램 : 숫자를 입력하세요");
            int input = int.Parse(Console.ReadLine());
            int x = 200;
            for (int i = 0; i < x; i++)
            {
                if (input > 0)
                {
                    goto Found;
                }
                else goto Finish;
            }
        Finish:
            Console.WriteLine($"{input}은 자연수가 아닙니다.");
        Found:
            Console.WriteLine($"{input}은 자연수입니다.");
            //72번-- 생략
            //73번 while문
            Console.WriteLine("73번 숫자 입력 0이 입력될 때까지 무한대로 작동합니다.");

            while (true)
            {
                int a = int.Parse(Console.ReadLine());
                if (a == 0) { break; }
                Console.WriteLine($"입력하신 숫자는 {a}");
            }
            Console.WriteLine("0이 입력되었습니다. 프로그램 종료");

            //74번=75번
            Console.WriteLine("74번 카운트 다운 숫자 입력 1개씩 줄어듭니다.");
            int b = int.Parse(Console.ReadLine());

            while (b != 0)
            {
                b--;
                if (b != 0) { Console.WriteLine(b); }
            }
            //76번
            Console.WriteLine("76번 입력하신 알파벳(대문자) 다음 순서를 보여드립니다.");
            char z = 'z'; char result = 'A';
            do
            {
                Console.Write($"{result}\t");
                result++;
                if (result % 5 == 0)
                    Console.WriteLine();
            } while (result <= 'Z');
            Console.WriteLine();

            //77번
            Console.WriteLine("77번 입력하신 숫자 다음 100까지 입력해드립니다.");
            int num1 = 0; int num2 = 100;
            int num3 = int.Parse(Console.ReadLine());
            for (int i = num3; i < 100; i++)
            {
                if (num3 <= i)
                {
                    num3++;
                }
                Console.Write($"{num3}\t");
                if (num3 % 5 == 0)
                    Console.WriteLine();
            }
            return;
            //78번
            Console.WriteLine("78번 입력하신 숫자 이전 짝수들의 합.");
            int sum = 0;
            int num4 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num4; i++)
            {
                if (i % 2 == 0) { sum += i; }
            }
            Console.WriteLine(sum);
            //79
            Console.WriteLine("79번 q가 입력될 때까지 입력한 문자를 출력.");
            string v2;
            do
            {
                v2 = Console.ReadLine();
                Console.WriteLine(v2);
            } while (v2 != "q");
            //80
            Console.WriteLine("80번 1~XX까지 더하기 최초 1000이되는 XX숫자는?.");
            int sum1 = 0;
            for (int i = 1; i < 50; i++)
            {
                sum1 += i;
                if (sum1 >= 16)
                {
                    Console.WriteLine(i - 1);
                    Console.WriteLine(sum1 - i);
                    break;
                }
            }
            //81번
            Console.WriteLine("81번 주사위 2개 모든 경우 출력.");
            int d1; int d2;

            for (int i = 1; i <= 6; i++)
            {
                for (int j = 0; j <= 6; j++)
                {
                    Console.Write($"({i},{j})\t");
                }
                Console.WriteLine();
            }
            //82번--생략
            Console.WriteLine("82번 16진수 구구단.");


            //83번
            Console.WriteLine("83번 369게임 ~9까지.");
            for (int i = 1; i < 10; i++)
            {
                if (i % 3 == 0) { Console.Write("X\t"); }
                else Console.Write($"{i}\t");
            }
            //84번
            Console.WriteLine("84번 빛의 세기 조절하기(조합의 수).");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int zz = 0; zz < 3; zz++)
                    {
                        Console.Write($"{i},{j},{zz}\t");
                    }
                }
                Console.WriteLine();
            }
            //85번 86번--생략
            //87번
            Console.WriteLine("87번 1~XX까지 더하기 최초 1000이되는 XX숫자는?.");
            int sum11 = 0;
            for (int i = 1; i < 50; i++)
            {
                sum1 += i;
                if (sum1 >= 16)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(sum11);
                    break;
                }
            }
            //88번
            Console.WriteLine("88번 3의배수 출력X.");

            for (int i = 0; i < 12; i++)
            {
                if (i % 3 == 0)
                    continue;
                Console.Write($"{i}\t");
            }
            //89번
            Console.WriteLine("89번 3 등차수열");
            Console.WriteLine("초기값을 입력해주세요");
            int dd = int.Parse(Console.ReadLine());
            Console.WriteLine("n번째 수열의 값을 계산합니다.");
            int nValue = int.Parse(Console.ReadLine());

            for (int i = 1; i < nValue; i++)
            {
                dd += 3;
            }
            Console.WriteLine(dd);
            //90번
            Console.WriteLine("90번 등비 수열");
            Console.WriteLine("초기값을 입력해주세요");
            int dt = int.Parse(Console.ReadLine());

            Console.WriteLine("등비값을 입력해주세요");
            int tt = int.Parse(Console.ReadLine());

            Console.WriteLine("n번째 수열의 값을 계산합니다.");
            int nValue1 = int.Parse(Console.ReadLine());

            for (int i = 1; i < nValue1; i++)
            {
                dt *= tt;
            }
            Console.WriteLine(dt);

        }

    }
}
