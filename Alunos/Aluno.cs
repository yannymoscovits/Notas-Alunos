using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos
{
    internal class Aluno
    {

        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string Resultado()
        {
            
            if (NotaFinal() >= 60)
            {
                return "Aprovado!";
            }
            else
            {
                return " Reprovado! Faltaram " + FaltamPontos() + " Pontos";
                
            }
        }
        public double FaltamPontos()
        {
            return 60 - NotaFinal();
        }
    }
}
