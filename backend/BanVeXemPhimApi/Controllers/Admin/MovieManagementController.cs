using AutoMapper;
using AutoMapper.Configuration;
using BanVeXemPhimApi.Common;
using BanVeXemPhimApi.Controllers;
using BanVeXemPhimApi.Database;
using BanVeXemPhimApi.Dto;
using BanVeXemPhimApi.Models;
using BanVeXemPhimApi.Request;
using BanVeXemPhimApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace BanVeXemPhimApi.Controllers.Admin
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Manager")]
    public class MovieManagementController : BaseApiController<MovieManagementController>
    {
        private readonly MovieManagementService _movieManagementService;
        public MovieManagementController(DatabaseContext databaseContext, IMapper mapper, ApiOption apiConfig)
        {
            _movieManagementService = new MovieManagementService(apiConfig, databaseContext, mapper);
        }

        /// <summary>
        /// Get list movies
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        [HttpGet("Get")]
        public IActionResult Get(int limit, int page)
        {
            try
            {
                var res = _movieManagementService.GetMovies(limit, page);
                return Ok(new MessageData { Data = res });
            }
            catch (Exception ex)
            {
                return NG(ex);
            }
        }

        /// <summary>
        /// Store movie
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("Store")]
        public IActionResult Store(MovieStoreRequest request)
        {
            try
            {
                var res = _movieManagementService.Store(request);
                return Ok(new MessageData { Data = res });
            }
            catch (Exception ex)
            {
                return NG(ex);
            }
        }

        /// <summary>
        /// Update movie
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        public IActionResult Update(int id, MovieUpdateRequest request)
        {
            try
            {
                var res = _movieManagementService.Update(id, request);
                return Ok(new MessageData { Data = res });
            }
            catch (Exception ex)
            {
                return NG(ex);
            }
        }

        /// <summary>
        /// Delete movie
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            try
            {
                var res = _movieManagementService.Delete(id);
                return Ok(new MessageData { Data = res });
            }
            catch (Exception ex)
            {
                return NG(ex);
            }
        }
    }
}
