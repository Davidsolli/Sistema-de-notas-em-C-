using System;

namespace Praticando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Cont = 0;
            int QuantidadeDeNotas = 0;
            int NumeroDoMenu = 6;
            float[] NotasDaTurma = new float[5];
            string[] NomesDosAlunos = new string[5];

            do
            {
                Console.WriteLine("MENU:\n");

                Console.WriteLine("1. Adicionar nome e nota do aluno a lista da turma.");
                Console.WriteLine("2. Ver lista de notas da turma.");
                Console.WriteLine("3. Ver maior nota da turma.");
                Console.WriteLine("4. Ver média de notas da turma.");
                Console.WriteLine("0. Sair.\n");

                Console.WriteLine("escolha uma opção:");

                NumeroDoMenu = Convert.ToInt32(Console.ReadLine());

                switch (NumeroDoMenu)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("Digite o nome do aluno:\n");
                        NomesDosAlunos[Cont] = Console.ReadLine();

                        Console.WriteLine("\nDigite a nota do aluno:\n");
                        NotasDaTurma[Cont] = float.Parse(Console.ReadLine());

                        QuantidadeDeNotas ++;
                        Cont ++;

                        MENU();
                        break;
                    case 2:

                        VisualizarListaDeNotas(Cont, QuantidadeDeNotas, NotasDaTurma, NomesDosAlunos);
                        break;
                    case 3:

                        VisualizarMaiorNota(Cont, QuantidadeDeNotas, NotasDaTurma, NomesDosAlunos);
                        break;
                    case 4:

                        VisualizarMediaDasNotas(Cont, QuantidadeDeNotas, NotasDaTurma, NomesDosAlunos);
                        break;
                }

            } while (NumeroDoMenu != 0);
        }

        static void MENU()
        {
            Console.WriteLine("\nAperte ENTER para voltar ao menu.");
            Console.ReadLine();
            Console.Clear();
        }

        static void VisualizarListaDeNotas(int Cont, int QuantidadeDeNotas, float[] NotasDaTurma, string[] NomesDosAlunos)
        {
            Console.Clear();

            Console.WriteLine("Lista de números:\n");

            for (Cont = 0; Cont < QuantidadeDeNotas; Cont++)
            {
                Console.WriteLine("Nome: " + NomesDosAlunos[Cont] + " Nota: " + NotasDaTurma[Cont]);
            }

            MENU();
        }

        static void VisualizarMaiorNota(int Cont, int QuantidadeDeNotas, float[] NotasDaTurma, string[] NomesDosAlunos)
        {
            Console.Clear();
            float MaiorNota = 0f;
            string AlunoMaisEsperto = null;

            for (Cont = 0; Cont < QuantidadeDeNotas; Cont++)
            {
                if(MaiorNota < NotasDaTurma[Cont])
                {
                    MaiorNota = NotasDaTurma[Cont];

                    AlunoMaisEsperto = NomesDosAlunos[Cont];
                }
            }

            Console.WriteLine("A maior nota foi: " + MaiorNota + " Aluno: " + AlunoMaisEsperto);

            MENU();
        }
        static void VisualizarMediaDasNotas(int Cont, int QuantidadeDeNotas, float[] NotasDaTurma, string[] NomesDosAlunos)
        {
            Console.Clear();

            float MediaDasNotas = 0f;

            for (Cont = 0; Cont < QuantidadeDeNotas; Cont++)
            {
                MediaDasNotas += NotasDaTurma[Cont] / QuantidadeDeNotas; 
            }

            Console.WriteLine("A média das notas: " + MediaDasNotas);

            MENU();
        }
    }
}
