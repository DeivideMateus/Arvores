using System;

namespace ArvoreBinaria
{
    class Program
    {
        static void Main(string[] args)
        {

            BinaryTree<int, string> arvore = new BinaryTree<int, string>();

            arvore.Adicionar(50, "Deivide");
            arvore.Adicionar(65, "Leo");
            arvore.Adicionar(75, "Cissa");
            arvore.Adicionar(85, "Mateus");
            arvore.Adicionar(70, "Moura");
            arvore.Adicionar(45, "Lucas");
            arvore.Adicionar(46, "Selma");
            arvore.Adicionar(35, "Selma");
            arvore.Adicionar(15, "Selma");
            arvore.Adicionar(5, "Selma");
            arvore.Adicionar(40, "Selma");
            arvore.Adicionar(42, "Selma");
            arvore.Adicionar(43, "Lucas");
            arvore.Adicionar(38, "Selma");
            arvore.Adicionar(36, "Selma");

            //No<int, string> noBuscado = arvore.Buscar(25);
            //Console.WriteLine(noBuscado.Valor);
            //Console.WriteLine(noBuscado.Pai.Valor);

            Console.WriteLine("\n");
            arvore.NavegarEmOrdem(arvore.Raiz);
            Console.WriteLine("\n");          
            arvore.NavegarPreOrdem(arvore.Raiz);
            Console.WriteLine("\n");
            arvore.NavegarPosOrdem(arvore.Raiz);
            Console.WriteLine("\n");

            //arvore.Remover(75);

            /*arvore.NavegarEmOrdem(arvore.Raiz);
            Console.WriteLine("\n");

            arvore.Remover(70);

            arvore.NavegarEmOrdem(arvore.Raiz);
            Console.WriteLine("\n");

            arvore.Remover(30);

            arvore.NavegarEmOrdem(arvore.Raiz);
            Console.WriteLine("\n");

            Console.WriteLine(arvore.Buscar(60).Pai.Chave +" "+ arvore.Buscar(60).Pai.Valor);
            Console.WriteLine(arvore.Buscar(25).Pai.Chave + " " + arvore.Buscar(25).Pai.Valor);*/

            Console.ReadLine();
        }
    }
}
