using System;

namespace _230315_10209박아름 {
    class Program {
        static void Main(string[] args) {
            /*
            {// 이 안에서만 사용 할 수 있다 (데이터 자체가 제거된다)
                int num = 5;
            }
            Console.WriteLine(num);
            */
            #region 실수 덧셈 프로그램

            float f1 = 0;
            float f2 = 0;
            try {
                 f1 = float.Parse(Console.ReadLine());
                 f2 = float.Parse(Console.ReadLine());
            }
            catch (FormatException e){ // 잘못된 형식이 들어왔을 때
                Console.WriteLine(e.Message);
                Console.WriteLine("잘못된 값을 입력했습니다");
            }
            catch (OverflowException e){ // 예상 밖의 범위가 들어왔을 때
                Console.WriteLine(e.Message);
                Console.WriteLine("범위내의 값을 입력 하십시오");
            }

            Console.WriteLine($"두 수를 더한 값은{f1 + f2}입니다");
            #endregion

            #region 이스케이프 문자

            // 탭 (\t)
            Console.WriteLine($"TAB : >Hello\tWorld!<");

            // 줄바꿈 new Line (\n)
            Console.WriteLine("Hello\nWorld!");

            // 백스페이스 (\b)
            Console.WriteLine("Hell\boWorld!");

            // 캐리지리턴 (\r)
            Console.WriteLine("Hello\rWorld!");

            // 유니코드 (\u)
            Console.WriteLine('\u0065');
            #endregion

            #region 형식 지정 출력
            // 소수점 자릿수 지정
            float a = 3.14f;
            Console.WriteLine($"{a:F3}"); // F_ _자리숫자 만큼 소수점 표시

            // 정수 자릿수 지정
            int b = 5689;
            Console.WriteLine($"{b:D8}");

            // 화폐형식
            Console.WriteLine($"{b:C}");

            // 16진수 hexadecimal
            Console.WriteLine($"{b:X}");
            #endregion

            #region 띄어쓰기로 입력값 쪼개 저장
            string[] str = Console.ReadLine().Split(); // 입력을 받고 split으로 분리한다 ()가 빈칸일 경우 " "를 기준으로 분리

            for(int i = 0; i < str.Length; i++) {
                Console.WriteLine(str[i]);
            }

            foreach(string item in str) {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
