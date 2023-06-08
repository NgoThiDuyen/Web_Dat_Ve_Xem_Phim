using AutoMapper;
using AutoMapper.Configuration;
using BanVeXemPhimApi.Common;
using BanVeXemPhimApi.Controllers;
using BanVeXemPhimApi.Database;
using BanVeXemPhimApi.Dto;
using BanVeXemPhimApi.Request;
using BanVeXemPhimApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace BanVeXemPhimApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderTicketController : BaseApiController<OrderTicketController>
    {
        private readonly OrderTicketService _orderTicketService;
        public OrderTicketController(DatabaseContext databaseContext, IMapper mapper, ApiOption apiConfig)
        {
            _orderTicketService = new OrderTicketService(apiConfig, databaseContext, mapper);
        }

        /// <summary>
        /// Get schedule is playing list
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("BookTicket")]
        public MessageData BookTicket(BookTicketRequest bookTicketRequest)
        {
            try
            {
                var res = _orderTicketService.BookTicket(UserId ,bookTicketRequest);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }

        /// <summary>
        /// order history
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("OrderHistory")]
        public MessageData OrderHistory()
        {
            try
            {
                var res = _orderTicketService.OrderHistory(UserId);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }
    }
}
