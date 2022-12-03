using Questao2.Controller;
using Questao2.Model;

namespace Questao2Test
{
    [TestClass]
    public class ProgramTest
    {

        [TestMethod]
        public void TestListaContadores()
        {
            Palavras palavras = new Palavras();
           
            Assert.IsTrue(!palavras.getContadores().Any());
        }

        [TestMethod]
        public void TestRegistraContador()
        {
            Palavras palavras = new Palavras();
            ContaPalavras cp1 = new ContaPalavras(1);
            ContaPalavras cp2 = new ContaPalavras(2);

            palavras.registraContador(cp1);
            palavras.registraContador(cp2);

            Assert.AreEqual((palavras.getContadores().Count()), 2);
        }

        [TestMethod]
        public void TestRemoveContador()
        {
            Palavras palavras = new Palavras();
            ContaPalavras cp1 = new ContaPalavras(1);
            ContaPalavras cp2 = new ContaPalavras(2);

            palavras.registraContador(cp1);
            palavras.registraContador(cp2);
  
            palavras.removeContador(cp2);

            Assert.AreEqual((palavras.getContadores().Count()), 1);
        }

        [TestMethod]
        public void TestTotalPalavras()
        {
            AnalisaPalavras analisa = new AnalisaPalavras();

            analisa.calcula("O fim é só o princípio");

            Assert.AreEqual(analisa.totalPalavras, 6);
        }

        [TestMethod]
        public void TestPalavrasMaiusculas()
        {
            AnalisaPalavras analisa = new AnalisaPalavras();

            analisa.calcula("O fim é Só o Princípio");

            Assert.AreEqual(analisa.palavrasMaiusculas, 3);
        }

        [TestMethod]
        public void TestQtdParesCaracteres()
        {
            AnalisaPalavras analisa = new AnalisaPalavras();

            analisa.calcula("O fim é só o princípio");

            Assert.AreEqual(analisa.qtdParesCaracteres, 1);
        }
    }
}