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
        }

        private static char CheckGender(char[] pesel)
        {
            if (pesel[9]%2 == 0)
            {
                return 'K';
            }
            else
            {
                return 'M';
            }
        }
    }
}
