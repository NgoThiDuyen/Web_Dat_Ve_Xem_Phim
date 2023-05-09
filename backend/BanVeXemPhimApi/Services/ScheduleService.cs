using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using BanVeXemPhimApi.Common;
using BanVeXemPhimApi.Common.Enum;
using BanVeXemPhimApi.Database;
using BanVeXemPhimApi.Dto;
using BanVeXemPhimApi.Models;
using BanVeXemPhimApi.Repositories;
using BanVeXemPhimApi.Request;
using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Collections.Generic;

namespace BanVeXemPhimApi.Services
{
    public class ScheduleService
    {
        private readonly ScheduleRepository _scheduleRepository;
        public ScheduleService(ApiOption apiOption, DatabaseContext databaseContext, IMapper mapper)
        {
            _scheduleRepository = new ScheduleRepository(apiOption, databaseContext, mapper);
        }

        /// <summary>
        /// Get schedule list
        /// </summary>
        /// <returns></returns>
        public object GetScheduleList()
        {
            try
            {
                var dateNow = DateTime.Now.AddDays(7);
                return _scheduleRepository.FindAll().Where(row => row.PlaySchedule < dateNow).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get schedule list by movieId
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns></returns>
        public object GetScheduleListByMovieId(int movieId)
        {
            try
            {
                return _scheduleRepository.FindAll().Where(row => row.MovieId == movieId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
