﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreBinaria
{
    public class No
    {
        public int Chave { get; set; }
        public int Valor { get; set; }
        public No Esquerdo { get; set; }
        public No Direito { get; set; }
        public No Pai { get; set; }

        public No()
        {

        }

        public No(int chave, int valor)
        {
            this.Chave = chave;
            this.Valor = valor;
            this.Esquerdo = null;
            this.Direito = null;
        }
    }
}
