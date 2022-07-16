using System;
using MediatR;

namespace MediatrExample.Med.Queries
{
    public class GetProductByIdQuery:IRequest<GetProductViewModel>
    {
        public int Id { get; set; }

    }
}

