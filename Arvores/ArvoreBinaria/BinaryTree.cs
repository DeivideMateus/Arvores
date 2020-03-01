using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreBinaria
{
    class BinaryTree
    {
        public No Raiz { get; set; }


        public void Adicionar(int chave, object valor)
        {
            No novoNo = new No(chave, valor);

            if (this.Raiz == null)
            {
                this.Raiz = novoNo;
            }
            else
            {
                No noAtual = this.Raiz;
                No noPai;

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

        public BinaryTree(No novoNo)
        {
            this.Raiz = novoNo;
        }

    }
}
