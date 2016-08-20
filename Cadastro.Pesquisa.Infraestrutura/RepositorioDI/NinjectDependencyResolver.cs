using Cadastro.Pesquisa.Repositorio.Configuracao.Repositorio.Pesquisa;
using Cadastro.Pesquisa.Repositorio.Contratos.Pesquisa;
using Cadastro.Pesquisa.Service.Impl.DomainServices.Pesquisa;
using Cadastro.Pesquisa.Services.TaskService.Contratos.DomainServices.Pesquisa;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Pesquisa.Infraestrutura.RepositorioDI
{
    public class NinjectDependencyResolverInfraestrutura
    {
        public void Load(IKernel kernel)
        {
            // Repositorio
            kernel.Bind<IPesquisaRepositorio<Business.Pesquisa>>().To<PesquisaRepositorio>();

            // Services
            kernel.Bind<ICadastroPesquisaService>().To<PesquisaService>();
        }
    }
}

