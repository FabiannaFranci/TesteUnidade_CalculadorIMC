using ImcTeste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTest
{
    [TestClass]
    public class ClassificarImc
    {
        [TestMethod]
        public void TestMethod2()
        {
            //arramne
            double imc = 25.3;

            //act
            var resultadoImc = Operacoes.ImcResultado(imc);

            //assert
            Assert.AreEqual("Sobrepeso", resultadoImc);
        }

    }
}
