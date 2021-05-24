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

            while (b != 0) {
                b--;
                if (b!=0) {Console.WriteLine(b);}}
            //76번
            Console.WriteLine("76번 입력하신 알파벳 다음 순서를 보여드립니다.");
            char z = 'z'; char result = 'a';
            do
            {

                Console.Write($"{result}\t");
                result++;
            } while (result <= 'z');

        }
    }
}
