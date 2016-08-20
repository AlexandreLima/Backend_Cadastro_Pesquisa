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

        [HttpGet]
        public PesquisaDto ObterPorId(int id)
        {
            return service.ObtemPorId(id);
        }
    }
}
