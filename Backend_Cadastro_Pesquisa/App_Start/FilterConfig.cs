using System.Web;
using System.Web.Mvc;

namespace Backend_Cadastro_Pesquisa
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
