using System;

namespace ArvoreBinaria
{
    class Program
    {
        static void Main(string[] args)
        {

            BinaryTree arvore = new BinaryTree();

            arvore.Adicionar(50, 50);
            arvore.Adicionar(65, 65);
            arvore.Adicionar(75, 75);
            arvore.Adicionar(85, 85);
            arvore.Adicionar(70, 70);
            arvore.Adicionar(45, 45);
            arvore.Adicionar(46, 46);
            arvore.Adicionar(35, 35);
            arvore.Adicionar(15, 15);
            arvore.Adicionar(5, 5);
            arvore.Adicionar(40, 40);
            arvore.Adicionar(42, 42);
            arvore.Adicionar(43, 43);
            arvore.Adicionar(38, 38);
            arvore.Adicionar(36, 36);

            // Letra A
            Console.WriteLine("Letra A: \n");
            Console.Write(" in-ordem:");
            arvore.NavegarEmOrdem();
            Console.Write("\n\n pre-ordem:");          
            arvore.NavegarPreOrdem();
            Console.Write("\n\n pos-ordem:");
            arvore.NavegarPosOrdem();
            Console.WriteLine("\n");

            // Letra B
            Console.WriteLine("Letra B: \n");
            No noBuscado = arvore.Buscar(75);
            if (noBuscado == null)
            {
                Console.WriteLine(" Valor não encontrado");
            }
            else
            {
                Console.WriteLine(" Valor {0} encontrado", noBuscado.Valor);
            }

            // letra C
            Console.WriteLine("\nLetra C: \n");
            arvore.GetMaiorMenorNumero();

            // letra D
            Console.WriteLine("\nLetra D: \n");
            Console.WriteLine(" Média dos valores: {0}",arvore.GetMedia());

            // letra E
            Console.WriteLine("\nLetra E: \n");
            Console.WriteLine(" Número de nós da árvore: {0}", arvore.QuantidadeNos);

            // letra F
            Console.WriteLine("\nLetra F: \n");
            Console.WriteLine(" Número de folhas da árvore: {0}", arvore.GetNumeroDeFolhas());

            // letra G
            Console.WriteLine("\nLetra G: \n");
            Console.WriteLine(" Altura da árvore: {0}", arvore.GetAltura());

            // letra H

            arvore.Remover(75); //removendo nó com 2 filhos
            arvore.Remover(42); //removendo nó com 1 filho
            arvore.Remover(5);  //removendo nó folha

            Console.WriteLine("\nLetra H: \n");
            Console.Write(" Valores da árvore depois da remoção: ");
            arvore.NavegarEmOrdem();


            Console.ReadLine();
        }
    }
}
