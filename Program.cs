namespace GCDLCM_Ex3_5
{
    class Program
    {
        private static int GCD_num;
        private static int GCD(int n1, int n2)
        {
            int r, t;
            if (n1 < n2)
            {
                t = n2;
                n1 = t;
                n2 = n1;
            }
            if(n2 != 0)
            {
                r = n1 % n2;
                n1 = n2;
                n2 = r;
                return GCD(n1, n2);

            }
            return n1;
        }

        private static int LCM(int n1, int n2)
        {
            int LCD_num;
            LCD_num = ((n1 * n2) / GCD_num);
            return LCD_num;
        }

        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("1. 請輸入第一個正整數值：");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("2. 請輸入第二個正整數值：");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3. GCD<{0},{1}> = {2}", num1, num2, GCD(num1, num2));
            GCD_num = GCD(num1, num2);
            Console.WriteLine("4. LCM<{0},{1}> = {2}", num1, num2, LCM(num1, num2));
            Console.Read();
        }
    }
}