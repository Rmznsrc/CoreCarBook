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
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateContactCommand command)
        {
            var values = await _repository.GetByIdAsync(command.ContactID);
            values.Email = command.Email;
            values.SendDate = command.SendDate;
            values.Subject = command.Subject;
            values.Message = command.Message;
            values.Name = command.Name;
            await _repository.UpdateAsync(values);
        }
    }
}
