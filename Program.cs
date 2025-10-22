namespace Esercizifunzioni
{
    internal class Program
    {
        static bool verifican(int n)
        {
            if (n % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int somman(int somma = 0)
        {
            int n = 0, s = 0;
            for (int i = 0; i < 50; i++)
            {
                if (verifican(i) == true)
                {
                    s = s + i;
                }
            }
            return s;
        }
        static int fattoriale(int a)
        {
            int f = 1;
            for(int i=0;a>i;a--)
            {
                f = f * a;
            }
            return f;
        }
        static void Main(string[] args)

        {
            string messaggio;
            int a, prod;
            Console.WriteLine("Dimmi il numero");
            int n = Convert.ToInt32(Console.ReadLine());

            if (verifican(n))
            {
                messaggio = "Il numero " + n + " è speciale";
            }
            else
            {
                messaggio = "Il numero" + n + " non è speciale";

            }
            Console.WriteLine(messaggio);
            int ris = somman();
            Console.WriteLine(ris);
            Console.WriteLine("Dimmi di quale numero vuoi che faccia il fattoriale");
            a= Convert.ToInt32(Console.ReadLine());
            prod = fattoriale(a);
            Console.WriteLine("Il vettoriale del tuo numero è di " + prod);
        }
    }
}