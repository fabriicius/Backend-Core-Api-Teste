using System;
using System.Collections.Generic;
using WebApiTeste.Models;

namespace WebApiTeste.Repositories
{
    public interface IFundoCapitalRepository{
        void Adicionar(FundoCapital fundoCapital);
        void Alterar(FundoCapital fundoCapital);
        //Colecão de listagem 
        IEnumerable<FundoCapital> BuscaFundos();
        FundoCapital BuscarPorId(Guid id);
        void Deletar(FundoCapital fundoCapital);
    }
}