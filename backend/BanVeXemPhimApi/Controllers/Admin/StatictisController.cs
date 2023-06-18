using AutoMapper;
using AutoMapper.Configuration;
using BanVeXemPhimApi.Common;
using BanVeXemPhimApi.Controllers;
using BanVeXemPhimApi.Database;
using BanVeXemPhimApi.Dto;
using BanVeXemPhimApi.Models;
using BanVeXemPhimApi.Request;
using BanVeXemPhimApi.Services;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace BanVeXemPhimApi.Controllers.Admin
{
    [ApiController]
    [Route("api/admin/[controller]")]
    [Authorize(Roles = "Manager")]
    public class StatictisController : BaseApiController<StatictisController>
    {
        private readonly StatictisService _statictisService;
        private readonly IWebHostEnvironment _webHost;
        public StatictisController(DatabaseContext databaseContext, IMapper mapper, ApiOption apiConfig, IWebHostEnvironment webHost)
        {
            _statictisService = new StatictisService(apiConfig, databaseContext, mapper, webHost);
            _webHost = webHost;
        }

        /// <summary>
        /// get user list
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        [HttpGet("StatictisOrderTicket")]
        public IActionResult StatictisOrderTicket(DateTime dateFrom, DateTime dateTo, int limit, int page)
        {
            try
            {
                var res = _statictisService.StatictisOrderTicket(dateFrom, dateTo, limit, page);
                return Ok(new MessageData { Data = res });
            }
            catch (Exception ex)
            {
                return NG(ex);
            }
        }

        [AllowAnonymous]
        [HttpGet("ExportFile")]
        public async Task<IActionResult> ExportFile(string filename)
        {
            try
            {
                // save file
                //var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
                //filename = DateTime.Now.Ticks.ToString() + extension;

                //var filepath = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\Files");

                //if (!Directory.Exists(filepath))
                //{
                //    Directory.CreateDirectory(filepath);
                //}

                //var exactpath = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\Files", filename);
                //using (var stream = new FileStream(exactpath, FileMode.Create))
                //{
                //    await file.CopyToAsync(stream);
                //}


                var filepath = Path.Combine(Directory.GetCurrentDirectory(), "FileExcelExport", filename);

                var provider = new FileExtensionContentTypeProvider();
                if (!provider.TryGetContentType(filepath, out var contenttype))
                {
                    contenttype = "application/octet-stream";
                }

                var bytes = await System.IO.File.ReadAllBytesAsync(filepath);
                return File(bytes, contenttype, Path.GetFileName(filepath));
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
