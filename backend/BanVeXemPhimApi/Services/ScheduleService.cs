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
        private readonly IMapper _mapper;
        public ScheduleService(ApiOption apiOption, DatabaseContext databaseContext, IMapper mapper)
        {
            _scheduleRepository = new ScheduleRepository(apiOption, databaseContext, mapper);
            _mapper = mapper;
        }

        /// <summary>
        /// Get schedule list
        /// </summary>
        /// <returns></returns>
        public object GetScheduleIsPlayingList()
        {
            try
            {
                var dateNow = DateTime.Now;
                var dateStart = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day);
                var dateFinish = dateStart.AddDays(1);
                return _scheduleRepository.FindAll().Where(row => row.PlaySchedule >= dateStart && row.PlaySchedule <= dateFinish).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get schedule list
        /// </summary>
        /// <returns></returns>
        public object GetScheduleComingSoonList()
        {
            try
            {
                var dateNow = DateTime.Now;
                var dateStart = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day).AddDays(1);
                var dateFinish = dateStart.AddDays(6);
                return _scheduleRepository.FindAll().Where(row => row.PlaySchedule >= dateStart && row.PlaySchedule <= dateFinish).ToList();
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
                var scheduleList = _scheduleRepository.FindAll().Where(row => row.MovieId == movieId && row.PlaySchedule > DateTime.Now).ToList();
                var scheduleDtoList = scheduleList.Select(row => _mapper.Map<ScheduleDto>(row)).ToList();
                foreach(var scheduleDto in scheduleDtoList)
                {
                    scheduleDto.PlayScheduleString = SystemConfig.DayInWeekList[(int)scheduleDto.PlaySchedule.DayOfWeek] + "-" + scheduleDto.PlaySchedule.ToString("dd-MM-yyyy");
                    scheduleDto.TimePlayString =scheduleDto.PlaySchedule.ToString("HH:mm");
                    scheduleDto.IsCanBook = false;
                    if(scheduleDto.PlaySchedule > DateTime.Now.AddHours(0.5))
                    {
                        scheduleDto.IsCanBook = true;
                    }
                }

                return scheduleDtoList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
