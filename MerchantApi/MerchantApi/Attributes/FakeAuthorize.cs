using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MerchantApi.Attributes;

public class FakeAuthorizeAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var isLoggedIn = context.HttpContext.Request.Headers.ContainsKey("X-Fake-Auth") &&
                         context.HttpContext.Request.Headers["X-Fake-Auth"] == "admin";

        if (!isLoggedIn)
        {
            context.Result = new UnauthorizedObjectResult("Unauthorized. Please login.");
        }
    }
}