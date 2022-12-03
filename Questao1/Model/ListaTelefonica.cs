using Questao1.View;

namespace Questao1.Model{
    public abstract class ListaTelefonica{
        protected IOrdenacao iOrdenacao{get; set;}
        protected List<Telefone> telefones = new List<Telefone>();

        public List<Telefone> ordenar(){
            return this.iOrdenacao.ordenar(this.telefones);
        }
    }
}