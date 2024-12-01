﻿using CoreCarBook.Application.Features.CQRS.Commands.CarCommands;
using CoreCarBook.Application.Interfaces;
using CoreCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                 Fuel = command.Fuel,
                 Km = command.Km,
                 Luggage = command.Luggage,
                 Model = command.Model,
                 Seat = command.Seat,
                 Transmission = command.Transmission,
                 CoverImageUrl = command.CoverImageUrl,
                 BigImageUrl = command.BigImageUrl,
                 BrandID = command.BrandID
            });
        }
    }
}