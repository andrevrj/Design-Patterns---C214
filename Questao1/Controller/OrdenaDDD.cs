using Questao1.View;
using Questao1.Model;

namespace Questao1.Controller{
    public class OrdenaDDD : IOrdenacao
    {
        public List<Telefone> ordenar(List<Telefone> telefones)
         {
             // BubbleSort
             int tamanho = telefones.Count();
             Telefone tel;

             for(int i = 0; i < tamanho; i++)
                 for(int j = 0; j < tamanho - 1; j++){
                     if (telefones[j].getDDD() > telefones[j+1].getDDD()){
                         tel = telefones[j];
                         telefones[j] = telefones[j+1];
                         telefones[j+1] = tel;
                     }
                 }
            return telefones;
            
         } 

    }
}
