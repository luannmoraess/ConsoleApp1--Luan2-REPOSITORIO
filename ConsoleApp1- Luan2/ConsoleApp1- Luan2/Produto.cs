﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1__Luan2
{
    internal class Produto
    {
        private int Id;
        private string Descricao;
        private decimal Valor;

        public Produto(int id, string descricao, decimal valor)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
        }
        public string getId()
        {
            return Descricao;
        }
        public void setId(int id)
        {
            if (id > 0)
            {
                Id = id;
            }
        }
        public decimal getValor()
        {
            return Valor;
        }
        public void setValor(decimal valor)
        {
            Valor = valor;
        }
        public void setDescricao(string descricao)
        {
            Descricao = descricao;
        }
        public string getDescricao()
        {
            return Descricao;
        }

       
    }


}
