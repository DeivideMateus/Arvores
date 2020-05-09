using System;

namespace ArvoreBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = -1;
            No noBuscado;
            BinaryTree arvore = new BinaryTree();


            while (opcao != 0)
            {
                Console.WriteLine("\n1 - Adicionar                        2 - Buscar\n" +
                                  "3 - Remover                          4 - Navegar in-ordem\n" +
                                  "5 - Navegar pos-ordem                6 - Navegar pre-ordem\n" +
                                  "7 - Retornar Maior e menor valor     8 - Retornar média\n" +
                                  "9 - Retornar Numero de nós           10- Retornar Número de folhas\n" +
                                  "11- Retornar Altura                  0 - Sair");

                Console.Write("\nInforme o número da opção desejada: ");
                string digitado = Console.ReadLine();
                opcao = Int32.Parse(digitado);

                if (opcao == 1)
                {
                    Console.Write("\nInforme o valor: ");
                    int valor = Int32.Parse(Console.ReadLine());
                    arvore.Adicionar(valor);
                }
                else if (opcao == 2)
                {
                    Console.Write("\nInforme o valor: ");
                    int valor = Int32.Parse(Console.ReadLine());
                    noBuscado = arvore.Buscar(valor);
                    if (noBuscado == null)
                    {
                        Console.WriteLine(" Valor não encontrado");
                    }
                    else
                    {
                        Console.WriteLine(" Valor {0} encontrado", noBuscado.Valor);
                    }
                }
                else if (opcao == 3)
                {
                    Console.Write("\nInforme o valor: ");
                    int valor = Int32.Parse(Console.ReadLine());
                    arvore.Remover(valor);
                }
                else if (opcao == 4)
                {
                    Console.Write(" in-ordem:");
                    arvore.NavegarEmOrdem();
                    Console.Write("\n");
                }
                else if (opcao == 5)
                {
                    Console.Write(" pos-ordem:");
                    arvore.NavegarPosOrdem();
                    Console.Write("\n");
                }
                else if (opcao == 6)
                {
                    Console.Write(" pre-ordem:");
                    arvore.NavegarPreOrdem();
                    Console.Write("\n");
                }
                else if (opcao == 7)
                {
                    arvore.GetMaiorMenorValor();
                }
                else if (opcao == 8)
                {
                    Console.WriteLine(" Média dos valores: {0}", arvore.GetMedia());
                }
                else if (opcao == 9)
                {
                    Console.WriteLine(" Número de nós da árvore: {0}", arvore.QuantidadeNos);
                }
                else if (opcao == 10)
                {
                    Console.WriteLine(" Número de folhas da árvore: {0}", arvore.GetNumeroDeFolhas());
                }
                else if (opcao == 11)
                {
                    Console.WriteLine(" Altura da árvore: {0}", arvore.GetAltura());
                }
            }

            Console.ReadLine();
        }
    }
}
