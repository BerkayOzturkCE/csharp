namespace Algoritma1
{
    class Algoritma1
    {
        public static void problem1()
        {
            Console.Write("Lütfen pozitif bir sayı giriniz:");
            var n = Convert.ToInt32(Console.ReadLine());
            int[] ciftler = new int[n];
            int sayac = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}. sayıyı giriniz:");
                var input = Convert.ToInt32(Console.ReadLine());
                if (input % 2 == 0)
                {
                    ciftler[sayac] = input;
                    sayac++;
                }
            }

            for (int i = 0; i < sayac; i++)
            {
                Console.Write($"{ciftler[i]}    ");
            }

        }
        public static void problem2()
        {
            Console.Write("Lütfen pozitif bir sayı giriniz:");
            var n = Convert.ToInt32(Console.ReadLine());
             Console.Write("Lütfen pozitif bir sayı giriniz:");
            var m = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int sayac = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}. sayıyı giriniz:");
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == m||input%m==0)
                {
                    array[sayac] = input;
                    sayac++;
                }
            }

              for (int i = 0; i < sayac; i++)
            {
                Console.Write($"{array[i]}    ");
            }
        }
        public static void problem3()
        {

        }
        public static void problem4()
        {

        }

    }
}