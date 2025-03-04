﻿using CoreCarBook.Application.Features.Mediator.Queries.LocationQueries;
using CoreCarBook.Application.Features.Mediator.Results.LocationResults;
using CoreCarBook.Application.Interfaces;
using CoreCarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCarBook.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class GetAuthorByIdQueryHandler:IRequestHandler<GetLocationByIdQuery,GetLocationByIdQueryResult>
    {
        private readonly IRepository<Location> _repository;

        public GetAuthorByIdQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetLocationByIdQueryResult
            {
                LocationID = values.LocationID,
                Name = values.Name,
            };
        }
    }
}
