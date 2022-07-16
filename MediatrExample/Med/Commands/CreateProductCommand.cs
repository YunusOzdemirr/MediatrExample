using System;
using MediatR;

namespace MediatrExample.Med.Commands
{
    public class CreateProductCommand:IRequest<int>
    {
        public string Name { get; set; }
        public int Quantity{ get; set; }
        public decimal Value { get; set; }

        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
        {
            public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                return await Task.FromResult(new Random().Next(0, 10000));
               //repository ile veritabanına gönderilir ya da event bus
            }
        }
    }
}

