using CoreCarBook.Application.Features.Mediator.Queries.AuthorQueries;
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
    public class GetBlogQueryHandler : IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResult>>
    {
        private readonly IRepository<Author> _repository;

        public GetBlogQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAuthorQueryResult
            {
                AuthorID = x.AuthorID,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Name = x.Name
            }).ToList();
        }
    }
}
