using System;

namespace Validando_nota
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota;
            int rep;

            rep = 1;
            while (rep == 1)
            { 
                Console.WriteLine("Validando nota");
                Console.WriteLine("---------------------");
                Console.Write("Digite sua nota: ");
                nota = float.Parse(Console.ReadLine());

                while (nota < 0 && nota > 10)
                {
                    Console.Write($"A nota {nota} é inválida. \n Digite a nota novamente: ");
                    nota = float.Parse(Console.ReadLine());   
                }
                if (nota >= 0 && nota <=4)
                {
                    Console.WriteLine("Nota vermelha. Deve melhorar!");
                }
                else if (nota >= 5 && nota <=7)
                {
                    Console.WriteLine("Nota azul porem na média. Pode melhorar!");
                }
                else
                {
                    Console.WriteLine("Parabéns!, continue assim.");
                }
                Console.WriteLine("Deseja continuar? \n [1] para continuar \n Qualquer outro numero para finalizar");
                rep = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("FIM");
        }
    }
}
