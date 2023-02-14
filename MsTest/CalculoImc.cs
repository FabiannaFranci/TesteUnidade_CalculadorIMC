using ImcTeste;

namespace MsTest
{
    [TestClass]
    public class CalculoImc
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            double peso = 60;
            double altura = 1.54;
            double imc = 25.3;

            //act
            var resultadoConta = Operacoes.ImcConta(peso, altura);

            //assert
            Assert.AreEqual(imc, resultadoConta);
        }
    }
}