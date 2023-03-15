﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1__Luan2
{
    internal class Cliente
    {
        public int Id;
        public string Nome; 
        public string Telefone;
        private Endereco Endereco;

        public Cliente(int id, string nome, string telefone, Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }
        public int getId()
        {
            return Id;
        }
        public void setId(int id)
        {
            Id = id;
        }

        public string getNome()
        {
            return Nome;
        }
        public void setNome(string nome)
        {
            Nome = nome;
        }

        public string getTelefone()
        {
            return Telefone;
        }
        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }
       public void setEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }
        public Endereco getEndereco()
        {
            return Endereco;
        }
    }
   
}
