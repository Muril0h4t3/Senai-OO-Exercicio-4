using System;
using senai.OO.exercicio4.Classes;

namespace senai.OO.exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            Cartao cartao1 = new Cartao();

            Console.WriteLine("Insira o nimero do cartâo");
            cartao1.ndocartao = Console.ReadLine();

            Console.WriteLine("Insira o dia de vencimento do cartão");
            cartao1.vencimentod = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o mês de vencimento do cartão");
            cartao1.vencimentoM = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o ano de vencimento do cartão");
            cartao1.vencimentoy = int.Parse(Console.ReadLine());

            Console.WriteLine($"O cartão de número {cartao1.ndocartao} Vence {cartao1.vencimentod}/{cartao1.vencimentoM}/{cartao1.vencimentoy}");
            #endregion 

            #region 
            Cartao cartao2 = new Cartao();

            var dateTime = DateTime.Parse("10/05/1995");
           

            Console.WriteLine("Insira o nimero do cartâo");
            cartao2.ndocartao = Console.ReadLine();

            Console.WriteLine("Insira o dia de vencimento do cartão");
            cartao2.vencimentod = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o mês de vencimento do cartão");
            cartao2.vencimentoM = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o ano de vencimento do cartão");
            cartao2.vencimentoy = int.Parse(Console.ReadLine());

            Console.WriteLine($"O cartão de número {cartao2.ndocartao} Vence {cartao2.vencimentod}/{cartao2.vencimentoM}/{cartao2.vencimentoy}");
            #endregion 
        }
    }
}
