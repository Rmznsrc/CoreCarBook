using CoreCarBook.Application.Features.Mediator.Queries.SocialMediaQueries;
using CoreCarBook.Application.Features.Mediator.Results.SocialMediaResults;
using CoreCarBook.Application.Interfaces;
using CoreCarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class GetTestimonialQueryHandler : IRequestHandler<GetSocialMediaQuery, List<GetSocialMediaQueryResult>>
    {
        private readonly IRepository<SocialMedia> _repository;

        public GetTestimonialQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetSocialMediaQueryResult
            {
                Icon = x.Icon,
                Name = x.Name,
                SocialMediaID = x.SocialMediaID,
                Url = x.Url
            }).ToList();
        }
    }
}
