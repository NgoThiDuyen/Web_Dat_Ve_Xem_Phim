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
using System.Xml.Linq;

namespace BanVeXemPhimApi.Services
{
    public class ScheduleManagementService
    {
        private readonly ScheduleRepository _scheduleRepository;
        private readonly IMapper _mapper;
        public ScheduleManagementService(ApiOption apiOption, DatabaseContext databaseContext, IMapper mapper)
        {
            _scheduleRepository = new ScheduleRepository(apiOption, databaseContext, mapper);
            _mapper = mapper;
        }

        /// <summary>
        /// Get schedule
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public object GetSchedules(int limit, int page)
        {
            try
            {
                var query = this._scheduleRepository.FindAll();
                query.Skip((page - 1) * limit).Take(limit);
                var total = query.Count();
                int tmpByInt = total / limit;
                double tmpByDouble = (double)total / (double)limit;
                int totalPage = 1;
                if (tmpByDouble > (double)tmpByInt)
                {
                    totalPage = tmpByInt + 1;
                }
                else
                {
                    totalPage = tmpByInt;
                }
                query = query.Skip((page - 1) * limit).Take(limit);
                var amount = query.Count();
                return new
                {
                    data = query.ToList(),
                    Amount = amount,
                    PageSize = limit,
                    Total = total,
                    TotalPage = totalPage,
                };
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Store movie
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public object Store(ScheduleStoreRequest request)
        {
            try
            {
                var newSchedule = _mapper.Map<Schedule>(request);
                _scheduleRepository.Create(newSchedule);
                _scheduleRepository.SaveChange();
                return newSchedule;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Update movie
        /// </summary>
        /// <param name="movieId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public object Update(int scheduleId, ScheduleUpdateRequest request)
        {
            try
            {
                var scheduleUpdate = _scheduleRepository.FindOrFail(scheduleId);
                if(scheduleUpdate == null)
                {
                    throw new ValidateError("Schedule id invalid!");
                }
                scheduleUpdate.MovieId = request.MovieId;
                scheduleUpdate.CinemaId = request.CinemaId;
                scheduleUpdate.PlaySchedule= request.PlaySchedule;
                scheduleUpdate.UpdatedDate = DateTime.Now;

                _scheduleRepository.UpdateByEntity(scheduleUpdate);
                return scheduleUpdate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete movie
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns></returns>
        public bool Delete(int scheduleId)
        {
            try
            {
                var scheduleDelete = _scheduleRepository.FindOrFail(scheduleId);
                if (scheduleDelete == null)
                {
                    throw new ValidateError("Id invalid");
                }
                _scheduleRepository.DeleteByEntity(scheduleDelete);
                _scheduleRepository.SaveChange();

                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
