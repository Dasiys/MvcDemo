using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Model;
using IModelBinder = System.Web.Mvc.IModelBinder;
using ModelBindingContext = System.Web.Mvc.ModelBindingContext;

namespace Infrastructure
{
    public class AddressBinder:IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Address modelAddress = (Address) bindingContext.Model ?? new Address();
            modelAddress.City = GetValue(bindingContext, "City");
            modelAddress.Country = GetValue(bindingContext, "Country");
            return modelAddress;
        }

        private string GetValue(ModelBindingContext context, string name)
        {
            name = (context.ModelName == "" ? "" : context.ModelName + ".") + name;
            ValueProviderResult result = context.ValueProvider.GetValue(name);
            if (result == null || result.AttemptedValue == "")
            {
                return "<Not Specified>";
            }
            return result.AttemptedValue;
        }
    }
}
