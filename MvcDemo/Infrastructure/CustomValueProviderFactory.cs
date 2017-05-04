
using System.Web.Mvc;

namespace Infrastructure
{
    public class CustomValueProviderFactory : System.Web.Mvc.ValueProviderFactory
    {
        public override IValueProvider GetValueProvider(ControllerContext controllerContext)
        {
            return new CountryValueProvider();
        }
    }
}
