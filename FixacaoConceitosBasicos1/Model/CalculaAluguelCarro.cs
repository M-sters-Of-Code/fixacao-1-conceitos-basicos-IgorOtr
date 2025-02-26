using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    public class CalculaAluguelCarro
    {
        public static int Calcular(int dias, int quilometragemInicial, int quilometragemFinal)
        {
            int diferencaQuilometragem = quilometragemFinal - quilometragemInicial;
            int valorTotalAluguel = diferencaQuilometragem * dias;

            return valorTotalAluguel;
        }
    }
}
