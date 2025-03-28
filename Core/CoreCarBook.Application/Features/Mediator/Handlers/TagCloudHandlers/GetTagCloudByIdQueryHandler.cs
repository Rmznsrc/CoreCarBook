﻿using CoreCarBook.Application.Features.Mediator.Queries.TagCloudQueries;
using CoreCarBook.Application.Features.Mediator.Results.TagCloudResults;
using CoreCarBook.Application.Interfaces;
using CoreCarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCarBook.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudByIdQueryHandler:IRequestHandler<GetTagCloudByIdQuery,GetTagCloudByIdQueryResult>
    {
        private readonly IRepository<TagCloud> _repository;

        public GetTagCloudByIdQueryHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task<GetTagCloudByIdQueryResult> Handle(GetTagCloudByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetTagCloudByIdQueryResult
            {
                TagCloudID = values.TagCloudID,
                BlogID = values.BlogID,
                Title = values.Title,
            };
        }
    }
}
