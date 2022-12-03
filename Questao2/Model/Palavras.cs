using Questao2.View;

namespace Questao2.Model{

    public class Palavras : IPalavras
    {
        private string frase;
	    private List<ContaPalavras> contadores;

        public Palavras(){
            this.contadores = new List<ContaPalavras>();
            this.frase = "";
        }

        public void registraContador(ContaPalavras contaPalavras)
        {
            this.contadores.Add(contaPalavras);
        }

        public void removeContador(ContaPalavras contaPalavras)
        {
            if(this.contadores.Contains(contaPalavras)){
                this.contadores.Remove(contaPalavras);
            }
        }

          public void notificaContadores()
        {
            foreach(ContaPalavras cp in this.contadores){
                cp.update(this);
            }
        }

        public void setNovaFrase(string frase){
            {
                Console.WriteLine("================== Nova Frase para análise ==================");
                this.frase = frase;
                this.notificaContadores();
            }
        }

        public string getFrase(){
            return this.frase;
        }

        public List<ContaPalavras> getContadores() {
            return this.contadores;
        }

    }
}