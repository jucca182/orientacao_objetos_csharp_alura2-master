﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank1._1.funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar(double salario, string cpf) : base(salario, cpf)
        {

        }
        public override double GetBonificacao() //retorna a bonificacao
        {
            return Salario *0.50;
        }
        public override void AumentarSalario(int porcentagem_aumento)
        {
            this.Salario += this.Salario * porcentagem_aumento / 100;
        }
    }
}
