using Cadastro.Pesquisa.Services.Contratos.Pesquisa;
using Cadastro.Pesquisa.Services.TaskService.Contratos.DomainServices.Pesquisa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Backend_Cadastro_Pesquisa.Controllers.Pesquisa
{
    public class PesquisaController : Controller
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
