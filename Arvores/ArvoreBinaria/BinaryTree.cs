using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreBinaria
{
    public class BinaryTree<T, F> where T : IComparable
    {
        public No<T, F> Raiz { get; set; }


        public void Adicionar(T chave, F valor)
        {
            No<T, F> novoNo = new No<T, F>(chave, valor);

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
                    if (chave.CompareTo(noAtual.Chave) < 0)
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

        public No<T, F> Buscar(T chave)
        {
            No<T, F> noAtual = this.Raiz;

            while (!noAtual.Chave.Equals(chave))
            {
                if (chave.CompareTo(noAtual.Chave) < 0)
                {
                    noAtual = noAtual.Esquerdo;
                }
                else
                {
                    noAtual = noAtual.Direito;
                }
                if (noAtual == null)
                {
                    return null;
                }
            }
            return noAtual;
        }

        public void Remover(T chave)
        {

        }

        public void NavegarEmOrdem(No<T, F> no)
        {
            if (no != null){
                NavegarEmOrdem(no.Esquerdo);
                Console.Write(" " + no.Chave);
                NavegarEmOrdem(no.Direito);
            }
        }

        public void NavegarPreOrdem(No<T, F> no)
        {
            if (no != null)
            {            
                Console.Write(" " + no.Chave);
                NavegarEmOrdem(no.Esquerdo);
                NavegarEmOrdem(no.Direito);
            }
        }

        public void NavegarPosOrdem(No<T, F> no)
        {
            if (no != null)
            {
                NavegarEmOrdem(no.Esquerdo);               
                NavegarEmOrdem(no.Direito);
                Console.Write(" " + no.Chave);
            }
        }



        public BinaryTree()
        {

        }

        public BinaryTree(No<T, F> novoNo)
        {
            this.Raiz = novoNo;
        }

    }
}
