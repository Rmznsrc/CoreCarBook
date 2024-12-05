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
    public class GetServiceByIdHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceByIdHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
           var value = await _repository.GetByIdAsync(request.Id);
            return new GetServiceByIdQueryResult
            {
                Description = value.Description,
                IconUrl = value.IconUrl,
                ServiceID = value.ServiceID,
                Title = value.Title
            };
        }
    }
}
