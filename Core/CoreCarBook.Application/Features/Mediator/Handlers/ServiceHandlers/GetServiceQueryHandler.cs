using CoreCarBook.Application.Features.Mediator.Queries.ServiceQueries;
using CoreCarBook.Application.Features.Mediator.Results.ServiceResults;
using CoreCarBook.Application.Interfaces;
using CoreCarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCarBook.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetServiceQueryResult
            {
                 Description = x.Description,
                 IconUrl = x.IconUrl,
                 Title = x.Title,
                 ServiceID = x.ServiceID
            }).ToList();
        }
    }
}
