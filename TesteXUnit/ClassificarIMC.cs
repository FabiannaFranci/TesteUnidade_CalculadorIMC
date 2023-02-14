using ImcTeste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteXUnit
{
    public class ClassificarIM
    {
        [Fact]
        public void Test2()
        {
            double imc = 30;

            var resultadoImc = Operacoes.ImcResultado(imc);

            Assert.Equal("Obesidade", resultadoImc);
        }
        [Theory]
        [InlineData(39, "Obesidade")]
        [InlineData(28 ,"Sobrepeso")]
        public void CalculoImc_ListaDeValoires(double imc, string resultadoesperado)
        {
            var resultadoimc = Operacoes.ImcResultado(imc);

            Assert.Equal(resultadoesperado, resultadoimc);
        }

    }
}
