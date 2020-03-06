using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreBinaria
{
    class BancoDeDados<T>
    {
        Tabela<T>[] tabelas = new Tabela<T>[10];
    }

    class Tabela<T>
    {
        object[] registros = new object[10];
        BinaryTree<int, int>[] trees = new BinaryTree<int, int>[10];
    }
}
