﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TXT
{
    class Cliente
    {
        private string nome;
        private string caminho;

        public Cliente(string nome, string caminho)
        {
            this.nome = nome;
            this.caminho = caminho;
        }

        public void gravar()
        {
            File.WriteAllText(this.caminho, this.nome);
        }

        public void apagar()
        {
            File.Delete(this.caminho);
        }
    }
}
