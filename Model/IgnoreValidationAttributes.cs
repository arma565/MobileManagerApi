using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;

public class IgnoreValidationAttributes : ActionFilterAttribute
{
    public override void OnActionExecuted(ActionExecutedContext context)
    {
        context.ModelState.Clear();
        base.OnActionExecuted(context);
    }
}