using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreBinaria
{
   public class BinaryTree<T, F>
    {
        public No<T, F> Raiz { get; set; }

        public void Adicionar(T chave, F valor)
        {
            No<T, F> novoNo = new No<T, F>( chave,  valor);

            if (this.Raiz == null)
            {
                this.Raiz = novoNo;
            }
            else
            {
                No<T, F> noAtual = this.Raiz;
                No<T, F> noPai;

                while (true)
                {
                    noPai = noAtual;
                    if (chave < noAtual.Chave)
                    {
                        noAtual = noAtual.Esquerdo;

                        if (noAtual == null)
                        {
                            noPai.Esquerdo = novoNo;
                            noPai.Esquerdo.Pai = noPai;
                            return;
                        }
                    }
                    else
                    {
                        noAtual = noAtual.Direito;

                        if (noAtual == null)
                        {
                            noPai.Direito = novoNo;
                            noPai.Direito.Pai = noPai;
                            return;
                        }
                    }
                }

            }
        }





        public BinaryTree()
        {

        }

        public BinaryTree(No<T> novoNo)
        {
            this.Raiz = novoNo;
        }

    }
}
