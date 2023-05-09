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
    public class ScheduleController : BaseApiController<MovieController>
    {
        private readonly ScheduleService _scheduleService;
        public ScheduleController(DatabaseContext databaseContext, IMapper mapper, ApiOption apiConfig)
        {
            _scheduleService = new ScheduleService(apiConfig, databaseContext, mapper);
        }

        /// <summary>
        /// Get schedule list
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        [Route("GetScheduleList")]
        public MessageData GetScheduleList()
        {
            try
            {
                var res = _scheduleService.GetScheduleList();
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }

        /// <summary>
        /// Get schedule list by movieId
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        [Route("GetScheduleListByMovieId")]
        public MessageData GetScheduleListByMovieId(int movieId)
        {
            try
            {
                var res = _scheduleService.GetScheduleListByMovieId(movieId);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }
    }
}
