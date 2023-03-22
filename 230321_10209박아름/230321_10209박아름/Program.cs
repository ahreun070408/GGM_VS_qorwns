using System;

namespace _230321_10209박아름 {
    class Program {
        static void Main(string[] args) {
            // 값 형식 => 왜 이럴까 : {}가 닫히면서 스텍의 값이 빠져나감
            {
                int a = 5;
            }
           // Console.WriteLine(a);

            // 참조 형식 => 왜 이럴까 : bb는 {}밖에서 선언이 된다 bb가 20이 나오는 이유는 {}안에서 aa가 선언되고 bb = aa;로 주소가 움직였기 때문에
            object bb = 10;
            {
                object aa = 20;
                bb = aa;
            }
            //Console.WriteLine(aa);
            Console.WriteLine(bb);

            // 랜덤 번호 뽑기
            Random rand = new Random();
            Console.WriteLine("발표자는");
            Console.WriteLine(rand.Next(1,21));
            Console.WriteLine(rand.Next(1,21));



            // 2진수, 10진수, 16진수 리터럴
            byte aaa = 240;
            byte bbb = 0b1100_1010; // 2진수 ( 0b )
            byte ccc = 0xF1; // 16진수( 0x )
            Console.WriteLine($"{aaa} {bbb} {ccc}");



            // 부호 유무 자료형
            byte ba = 255;
            sbyte sb = (sbyte)ba; // sbyte로 형식 변환
            Console.WriteLine($"byte 형식에서 {ba} sbyte 형식{sb}");



            // 오버플로우
            int max = int.MaxValue; // 0111 1111 1111 1111 1111 1111 1111 1111
            // int min = int.MinValue;

            max += 10; // 0000 0000 0000 0000 0000 0000 0000 1010 더하면 
            Console.WriteLine(max); // 1000 0000 0000 0000 0000 0000 0000 1001 결과
                                    // 0111 1111 1111 1111 1111 1111 1111 0111 2의 보수
                                    // 2147483647 - 8 = -2147483639

            // float double 
            float fa = 3.141592653589793238462643383f;
            double db = 3.141592653589793238462643383;
            Console.WriteLine(fa);
            Console.WriteLine(db);

        }
    }
}
