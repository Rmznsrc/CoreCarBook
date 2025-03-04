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
    public class CreateTestimonialCommandHandler : IRequestHandler<CreateSocialMediaCommand>

    {
        private readonly IRepository<SocialMedia> _repository;

        public CreateTestimonialCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new SocialMedia
            {
                Url = request.Url,
                Icon = request.Icon,
                Name = request.Name
            });
        }
    }
}
