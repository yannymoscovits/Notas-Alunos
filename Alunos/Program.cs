using System;

namespace Alunos
{
    class Program
    {
        static void Main (string[] args)
        {
            Aluno a1 = new Aluno();

            Console.Write("Insira o Nome do Aluno: ");
            a1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a três notas do aluno: ");
            a1.Nota1 = double.Parse(Console.ReadLine());
            a1.Nota2 = double.Parse(Console.ReadLine());
            a1.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Notal Final = " + a1.NotaFinal().ToString("F2"));
            Console.WriteLine(a1.Resultado());

            


        }
    }

}