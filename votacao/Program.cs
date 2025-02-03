namespace votacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nasc;
            Console.Write("Digite o ano de nascimento: ");
            nasc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(voto(nasc));
        }

        static string voto(int ano)
        { 
            DateTime dataAtual = DateTime.Now;
            int anoatual = dataAtual.Year;
            int idade = anoatual - ano;

            if (idade < 16)
            {
                return $"Com {idade} anos de idade, voce nao pode votar.";
            }
            else if (idade > 18 && idade < 70)
            {
                return $"Com {idade} anos de idade, voce vota.";
            }
            else
            {
                return $"Com {idade} anos de idade, o seu voto é opcional.";
            }
            /*int dia = dataAtual.Day;
            int mes = dataAtual.Month;
            int ano1 = dataAtual.Year;
            int hora = dataAtual.Hour;
            int minuto = dataAtual.Minute;
            int Segundo = dataAtual.Second
            */
        }
    }

}
