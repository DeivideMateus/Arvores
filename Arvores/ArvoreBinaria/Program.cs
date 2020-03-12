using System;

namespace ArvoreBinaria
{
    class Program
    {
        static void Main(string[] args)
        {

            BinaryTree<int, string> arvore = new BinaryTree<int, string>();

            arvore.Adicionar(50, "Deivide");
            arvore.Adicionar(30, "Lucas");
            arvore.Adicionar(70, "Leo");
            arvore.Adicionar(75, "Cissa");
            arvore.Adicionar(60, "Mateus");
            arvore.Adicionar(35, "Moura");
            arvore.Adicionar(25, "Selma");


            //Console.WriteLine(arvore.Raiz.Valor);
            //Console.WriteLine(arvore.Raiz.Esquerdo.Valor);
            //Console.WriteLine(arvore.Raiz.Direito.Valor);

            No<int, string> noBuscado = arvore.Buscar(25);
            Console.WriteLine(noBuscado.Valor);
            Console.WriteLine(noBuscado.Pai.Valor);

            Console.WriteLine("\n");
            arvore.NavegarEmOrdem(arvore.Raiz);
            Console.WriteLine("\n");
            arvore.NavegarPreOrdem(arvore.Raiz);
            Console.WriteLine("\n");
            arvore.NavegarPosOrdem(arvore.Raiz);

            Console.ReadLine();
        }
    }
}
