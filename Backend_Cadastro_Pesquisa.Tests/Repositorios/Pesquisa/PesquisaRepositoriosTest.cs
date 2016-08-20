using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cadastro.Pesquisa.Repositorio.Contratos.Pesquisa;
using Cadastro.Pesquisa.Business;

namespace Backend_Cadastro_Pesquisa.Tests.Repositorios.Pesquisa
{
    [TestClass]
    public class PesquisaRepositoriosTest
    {
        [TestMethod]
        public void Quando_Obter_Por_Id()
        {
            var moq = new Moq.Mock<IPesquisaRepositorio<Cadastro.Pesquisa.Business.Pesquisa>>();
            Cadastro.Pesquisa.Business.Pesquisa pesquisa = null;

            moq.Setup(x => x.ObterPorId(123))
                .Returns(new Cadastro.Pesquisa.Business.Pesquisa { Nome = "PesquisaTeste", IdPesquisa = 123 });


            pesquisa = moq.Object.ObterPorId(123);

            Assert.IsNotNull(pesquisa);
            Assert.AreEqual(123, pesquisa.IdPesquisa);
            Assert.AreEqual("PesquisaTeste", pesquisa.Nome);
        }

        [TestMethod]
        public void Criando_Pesquisa()
        {
            var moq = new Moq.Mock<IPesquisaRepositorio<Cadastro.Pesquisa.Business.Pesquisa>>();
            
            Cadastro.Pesquisa.Business.Pesquisa pesquisa = new Cadastro.Pesquisa.Business.Pesquisa
                {
                    IdPesquisa = 234,
                    Nome = "PesquisaTeste"
                };

            moq.Setup(x => x.Incluir(pesquisa));
            moq.Setup(x => x.ObterPorId(pesquisa.IdPesquisa)).Returns(pesquisa);

            Assert.IsNotNull(moq.Object.ObterPorId(pesquisa.IdPesquisa));

        }
    }
}
