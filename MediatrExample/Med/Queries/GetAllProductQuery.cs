using System;
using MediatR;

namespace MediatrExample.Med.Queries
{
    public class GetAllProductQuery:IRequest<List<GetProductViewModel>>
    {


        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductViewModel>>
        {
            public Task<List<GetProductViewModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var model = new GetProductViewModel()
                {
                    Id = 5,
                    Name = "Monitör"
                };
                var model2 = new GetProductViewModel()
                {
                    Id = 4,
                    Name = "Book"
                };
                return Task.FromResult(new List<GetProductViewModel>() { model,model2 });
            }
        }
    }
}

