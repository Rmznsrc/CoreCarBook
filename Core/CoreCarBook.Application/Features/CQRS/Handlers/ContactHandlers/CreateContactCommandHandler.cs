﻿using CoreCarBook.Application.Features.CQRS.Commands.ContactCommands;
using CoreCarBook.Application.Interfaces;
using CoreCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class CreateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public CreateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateContactCommand command)
        {
            await _repository.CreateAsync(new Contact
            {
                 Email    = command.Email,
                 Message  = command.Message,
                 Name     = command.Name,
                 SendDate = command.SendDate,
                 Subject  = command.Subject  
            });
        }
    }
}
