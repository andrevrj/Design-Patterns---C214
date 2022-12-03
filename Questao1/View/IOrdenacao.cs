using Questao1.Model;
using System;

namespace Questao1.View{

    public interface IOrdenacao
    {
        List<Telefone> ordenar(List<Telefone> telefones);
    }
}