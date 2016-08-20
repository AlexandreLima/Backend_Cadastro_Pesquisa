using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cadastro.Pesquisa.Repositorio.Configuracao;
using Cadastro.Pesquisa.Business;

namespace Backend_Cadastro_Pesquisa.Tests.Configuration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testando_Nhibernate()
        {
            var session = NhibernateHelper.SessionFactory.OpenSession();
            //session.Save(new Pesquisa { Nome = "Teste" });

            var pesquisa = session.QueryOver<Pesquisa>().Where(x => x.Nome == "Teste").SingleOrDefault();
            Assert.IsNotNull(pesquisa);
        }
    }
}
