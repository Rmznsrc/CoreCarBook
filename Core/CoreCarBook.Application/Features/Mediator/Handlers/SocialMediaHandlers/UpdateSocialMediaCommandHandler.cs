﻿using CoreCarBook.Application.Features.Mediator.Commands.SocialMediaCommands;
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
    public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateSocialMediaCommand>
    {
        private readonly IRepository<SocialMedia> _repository;

        public UpdateTestimonialCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.SocialMediaID); 
            value.Url = request.Url;
            value.Icon = request.Icon;
            value.Name = request.Name; 
            await _repository.UpdateAsync(value);
        }
    }
}
