﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNotas.Model
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public string Status { get { return Resultado();}}

        string Resultado()
        {
            var media = (Nota1 + Nota2 + Nota3) / 3 >= 7 ? "Aprovado" : "Reprovado";
            return media;
        }
    }
}
