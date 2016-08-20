using Cadastro.Pesquisa.Services.Contratos.Pesquisa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Pesquisa.Services.TaskService.Contratos.ApplicationServices.Pesquisa
{
    public interface ICadastroPesquisaService
    {
        bool IncluiPesquisa(PesquisaDto dto);
        bool obtemPesquisa(PesquisaDto dto);
    }
}
