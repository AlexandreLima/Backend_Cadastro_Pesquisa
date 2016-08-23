using Cadastro.Pesquisa.Services.Contratos.Pesquisa;
using Cadastro.Pesquisa.Services.TaskService.Contratos.DomainServices.Pesquisa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cadastro.Pesquisa.WepApi.Controllers.Pesquisa
{
    public class PesquisaController : ApiController
    {
        private ICadastroPesquisaService service;
        public PesquisaController(ICadastroPesquisaService service)
        {
            this.service = service;
        }

        public PesquisaDto Get(int id)
        {
            return service.ObtemPorId(id);
        }

        [HttpGet]
        public IList<PesquisaDto> Get()
        {
            return service.ObtemTodasPesquisas();
        }

        public PesquisaDto Post([FromBody] PesquisaDto pesquisa) 
        {
            return service.IncluiPesquisa(pesquisa);
        }
    }
}
