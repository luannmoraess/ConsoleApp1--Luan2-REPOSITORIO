﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1__Luan2
{
    internal class Veiculos
    {
        public int numeroRodas;
        public int numeroPortas;
        public string Cor;
        public int quantidadeAcento;
        public bool PagaImposto;
        public string ExibirDados()
        {
            return "Nº Portas:" + numeroPortas + " Cor:" + Cor;
        }
       
    }
    
}
