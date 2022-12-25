using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Ordering.Application.Contracts.Infrastructure;
using Ordering.Application.Contracts.Persistence;
using Ordering.Application.Models;
using Ordering.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Features.Orders.Commands.CheckOutOrder
{
    public class CheckOutOrderCommandHandler : IRequestHandler<CheckOutOrderCommand, int>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly IEmailServices _emailServices;
        private readonly ILogger<CheckOutOrderCommandHandler> _logger;

        public CheckOutOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper, IEmailServices emailServices, ILogger<CheckOutOrderCommandHandler> logger)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _emailServices = emailServices ?? throw new ArgumentNullException(nameof(emailServices));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<int> Handle(CheckOutOrderCommand request, CancellationToken cancellationToken)
        {
            var orderEntity = _mapper.Map<Order>(request);
            var newOrder = await _orderRepository.AddAsync(orderEntity);

            _logger.LogInformation($"Order {newOrder.Id} is successfully created;");

            await SendMail(newOrder);
            return newOrder.Id;
        }

        private async Task SendMail(Order order)
        {
            var email = new Email() { To = "nguyen.huynhthao@banvien.com.vn", Body = $"Order was created.", Subject = "Order was created" };
            try
            {
                await _emailServices.SendEmail(email);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Order {order.Id} failed due to an error with the mail service: {ex.Message}");
            }
        }
    }
}
