using CoreCarBook.Application.Features.Mediator.Commands.BlogCommands;
using CoreCarBook.Application.Interfaces;
using CoreCarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHandler:IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public UpdateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.BlogID);
            value.CreatedDate = request.CreatedDate;
            value.CategoryID = request.CategoryID;
            value.CoverImageUrl = request.CoverImageUrl;
            value.Title = request.Title;
            value.AuthorID = request.AuthorID;
            await _repository.UpdateAsync(value);
        }
    }
}
