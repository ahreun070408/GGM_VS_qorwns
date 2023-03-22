using System;

namespace _10209_Project01_박아름 {
    class Program {
        static void Main(string[] args) {

            // 1. 이름 출력하기
                Console.WriteLine("이름을 입력하세요");
                string name = Console.ReadLine();
                Console.WriteLine($"제 이름은{name}입니다");
            
            


            // 2. 두 정수의 곱
            try {
                Console.WriteLine("두 정수를 입력하세요");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"{num1}, {num2} 두 정수를 계산한 결과는{num1 * num2}입니다");
            }
            catch (FormatException e) {
                Console.WriteLine("에러가 발생했습니다");
                Console.WriteLine(e.Message);
            }


            // 3. 두 실수의 곱
            try {
                Console.WriteLine("두 실수를 입력하세요");
                float num3 = float.Parse(Console.ReadLine());
                float num4 = float.Parse(Console.ReadLine());
                Console.WriteLine($"{num3}, {num4} 두 실수를 계산한 결과는{num3 * num4}입니다");
            }
            catch (FormatException e) {
                Console.WriteLine("에러가 발생했습니다");
                Console.WriteLine(e.Message);
            }


            // 4. 삼각형의 넓이 구하기
            try {
                Console.WriteLine("밑변의 길이와 윗변의 길이를 입력하세요");
                int Length1 = int.Parse(Console.ReadLine());
                int Length2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"{Length1}, {Length2} 두 밑변과 윗변을 계산한 결과는{(Length1 * Length2) / 2}입니다");
            }
            catch (FormatException e) {
                Console.WriteLine("에러가 발생했습니다");
                Console.WriteLine(e.Message);
            }


            // 5. 원의 넓이 구하기
            try {
                Console.WriteLine("반지름의 길이를 입력하세요");
                float r1 = float.Parse(Console.ReadLine());          
                Console.WriteLine($"{r1}길이의 반지름을 계산한 결과는{r1 * r1 * 3.14}입니다");
            }
            catch (FormatException e) {
                Console.WriteLine("에러가 발생했습니다");
                Console.WriteLine(e.Message);
            }




        }
    }
}
