internal class Program
{
    private static void Main(string[] args)
    {
        float nota1, nota2, nota3, resposta;

        Console.Write("digite a nota 1:");
        nota1 = float.Parse(Console.ReadLine());

        Console.Write("digite a nota 2:");
        nota2 = float.Parse(Console.ReadLine());

        nota3 = nota1 + nota2;
        resposta = nota3 / 2;

        Console.WriteLine("a media das suas notas é:{0}", resposta);


        double nota1, nota2, nota3, resposta;

        Console.Write("digite a nota 1:");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("digite a nota 2:");
        nota2 = Convert.ToDouble(Console.ReadLine());

        nota3 = (nota1 + nota2) / 2;

        Console.WriteLine("a media das suas notas é:{0}", nota3);






    }
}