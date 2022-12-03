using Questao2.Model;

namespace Questao2.View{

    public interface IPalavras{

        public void registraContador(ContaPalavras contaPalavras);
        public void removeContador(ContaPalavras contaPalavras);
        public void notificaContadores(); 

    }
}