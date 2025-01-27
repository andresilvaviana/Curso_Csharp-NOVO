namespace teste_senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123";
            string senhadigitada;
            int tentativas = 0;

            do
            {
                Console.Clear(); // limpa tela
                Console.Write("Digite a senha: ");
                senhadigitada = Console.ReadLine();
                tentativas++;
                if (tentativas > 3) {break;} // break é pra bloquear o if
            } while (senha != senhadigitada);

            if (senha != senhadigitada) // se a "senha" for diferente da "senha digitada"!
            {
                Console.Clear();
                Console.WriteLine("Senha Incorreta! {0} tentativas.", tentativas);
            }
            else
            {
                Console.Clear(); // se a "senha" for igual a "senha digitada"! 
                Console.WriteLine("Senha Correta! {0} tentativas.", tentativas);
            }

            //Console.Clear(); // limpa a tela antes dessa msg
            //Console.WriteLine("Senha correta! Tentativas: " + tentativas);
        }
    }
}
