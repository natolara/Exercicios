using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto +(SalarioBruto * porcentagem)/100;
        }

        public override string ToString()
        {
            return Nome + " R$ "+ SalarioLiquido();
        }
    }
}
