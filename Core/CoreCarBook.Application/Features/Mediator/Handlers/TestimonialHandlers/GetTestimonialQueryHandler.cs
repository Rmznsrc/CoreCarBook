using CoreCarBook.Application.Features.Mediator.Queries.TestimonialQueries;
using CoreCarBook.Application.Features.Mediator.Results.TestimonialResults;
using CoreCarBook.Application.Interfaces;
using CoreCarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCarBook.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetTestimonialQueryResult
            {
                Name = x.Name,
                Title = x.Title,
                ImageUrl = x.ImageUrl,
                Comment = x.Comment,
                TestimonialID = x.TestimonialID   
            }).ToList();
        }
    }
}
