using FluentAssertions;
using LearnGenerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.LearnGenerics
{
    public class TestPriceRule : IPriceRule
    {
        public string Name => "Test";

        public decimal Price => 1337m;

        [Fact]
        public void PriceRuleProcessorOutputTest()
        {
            var processor = new PriceRuleProcessor();
            var result = processor.Process<TestPriceRule, TestProcessResult>(new TestPriceRule());

            result.Should().BeOfType<TestProcessResult>();

        }
    }

}
