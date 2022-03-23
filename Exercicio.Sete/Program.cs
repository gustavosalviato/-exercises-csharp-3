using System;

namespace Exercicio.Sete
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe seu nome");
                var nome = Console.ReadLine();

                Console.WriteLine("Informe sua data de nascimento");
                DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento);

                Console.WriteLine(ObterMensagemFaixaEtaria(nome, dataNascimento));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {

            }

        }

        private static string ObterMensagemFaixaEtaria(string nome, DateTime dataNascimento)
        {
            var idade = DateTime.Today.Year - dataNascimento.Year;

            if (idade >= 60)
                return $"Olá {nome}, está na faixa etária Idoso!";
            else if (idade >= 20 && idade <= 59)
                return $"Olá {nome}, está na faixa etária Adulto!";

            return $"Olá {nome}, está na faixa etária Jovem!";
        }
    }
}
