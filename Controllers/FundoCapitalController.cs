using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApiTeste.Models.FundoCapital;

namespace WebApiTeste.Controllers{

    public class FundoCapitalController:Controller 
    {
        
    
         //Permite retornar status HTTP
         [HttpGet("/v1/fundoscapital")]
         public IActionResult listarFundos()
         {
            return Ok (
                new List<FundoCapital>{
                    new FundoCapital {
                        nome = "Viajem",
                        valorAtual = 200,
                        valorNecessario = 5000,
                        data = new DateTime(2019, 12 , 1)

                    },
                    new FundoCapital{
                         nome = "Reserva de emergencia",
                        valorAtual = 500,
                        valorNecessario = 10000,
                        
                    }
                }
            );
         }
          
          [HttpPost("/v1/fundoscapital")]
          public IActionResult adicionarFundos([FromBody]FundoCapital fundoCapital){
              return Ok();
          }

          [HttpPut("/v1/fundoscapital/{id}")]
          public IActionResult atualizarFundos(Guid id){
              return Ok("Atualizar seus Funtos Fundos");
          }

          [HttpGet("/v1/fundoscapital/{id}")]
          public IActionResult obterFundos(Guid id){
              return Ok( 
                    new FundoCapital {
                        nome = "Viajem",
                        valorAtual = 200,
                        valorNecessario = 5000,
                        data = new DateTime(2019, 12 , 1)

                    });
          }

           [HttpDelete("/v1/fundoscapital/{id}")]
          public IActionResult apagarFundo(Guid id){
              return Ok();
          }

    
    } 
}