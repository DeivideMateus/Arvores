using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreBinaria
{
    public class No<T, F>
    {
        public T Chave { get; set; }
        public F Valor { get; set; }
        public No<T, F> Esquerdo { get; set; }
        public No<T, F> Direito { get; set; }
        public No<T, F> Pai { get; set; }

        public No()
        {

        }

        public No(T chave, F valor)
        {
            this.Chave = chave;
            this.Valor = valor;
            this.Esquerdo = null;
            this.Direito = null;
        }
    }
}
