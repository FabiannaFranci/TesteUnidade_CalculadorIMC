using ImcTeste;

namespace TesteXUnit
{
    public class CalculoIMC
    {
        [Fact]
        public void Test1()
        {
            double peso = 80;
            double altura = 1.50;
            double imc = 35.56;

            var calculoImc = Operacoes.ImcConta(peso, altura);

            Assert.Equal(imc, calculoImc);
        }
    }
}