using System;

namespace Exercicio.Oito
{
    class Program
    {
        private const char _a = 'a';
        private const char _e = 'e';
        private const char _i = 'i';
        private const char _o = 'o';
        private const char _u = 'u';

        static void Main(string[] args)
        {
            int count = 0;

            try
            {
                Console.WriteLine($"Digite alguma palavra:");
                var nome = Console.ReadLine().ToLower();

                for (int i = 0; i < nome.Length; i++)
                {
                    if (_a.Equals(nome[i])
                        || _e.Equals(nome[i])
                        || _i.Equals(nome[i])
                        || _o.Equals(nome[i])
                        || _u.Equals(nome[i]))
                        count++;
                }

                Console.WriteLine($"A palavra digitada possui {count} vogal(is)!");
            }
            catch(Exception e)
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
