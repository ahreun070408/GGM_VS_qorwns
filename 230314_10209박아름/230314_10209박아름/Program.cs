using System;

namespace _230314_10209박아름 {
    class Program {
        static void Main(string[] args) {
            #region 출력 연습      
              
            string name = "카리나(유지민)";
            int age = 22;
            string group = "aespa(에스파)";

            // 1. +
            Console.WriteLine(" 좋아하는 가수는" + name + "나이는" + age + "그룹은" + group + "입니다");

            // 2. {0} {1}
            Console.WriteLine("좋아하는 가수는 {0} 나이는 {1} 그룹은 {2} 입니다", name, age, group);

            // 3. $""
            Console.WriteLine($"좋아하는 가수는 {name} 나이는 {age} 그룹은 {group} 입니다");
            #endregion

            #region 문자열 입력
            string input = Console.ReadLine();
            Console.Write("콘솔 입력후 input 값은 : ");
            Console.WriteLine(input);
            #endregion

            #region purse, Convert, 예외 처리
            // 1. purse : 문자열 => 다른 자료형
            int n1 = 0;
            int n2 = 0;
            try { // 일단 시도해
                 n1 = int.Parse(Console.ReadLine()); // 정수로 입력을 받음
                 n2 = int.Parse(Console.ReadLine());

            }
            catch(FormatException e){
                Console.WriteLine(e.Message);
                Console.WriteLine("형식 예외 발생! 다시 입력 바람");
            }
            catch (OverflowException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("오버플로우 발생. 범위 내의 값을 입력하세요");
            }
            Console.WriteLine(n1 + n2);

            Console.WriteLine("실수 두개를 입력하시오 : ");
            float f1 = 0.0f;
            float f2 = 0.0f;
            try { // 일단 시도해
                f1 = float.Parse(Console.ReadLine()); // 실수로 입력을 받음
                f2 = float.Parse(Console.ReadLine()); 

            }

            catch(FormatException e){ // (문제)가 생기면 잡는다
                Console.WriteLine(e.Message);
                Console.WriteLine("잘못된 값을 입력했습니다");
            }
            catch(OverflowException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("오버플로우 발생. 범위 내의 값을 입력하세요");
            }
            Console.WriteLine(f1 - f2);

            // 2. Conver : 기본 자료형 <=> 기본 가료형
            try { // 일단 시도해
                n1 = Convert.ToInt32(Console.ReadLine());
                n2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("형식 예외 발생! 다시 입력 바람");
            }
            catch (OverflowException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("오버플로우 발생 int 범위 내의 값을 입력하세요");
            }
            Console.WriteLine(n1 + n2);

            double d1 = 0;
            double d2 = 0;
            try { // 일단 시도해
               d1 = Convert.ToDouble(Console.ReadLine());
                d2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("형식 예외 발생! 다시 입력 바람");
            }
            catch (OverflowException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("오버플로우 발생 int 범위 내의 값을 입력하세요");
            }
            Console.WriteLine(d1 - d2);
            #endregion

            string[] str = Console.ReadLine().Split();
            for (int i=0; i<str.Length;  i++) {
                Console.WriteLine(str[i]);
            }
        }
    }
}
