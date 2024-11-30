using CoreCarBook.Application.Features.CQRS.Queries.AboutQueries;
using CoreCarBook.Application.Features.CQRS.Results.AboutResults;
using CoreCarBook.Application.Interfaces;
using CoreCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutByIdQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetAboutByIdQueryResult
            {
                AboutID = values.AboutID,
                Description = values.Description,
                ImageUrl = values.ImageUrl,
                Title = values.Title
            };
        }
    }
}
