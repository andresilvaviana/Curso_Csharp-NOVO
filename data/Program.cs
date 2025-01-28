﻿using System.Security.Cryptography;

namespace data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meses = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            int[] dias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            

            for (int i = 0; i < meses.Length; i++)
            {
                Console.WriteLine("O mes de " + meses[i] + " tem " + dias[i] + " dias.");

            }
            string[] semana = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado" };
            
            Console.WriteLine();

            foreach (string dia in semana)
            {
                Console.WriteLine(dia);
            }

            Console.WriteLine();
            foreach (string mes in meses)
            {
                Console.WriteLine(mes);
            }
        }
    }
}
