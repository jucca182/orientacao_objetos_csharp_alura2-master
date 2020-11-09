﻿using ByteBank1._1.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank1._1.funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(double salario, string cpf) : base(salario, cpf)
        {

        }

        public override double GetBonificacao() //retorna a bonificacao
        {
            return Salario ;
        }

        public override void AumentarSalario(int porcentagem_aumento)
        {
            this.Salario += this.Salario * porcentagem_aumento / 100;
        }
        
    }
}
