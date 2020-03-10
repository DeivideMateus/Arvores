using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreBinaria
{
    class BancoDeDados<T>
    {
        Tabela<object, T>[] tabelas = new Tabela<object, T>[10];
    }

    class Tabela<T, F>
    {
        object[] registros = new object[10];
        BinaryTree<int, F>[] trees = new BinaryTree<int, F>[10];
    }
}
