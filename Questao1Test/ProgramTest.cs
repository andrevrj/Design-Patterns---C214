using Questao1.Controller;
using Questao1.Model;

namespace Questao1Test
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestOrdenaDDD()
        {
            Telefone telefone = new Telefone("Sabrina", 1998, "Avenida Brasil");
            telefone.telefone = "(35)1234-5678";
            Telefone telefone1 = new Telefone("Pedro", 1998, "Avenida Brasil");
            telefone1.telefone = "(35)9876-4567";
            Telefone telefone2 = new Telefone("André", 1966, "Rua da Pedra");
            telefone2.telefone = "(35)2345-78951";

            List<Telefone> tels = new List<Telefone>();
            tels.Add(telefone);
            tels.Add(telefone1);
            tels.Add(telefone2);

            DDD ddd = new DDD(tels);

            Assert.AreEqual(ddd.ordenar()[0].getDDD(), 11);
            Assert.AreEqual(ddd.ordenar()[1].getDDD(), 19);
            Assert.AreEqual(ddd.ordenar()[2].getDDD(), 61);
        }

        [TestMethod]
        public void TestOrdenaNumero()
        {
            Telefone telefone = new Telefone("Sabrina", 1998, "Avenida Brasil");
            telefone.telefone = "(35)1234-5678";
            Telefone telefone1 = new Telefone("Pedro", 1985, "Rua do Samba");
            telefone1.telefone = "(35)9876-4567";
            Telefone telefone2 = new Telefone("André", 1966, "Rua da Pedra");
            telefone2.telefone = "(35)2345-78951";

            List<Telefone> tels = new List<Telefone>();
            tels.Add(telefone);
            tels.Add(telefone1);
            tels.Add(telefone2);

            Numero numero = new Numero(tels);

            Assert.AreEqual(numero.ordenar()[0].getNumero(), 1997948146);
            Assert.AreEqual(numero.ordenar()[1].getNumero(), 6112344321);
            Assert.AreEqual(numero.ordenar()[2].getNumero(), 11912342345);
        }

        [TestMethod]
        public void TestOrdenaOperadora()
        {
            Telefone telefone = new Telefone("Sabrina", 1998, "Avenida Brasil");
            telefone.telefone = "(35)1234-5678";
            Telefone telefone1 = new Telefone(Pedro", 1985, "Rua do Samba");
            telefone1.telefone = "(35)9876-4567";
            Telefone telefone2 = new Telefone("André", 1966, "Rua da Pedra");
            telefone2.telefone = "(35)2345-78951";

            List<Telefone> tels = new List<Telefone>();
            tels.Add(telefone);
            tels.Add(telefone1);
            tels.Add(telefone2);

            Operadora operadora = new Operadora(tels);

            Assert.AreEqual(operadora.ordenar()[0].getOperadora(), 1234);
            Assert.AreEqual(operadora.ordenar()[1].getOperadora(), 9794);
            Assert.AreEqual(operadora.ordenar()[2].getOperadora(), 91234);
        }

        [TestMethod]
        public void TestDDD()
        {
            Telefone telefone = new Telefone("Sabrina", 1998, "Avenida Brasil");
            telefone.telefone = "(35)1234-5678";
            Telefone telefone1 = new Telefone(Pedro", 1985, "Rua do Samba");
            telefone1.telefone = "(35)9876-4567";
            Telefone telefone2 = new Telefone("André", 1966, "Rua da Pedra");
            telefone2.telefone = "(35)2345-78951";

            List<Telefone> tels = new List<Telefone>();
            tels.Add(telefone);
            tels.Add(telefone1);
            tels.Add(telefone2);

            ListaTelefonica lista = new DDD(tels);

            Assert.IsInstanceOfType(lista, typeof(DDD));
        }

        [TestMethod]
        public void TestOperadora()
        {
            Telefone telefone = new Telefone("Sabrina", 1998, "Avenida Brasil");
            telefone.telefone = "(35)1234-5678";
            Telefone telefone1 = new Telefone(Pedro", 1985, "Rua do Samba");
            telefone1.telefone = "(35)9876-4567";
            Telefone telefone2 = new Telefone("André", 1966, "Rua da Pedra");
            telefone2.telefone = "(35)2345-78951";

            List<Telefone> tels = new List<Telefone>();
            tels.Add(telefone);
            tels.Add(telefone1);
            tels.Add(telefone2);

            ListaTelefonica lista = new Operadora(tels);

            Assert.IsInstanceOfType(lista, typeof(Operadora));
        }

        [TestMethod]
        public void TestNumero()
        {
            Telefone telefone = new Telefone("Sabrina", 1998, "Avenida Brasil");
            telefone.telefone = "(35)1234-5678";
            Telefone telefone1 = new Telefone(Pedro", 1985, "Rua do Samba");
            telefone1.telefone = "(35)9876-4567";
            Telefone telefone2 = new Telefone("André", 1966, "Rua da Pedra");
            telefone2.telefone = "(35)2345-78951";

            List<Telefone> tels = new List<Telefone>();
            tels.Add(telefone);
            tels.Add(telefone1);
            tels.Add(telefone2);

            ListaTelefonica lista = new Numero(tels);

            Assert.IsInstanceOfType(lista, typeof(Numero));
        }
    }
}