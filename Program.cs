using System;

namespace NotasMusicais
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroInicial = 0;
            int numeroFinal = 0;

            Console.WriteLine("************** Notas Musicais ************");

            Console.WriteLine("Digite o número inicial:");
            numeroInicial = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número final:");
            numeroFinal = Convert.ToInt32(Console.ReadLine());


            int totalImprimir = numeroFinal - numeroInicial;
            int contadorNotas = numeroInicial;

            while (contadorNotas < numeroFinal)
            {
                int notaAtual = contadorNotas;
                if (contadorNotas > 6)
                {
                    notaAtual = notaAtual - 7;
                }

                Console.Write(" " + labelNotaMusical(notaAtual) + " ");
                contadorNotas++;
            }
        }

        public static string labelNotaMusical(int notaMusical)
        {
            switch (notaMusical)
            {
                case 0:
                    return "Dó";
                    
                case 1:
                    return "Ré";
                case 2:
                    return "Mi";
                case 3:
                    return "Fá";
                case 4:
                    return "Sol";
                case 5:
                    return "Lá";
                case 6:
                    return "Si";
                default:
                    return "Não musícal não encontrada";
            }
        }
    }
}
