using CoreCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CoreCarBook.Application.Features.Mediator.Results.FooterAdressResults;
using CoreCarBook.Application.Features.Mediator.Results.StatisticsResults;
using CoreCarBook.Application.Interfaces;
using CoreCarBook.Application.Interfaces.CarInterfaces;
using CoreCarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarCountQueryHandler : IRequestHandler<GetCarCountQuery, GetCarCountQueryResult>
    {
        private readonly ICarRepository _repository;

        public GetCarCountQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountQueryResult> Handle(GetCarCountQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCount();
            return new GetCarCountQueryResult
            {
               CarCount = value,
            };
        }
    }
}
