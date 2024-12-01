using CoreCarBook.Application.Features.CQRS.Queries.ContactQueries;
using CoreCarBook.Application.Features.CQRS.Results.ContactResults;
using CoreCarBook.Application.Interfaces;
using CoreCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactByIdQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetContactByIdQueryResult
            {
                 ContactID = values.ContactID,
                 Subject   = values.Subject,
                 SendDate  = values.SendDate,
                 Name      = values.Name,
                 Message   = values.Message,
                 Email     = values.Email 
            };
        }
    }
}
