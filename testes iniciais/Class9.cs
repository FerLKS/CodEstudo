﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro
{
    class Estudante
    {
        public string Nome;
        public string Email;
        public string quarto;

        public Estudante(string nome, string email)
        {
                Nome = nome;
                Email = email;
        }
        public override string ToString()
        {
            return Nome + ", " + Email;
        }

        
    }
}
