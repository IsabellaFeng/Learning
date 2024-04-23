using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnGenerics
{
    public class PriceRuleProcessor
    {
        public string Process<TPriceRule>(TPriceRule priceRule)
         where TPriceRule : IPriceRule
        {
            return $"{priceRule.Name} = {priceRule.Price}";
        }

        public TResult Process<TPriceRule, TResult>(TPriceRule priceRule)
           where TPriceRule : IPriceRule
           where TResult : class, new()
        {
            return new TResult();
        }
    }
}
