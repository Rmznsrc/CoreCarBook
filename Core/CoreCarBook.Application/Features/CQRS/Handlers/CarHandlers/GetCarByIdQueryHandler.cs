using CoreCarBook.Application.Features.CQRS.Queries.CarQueries;
using CoreCarBook.Application.Features.CQRS.Results.CarResults;
using CoreCarBook.Application.Interfaces;
using CoreCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCarByIdQueryResult
            {
                 BrandID = values.BrandID,
                 CarID = values.CarID,
                 BigImageUrl = values.BigImageUrl,
                 CoverImageUrl = values.CoverImageUrl,
                 Transmission = values.Transmission,
                 Seat = values.Seat,
                 Model = values.Model,
                 Luggage = values.Luggage,
                 Fuel = values.Fuel,
                 Km = values.Km
            };
        }
    }
}
