﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    public class CalculaDesconto
    {
        public static double Calcular(double salario, double aumento)
        {

            double aumentoAplicado = salario + aumento;

            return aumentoAplicado;
        }
    }
}
