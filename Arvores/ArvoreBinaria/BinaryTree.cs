using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ArvoreBinaria
{
    public class BinaryTree
    {
        private int numeroDeFolhas;
        private double soma;
        public double QuantidadeNos { get; set; }
        public No Raiz { get; set; }



        public void Adicionar(int valor)
        {
            No novoNo = new No(valor);

            if (this.Raiz == null)
            {
                this.Raiz = novoNo;
                QuantidadeNos++;
                this.soma = soma + valor;
            }
            else
            {
                No noAtual = this.Raiz;
                No noPai;

                while (true)
                {
                    noPai = noAtual;
                    if (valor.CompareTo(noAtual.Valor) < 0)
                    {
                        noAtual = noAtual.Esquerdo;

                        if (noAtual == null)
                        {
                            noPai.Esquerdo = novoNo;
                            noPai.Esquerdo.Pai = noPai;
                            QuantidadeNos++;
                            this.soma = soma + valor;
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
                            QuantidadeNos++;
                            this.soma = soma + valor;
                            return;
                        }
                    }
                }

            }
        }
        public No Buscar(int chave)
        {
            No noAtual = this.Raiz;

            while (!noAtual.Valor.Equals(chave))
            {
                if (chave.CompareTo(noAtual.Valor) < 0)
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
        public void Remover(int chave)
        {
            No noParaRemover = Buscar(chave);
            if (noParaRemover != null)
            {
                RemoverRecursivo(noParaRemover);
                QuantidadeNos--;
                this.soma = soma - chave;
            }
            else
            {
                Console.WriteLine("O valor informado não existe!");
            }
        }
        private void RemoverRecursivo(No noParaRemover)
        {
            //Remoção de nó folha
            if (noParaRemover.Esquerdo == null && noParaRemover.Direito == null)
            {

                if (noParaRemover.Pai.Esquerdo.Valor.Equals(noParaRemover.Valor))
                {
                    noParaRemover.Pai.Esquerdo = null;
                }
                else
                {
                    noParaRemover.Pai.Direito = null;
                }
                return;
            }

            //Remoção de nó com 1 filho
            if (noParaRemover.Esquerdo == null)
            {
                if (noParaRemover.Pai.Esquerdo.Valor.Equals(noParaRemover.Valor))
                {
                    noParaRemover.Pai.Esquerdo = noParaRemover.Direito;
                    noParaRemover.Direito.Pai = noParaRemover.Pai;
                }
                else
                {
                    noParaRemover.Pai.Direito = noParaRemover.Direito;
                    noParaRemover.Direito.Pai = noParaRemover.Pai;
                }
                return;
            }
            else if (noParaRemover.Direito == null)
            {
                if (noParaRemover.Pai.Esquerdo.Valor.Equals(noParaRemover.Valor))
                {
                    noParaRemover.Pai.Esquerdo = noParaRemover.Esquerdo;
                    noParaRemover.Esquerdo.Pai = noParaRemover.Pai;
                }
                else
                {
                    noParaRemover.Pai.Direito = noParaRemover.Esquerdo;
                    noParaRemover.Esquerdo.Pai = noParaRemover.Pai;
                }
                return;
            }

            //Remoção de nó com 2 filhos
            No noSucessor = ObterSucessor(noParaRemover);

            noParaRemover.Valor = noSucessor.Valor;
            noParaRemover.Valor = noSucessor.Valor;

            RemoverRecursivo(noSucessor);
        }
        public No ObterSucessor(No noParaRemover)
        {
            No noSucessor = noParaRemover.Direito;

            while (noSucessor.Esquerdo != null)
            {
                noSucessor = noSucessor.Esquerdo;
            }

            return noSucessor;
        }

        public void NavegarEmOrdem()
        {
            NavegarEmOrdem(this.Raiz);
        }
        private void NavegarEmOrdem(No no)
        {
            if (no != null)
            {
                NavegarEmOrdem(no.Esquerdo);
                Console.Write(" " + no.Valor);
                NavegarEmOrdem(no.Direito);
            }
        }

        public void NavegarPreOrdem()
        {
            NavegarPreOrdem(this.Raiz);
        }
        private void NavegarPreOrdem(No no)
        {
            if (no != null)
            {
                Console.Write(" " + no.Valor);
                NavegarPreOrdem(no.Esquerdo);
                NavegarPreOrdem(no.Direito);
            }
        }

        public void NavegarPosOrdem()
        {
            NavegarPosOrdem(this.Raiz);
        }
        private void NavegarPosOrdem(No no)
        {
            if (no != null)
            {
                NavegarPosOrdem(no.Esquerdo);
                NavegarPosOrdem(no.Direito);
                Console.Write(" " + no.Valor);
            }
        }

        public void GetMaiorMenorValor()
        {
            No noAtualMenor = this.Raiz;
            No noAtualMaior = this.Raiz;
            int maior = noAtualMaior.Valor;
            int menor = noAtualMenor.Valor;

            while (noAtualMenor.Esquerdo != null)
            {
                noAtualMenor = noAtualMenor.Esquerdo;
                menor = noAtualMenor.Valor;
            }

            while (noAtualMaior.Direito != null)
            {
                noAtualMaior = noAtualMaior.Direito;
                maior = noAtualMaior.Valor;
            }

            Console.WriteLine(" Maior valor: {0} \n Menor valor: {1}", maior, menor);
        }
        public double GetMedia()
        {
            return this.soma / QuantidadeNos;
        }
        private void IncrementarFolhas(No no)
        {
            if (no != null)
            {
                if (no.Esquerdo == null && no.Direito == null)
                {
                    numeroDeFolhas++;
                }
                IncrementarFolhas(no.Esquerdo);
                IncrementarFolhas(no.Direito);
            }
        }
        public int GetNumeroDeFolhas()
        {
            this.numeroDeFolhas = 0;
            this.IncrementarFolhas(this.Raiz);
            return this.numeroDeFolhas;
        }

        public int GetAltura()
        {
            return GetAltura(this.Raiz);
        }
        private int GetAltura(No no)
        {
            if (no != null)
            {
                int alturaEsquerda, alturaDireita;

                alturaEsquerda = GetAltura(no.Esquerdo);
                alturaDireita = GetAltura(no.Direito);

                if (alturaEsquerda > alturaDireita)
                {
                    return alturaEsquerda + 1;
                } 
                else
                {
                    return alturaDireita + 1;
                }
            }
            return 0;
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
