using Microsoft.AspNetCore.Mvc.Filters;
namespace MobileManager.Model
{
    public class IgnoreValidationAttributes : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            context.ModelState.Clear();
            base.OnActionExecuted(context);
        }
    }
}