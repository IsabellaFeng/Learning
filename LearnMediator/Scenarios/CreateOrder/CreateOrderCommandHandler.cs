using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace LearnMediator.scenarios.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, CreateOrderResponse>
    {
        public async Task<CreateOrderResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var response = new CreateOrderResponse();
            if (request.Id > 0 && request.Name is not null)
            {
                response.DisplayText = "Your order ID is " + request.Name;
            }

            return response;

        }
    }
}
