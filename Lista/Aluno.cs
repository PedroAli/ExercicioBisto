using System;
using System.Collections.Generic;
using System.Text;

namespace Lista
{
    public class Aluno
    {
        public Aluno() { }

        public string Nome { get; set; }
        public int Nota { get; set; }
        public Aluno(int nota, string nome)
        {
            this.Nota = nota;
            this.Nome = nome;
        }
    }
}
