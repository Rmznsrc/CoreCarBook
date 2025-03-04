﻿using CoreCarBook.Application.Features.Mediator.Queries.AuthorQueries;
using CoreCarBook.Application.Features.Mediator.Results.AuthorResults;
using CoreCarBook.Application.Interfaces;
using CoreCarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCarBook.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class GetBlogByIdQueryHandler:IRequestHandler<GetAuthorByIdQuery,GetAuthorByIdQueryResult>
    {
        private readonly IRepository<Author> _repository;

        public GetBlogByIdQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetAuthorByIdQueryResult
            {
                AuthorID = values.AuthorID,
                Name = values.Name,
                ImageUrl = values.ImageUrl,
                Description = values.Description,
            };
        }
    }
}
