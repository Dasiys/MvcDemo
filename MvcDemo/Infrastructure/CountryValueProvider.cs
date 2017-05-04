using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Infrastructure
{
    public class CountryValueProvider : System.Web.Mvc.IValueProvider
    {
        public bool ContainsPrefix(string prefix) => prefix.ToLower().IndexOf("country") > -1;

        System.Web.Mvc.ValueProviderResult System.Web.Mvc.IValueProvider.GetValue(string key)
        {
            if (ContainsPrefix(key))
                return new ValueProviderResult("China", "China", CultureInfo.CurrentCulture);
            return null;
        }
    }
}
