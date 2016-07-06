using System.Web;
using System.Web.Mvc;
using UnauthorizedTest.CustormerizedAttribute;

namespace UnauthorizedTest
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new CustomerAuthrozedAttribute());
        }
    }
}
