using System;

namespace Exercicio.Oito
{
    internal class Program
    {   // readonly : acesso somente no construtor ou nova instancia do objeto
        private static readonly Char[] _vogals = new []
        {
            'a', 'e', 'i', 'o', 'u',
        };

        //private const char _a = 'a';
        //private const char _e = 'e';
        //private const char _i = 'i';
        //private const char _o = 'o';
        //private const char _u = 'u';

        static void Main(string[] args)
        {

            try
            {
                Console.Write("Informe seu nome: ");
                var nome = Console.ReadLine().ToLower();
                var count = 0;

                for (int i = 0; i < nome.Length; i++)
                {
                    var letra = nome[i];

                    if (_vogals.Contains(letra))
                    {
                        count++;
                    }

                }
                Console.WriteLine($"Seu nome possui possui {count} consoantes!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
