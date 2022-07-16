using System;
using MediatR;

namespace MediatrExample.Med.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public async Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new GetProductViewModel() { Id = 3, Name = "Pencil" });
            //Get product from repository
        }
    }
}

