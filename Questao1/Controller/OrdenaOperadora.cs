using Questao1.Model;
using Questao1.View;

namespace Questao1.Controller{
    public class OrdenaOperadora : IOrdenacao
    {
        public List<Telefone> ordenar(List<Telefone> telefones)
        { 
            int inicio = 0;
            int fim = telefones.Count() - 1;

            return this.quickSort(telefones, inicio, fim); 
        }

        private List<Telefone> quickSort(List<Telefone> telefones, int inicio, int tamanho)
        {
            int inicial, final, numero;
            Telefone tel;

            
            inicial = inicio;
            final = tamanho;
            numero = telefones[(inicio + tamanho) / 2].getOperadora();
            
            while(inicial <= final) {
                while(telefones[inicial].getOperadora() < numero && inicial < tamanho) {
                    inicial++;
                }
                while(telefones[final].getOperadora() > numero && final > inicio) {
                    final--;
                }
                if(inicial <= final) {
                    tel = telefones[inicial];
                    telefones[inicial] = telefones[final];
                    telefones[final] = tel;
                    inicial++;
                    final--;
                }
            }
            
            if(final > inicio) {
                quickSort(telefones, inicio, final);
            }
            if(inicial < tamanho) {
                quickSort(telefones, inicial, tamanho);
            }

            return telefones; 
        }

    }
}