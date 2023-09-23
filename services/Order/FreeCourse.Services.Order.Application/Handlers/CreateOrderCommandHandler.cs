using FreeCourse.Services.Order.Application.Commands;
using FreeCourse.Services.Order.Application.Dtos;
using FreeCourse.Services.Order.Domain.OrderAggregate;
using FreeCourse.Services.Order.Infastructure;
using FreeCourse.Shared.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCourse.Services.Order.Application.Handlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Response<CreatedOrderDto>>
    {

        private readonly OrderDbContext _context;

        public CreateOrderCommandHandler(OrderDbContext context)
        {
            _context = context;
        }
        public async Task<Response<CreatedOrderDto>> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var newAdress = new Address(request.AddressDto.Provience, request.AddressDto.District,
                request.AddressDto.Street, request.AddressDto.ZipCode, request.AddressDto.Line);

            var newOrder = new Domain.OrderAggregate.Order(newAdress, request.BuyerId);

            request.OrderItems.ForEach(x =>
            {
                newOrder.AddOrderItem(x.ProductId, x.ProductName, x.Price, x.PictureUrl);
            });

            _context.Orders.Add(newOrder);
            await  _context.SaveChangesAsync();


            return Response<CreatedOrderDto>.Success(new CreatedOrderDto { Id = newOrder.Id }, 200);
        }
    }
}
