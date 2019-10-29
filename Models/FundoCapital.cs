using System;

namespace WebApiTeste.Models
{

    public class FundoCapital
    {
        public FundoCapital()
        {
             Id = Guid.NewGuid();
        } 
        public  Guid Id { get; }
        public String nome {get;set;}
        public int valorNecessario{get; set;}
        public int valorAtual{get; set;}
        //"?" pode receber um valor nulo
        public DateTime? data{get; set;}

    }

}