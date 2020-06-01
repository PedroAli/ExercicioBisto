using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static List<Aluno> listaDeAlunos;
        static void Main(string[] args)
        {
            listaDeAlunos = new List<Aluno>();
            listaDeAlunos.Add(new Aluno(5,"pedro"));
            listaDeAlunos.Add(new Aluno(10, "João"));

            foreach (var Aluno in listaDeAlunos)
            {
                Console.WriteLine(Aluno.Nota + " " + Aluno.Nome);
            }

        }
    }
}
