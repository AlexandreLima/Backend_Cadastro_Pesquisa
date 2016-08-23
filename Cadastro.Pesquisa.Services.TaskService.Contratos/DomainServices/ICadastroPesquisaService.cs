using Cadastro.Pesquisa.Services.Contratos.Pesquisa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Pesquisa.Services.TaskService.Contratos.DomainServices.Pesquisa
{
    public interface ICadastroPesquisaService
    {
        Services.Contratos.Pesquisa.PesquisaDto IncluiPesquisa(PesquisaDto dto);
        Services.Contratos.Pesquisa.PesquisaDto ObtemPesquisa(PesquisaDto dto);
        Services.Contratos.Pesquisa.PesquisaDto ObtemPorId(int id);
        IList<Services.Contratos.Pesquisa.PesquisaDto> ObtemTodasPesquisas();
    }
}
