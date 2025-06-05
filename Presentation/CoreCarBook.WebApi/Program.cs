using CoreCarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CoreCarBook.Application.Features.CQRS.Handlers.BannerHandlers;
using CoreCarBook.Application.Features.CQRS.Handlers.BrandHandlers;
using CoreCarBook.Application.Features.CQRS.Handlers.CarHandlers;
using CoreCarBook.Application.Features.CQRS.Handlers.CategoryHandlers;
using CoreCarBook.Application.Features.CQRS.Handlers.ContactHandlers;
using CoreCarBook.Application.Features.RepositoryPattern;
using CoreCarBook.Application.Interfaces;
using CoreCarBook.Application.Interfaces.BlogInterfaces;
using CoreCarBook.Application.Interfaces.CarInterfaces;
using CoreCarBook.Application.Interfaces.CarPricingInterfaces;
using CoreCarBook.Application.Interfaces.RentACarInterfaces;
using CoreCarBook.Application.Interfaces.StatisticsInterfaces;
using CoreCarBook.Application.Interfaces.TagCloudInterfaces;
using CoreCarBook.Application.Services;
using CoreCarBook.Persistance.Context;
using CoreCarBook.Persistance.Repositories;
using CoreCarBook.Persistance.Repositories.BlogRepositories;
using CoreCarBook.Persistance.Repositories.CarPricingRepositories;
using CoreCarBook.Persistance.Repositories.CarRepositories;
using CoreCarBook.Persistance.Repositories.CommentRepositories;
using CoreCarBook.Persistance.Repositories.RentACarRepositories;
using CoreCarBook.Persistance.Repositories.StatisticsRepositories;
using CoreCarBook.Persistance.Repositories.TagCloudRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<CarBookContext>();
builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
builder.Services.AddScoped(typeof(ICarRepository),typeof(CarRepository));
builder.Services.AddScoped(typeof(IStatisticsRepository), typeof(StatisticsRepository));
builder.Services.AddScoped(typeof(IRentACarRepository), typeof(RentACarRepository));
builder.Services.AddScoped(typeof(IBlogRepository),typeof(BlogRepository));
builder.Services.AddScoped(typeof(ICarPricingRepository), typeof(CarPricingRepository));
builder.Services.AddScoped(typeof(ITagCloudRepository), typeof(TagCloudRepository));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(CommentRepository<>));


builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();
builder.Services.AddScoped<RemoveAboutCommandHandler>();

builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<GetBannerByIdQueryHandler>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<UpdateBannerCommandHandler>();
builder.Services.AddScoped<RemoveBannerCommandHandler>();

builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();

builder.Services.AddScoped<GetCarQueryHandler>();
builder.Services.AddScoped<GetCarByIdQueryHandler>();
builder.Services.AddScoped<CreateCarCommandHandler>();
builder.Services.AddScoped<UpdateCarCommandHandler>();
builder.Services.AddScoped<RemoveCarCommandHandler>();
builder.Services.AddScoped<GetCarWithBrandQueryHandler>();
builder.Services.AddScoped<GetLast5CarsWithBrandQueryHandler>();
 
builder.Services.AddScoped<GetCategoryQueryHandler>();
builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
builder.Services.AddScoped<CreateCategoryCommandHandler>();
builder.Services.AddScoped<UpdateCategoryCommandHandler>();
builder.Services.AddScoped<RemoveCategoryCommandHandler>();

builder.Services.AddScoped<GetContactQueryHandler>();
builder.Services.AddScoped<GetContactByIdQueryHandler>();
builder.Services.AddScoped<CreateContactCommandHandler>();
builder.Services.AddScoped<UpdateContactCommandHandler>();
builder.Services.AddScoped<RemoveContactCommandHandler>();

builder.Services.AddApplicationService(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
