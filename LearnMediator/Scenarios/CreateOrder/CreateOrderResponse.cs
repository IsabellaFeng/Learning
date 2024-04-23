using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMediator.scenarios.CreateOrder
{
    public class CreateOrderResponse
    {
        public string? DisplayText { get; set; }
        public bool Success => !string.IsNullOrWhiteSpace(DisplayText);
    }
}
