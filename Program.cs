using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem vindo para para o quiz!! ");
            Console.ReadLine();
            Console.WriteLine("Vamos responde perguntas basicas de geografia!! ");
            Console.ReadLine();
            Console.WriteLine("1 - Quantos oceanos existem no planeta? ");
            Console.WriteLine("\r\n a) 4 oceanos\r\n b) 6 oceanos\r\n c) 3 oceanos\r\n d) 8 oceanos");
            string Resposta1 = Console.ReadLine();

            if (Resposta1 == "a")
            {
                Console.WriteLine(" Parabens você acertou");
            }
            else
            {
                Console.WriteLine("putz errou feio!");
            }


            Console.WriteLine("2 - Qual e a capital do brasil? ");
            Console.WriteLine("\r\n a) brasília\r\n b) São paulo\r\n c) Natal\r\n d) amazonia\r\n");
            string Resposta2 = Console.ReadLine();

            if (Resposta2 == "a")
            {
                Console.WriteLine(" Parabens você acertou");
            }
            else
            {
                Console.WriteLine("putz errou feio!");
            }


            Console.WriteLine("3 - Quanto tempo a luz do Sol demora para chegar à Terra? ");
            Console.WriteLine("\r\n a) 12 minutos\r\n b) 1 dia\r\n c) 12 horas\r\n d) 8 minutos\r\n");
            string Resposta3 = Console.ReadLine();

            if (Resposta3 == "d")
            {
                Console.WriteLine(" Parabens você acertou");
            }
            else
            {
                Console.WriteLine("putz errou feio!");
            }


            Console.WriteLine("4 - Nyellyson é bonito? ");
            Console.WriteLine("\r\n a) da para o gasto\r\n b) é muito lindo\r\n c) é muito feio\r\n d) eca");
            string Resposta4 = Console.ReadLine();

            if (Resposta1 == "a")
            {
                Console.WriteLine(" Parabens você acertou");
            }
            else
            {
                Console.WriteLine("putz errou feio!");
            }



            Console.ReadLine();
        }
    }
}
