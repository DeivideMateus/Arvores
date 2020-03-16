using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreBinaria
{
    class Tabela<T, F>
    {
        public string Nome { get; set; }

        object[] registros = new object[10];
        BinaryTree<int, F>[] trees = new BinaryTree<int, F>[10];
    }
}
