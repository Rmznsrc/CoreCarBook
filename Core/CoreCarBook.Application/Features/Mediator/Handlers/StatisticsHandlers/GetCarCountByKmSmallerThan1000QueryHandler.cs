﻿using CoreCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CoreCarBook.Application.Features.Mediator.Results.StatisticsResults;
using CoreCarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarCountByKmSmallerThan1000QueryHandler:IRequestHandler<GetCarCountByKmSmallerThan1000Query, GetCarCountByKmSmallerThan1000QueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarCountByKmSmallerThan1000QueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByKmSmallerThan1000QueryResult> Handle(GetCarCountByKmSmallerThan1000Query request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByKmSmallerThan1000();
            return new GetCarCountByKmSmallerThan1000QueryResult
            {
                CarCountByKmSmallerThan1000 = value
            };
        }
    }
}
