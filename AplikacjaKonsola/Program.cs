namespace AplikacjaKonsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj numer pesel: ");
            string peselText = Console.ReadLine();
            char[] pesel = peselText.ToCharArray();
            if (CheckGender(pesel) == 'K')
            {
                Console.WriteLine("Kobieta");
            }
            else
            {
                Console.WriteLine("Mężczyzna");
            }
            if (CheckSum(pesel))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        private static char CheckGender(char[] pesel)
        {
            if ((pesel[9] - '0') % 2 == 0)
            {
                return 'K';
            }
            else
            {
                return 'M';
            }
        }

        private static bool CheckSum(char[] pesel)
        {
            int[] weigths = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int S = 0;
            int R = 0;

            for (int i = 0; i<10; i++)
            {
                S += (pesel[i] - '0') * weigths[i];
            }

            int M = S % 10;
            if(M == 0)
                R = 0;
            else
                R = 10 - M;

            if((pesel[10]-'0') == R)
                return true;
            else
                return false;
        }
    }
}
