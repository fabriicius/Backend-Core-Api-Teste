using System;
using System.Collections.Generic;
using System.Linq;
using WebApiTeste.Models;

namespace WebApiTeste.Repositories
{

    public class FundoCapitalRepository : IFundoCapitalRepository
    {

        private readonly List<FundoCapital> _storage;

        public FundoCapitalRepository(){
            _storage = new List<FundoCapital>();
        }
        public void Adicionar(FundoCapital fundoCapital)
        {
            _storage.Add(fundoCapital);
        }

        public void Alterar(FundoCapital fundoCapital)
        {
            var index = _storage.FindIndex(0 , 1 , x=> x.Id ==  fundoCapital.Id);
            _storage[index] = fundoCapital;
        }

        public IEnumerable<FundoCapital> BuscaFundos()
        {
           return _storage;
        }

        public FundoCapital BuscarPorId(Guid id)
        {
            return _storage.FirstOrDefault(x => x.Id == id);
        }

        public void Deletar(FundoCapital fundoCapital)
        {
           _storage.Remove(fundoCapital);
        }
    }

}