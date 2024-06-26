﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace LearnMediator.scenarios.CreateOrder
{
    public class CreateOrderCommand : IRequest<CreateOrderResponse>
    {
        public int Id { get; init; }
        public string? Name { get; init; }
    }
}
