using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApiTeste.Models;
using WebApiTeste.Repositories;

namespace WebApiTeste.Controllers{

    public class FundoCapitalController:Controller 
    {
        //varial que não sera alterada como umma "static"
        private readonly IFundoCapitalRepository  _FundoRepository;
        
        public FundoCapitalController(IFundoCapitalRepository repository)
        {
            _FundoRepository = repository;
        }
         //Permite retornar status HTTP
         [HttpGet("/v1/fundoscapital")]
         public IActionResult listarFundos()
         {
            return Ok (
                _FundoRepository.BuscaFundos()
            );
         }
          
          [HttpPost("/v1/fundoscapital")]
          public IActionResult adicionarFundos([FromBody]FundoCapital fundoCapital){
              _FundoRepository.Adicionar(fundoCapital);
              return Ok();
          }

          [HttpPut("/v1/fundoscapital/{id}")]
          public IActionResult atualizarFundos(Guid id, [FromBody]FundoCapital fundoCapital){
              var fundoBuscaId = _FundoRepository.BuscarPorId(id);
              if(fundoBuscaId == null)
              {
                  return NotFound();
              }

              fundoBuscaId.nome = fundoCapital.nome;
              fundoBuscaId.valorAtual = fundoCapital.valorAtual;
              fundoBuscaId.valorNecessario = fundoCapital.valorNecessario;
              fundoBuscaId.data = fundoCapital.data;
              _FundoRepository.Alterar(fundoBuscaId);

              return Ok("Atualizar seus Funtos Fundos");
          }

          [HttpGet("/v1/fundoscapital/{id}")]
          public IActionResult obterFundos(Guid id){

              var fundoCapitalAntigo  = _FundoRepository.BuscarPorId(id);

              if(fundoCapitalAntigo == null){
                  return NotFound();
              }

              return Ok( fundoCapitalAntigo );
          }

           [HttpDelete("/v1/fundoscapital/{id}")]
          public IActionResult apagarFundo(Guid id){
              
              var fundoCapitalDeletar = _FundoRepository.BuscarPorId(id);
              if(fundoCapitalDeletar == null){
                  return NotFound();
              }

              _FundoRepository.Deletar(fundoCapitalDeletar);
              return Ok();
              
          }

    
    } 
}