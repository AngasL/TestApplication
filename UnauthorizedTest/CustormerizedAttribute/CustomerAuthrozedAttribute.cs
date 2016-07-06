using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UnauthorizedTest.CustormerizedAttribute
{
    public class CustomerAuthrozedAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            base.HandleUnauthorizedRequest(filterContext);
            //filterContext.Result = new RedirectToRouteResult(
            //                        new RouteValueDictionary
            //                        {
            //                           { "action", "Index" },
            //                           { "controller", "Error" }
            //                        });
        }
    }
}