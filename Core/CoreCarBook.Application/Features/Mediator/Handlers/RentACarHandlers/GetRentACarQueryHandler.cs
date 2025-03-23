using CoreCarBook.Application.Features.Mediator.Queries.RentACarQueries;
using CoreCarBook.Application.Features.Mediator.Queries.ServiceQueries;
using CoreCarBook.Application.Features.Mediator.Results.RentACarResults;
using CoreCarBook.Application.Features.Mediator.Results.ServiceResults;
using CoreCarBook.Application.Interfaces;
using CoreCarBook.Application.Interfaces.RentACarInterfaces;
using CoreCarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCarBook.Application.Features.Mediator.Handlers.RentACarHandlers
{
    public class GetRentACarQueryHandler : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
    {
        private readonly IRentACarRepository _repository;

        public GetRentACarQueryHandler(IRentACarRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByFilterAsync(x=>x.LocationID == request.LocationID && x.Available == true);
           
            var results = values.Select(y => new GetRentACarQueryResult
            {
                 CarId = y.CarID
            }).ToList();
            return results;
        }
    }
}
