using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreBinaria
{
    class BancoDeDados<T>
    {
        Tabela<object, T>[] tabelas = new Tabela<object, T>[10];
    }
}
