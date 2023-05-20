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
    public class CinemaManagementService
    {
        private readonly CinemaRepository _cinemaRepository;
        private readonly IMapper _mapper;
        public CinemaManagementService(ApiOption apiOption, DatabaseContext databaseContext, IMapper mapper)
        {
            _cinemaRepository = new CinemaRepository(apiOption, databaseContext, mapper);
            _mapper = mapper;
        }

        /// <summary>
        /// Get schedule
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public object GetCinemas(int limit, int page)
        {
            try
            {
                var query = this._cinemaRepository.FindAll();
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
        /// Store cinema
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public object Store(CinemaStoreRequest request)
        {
            try
            {
                var newCinema = _mapper.Map<Cinema>(request);
                _cinemaRepository.Create(newCinema);
                _cinemaRepository.SaveChange();
                return newCinema;
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
        public object Update(int cinemaId, CinemaUpdateRequest request)
        {
            try
            {
                var cinemaUpdate = _cinemaRepository.FindOrFail(cinemaId);
                if(cinemaUpdate == null)
                {
                    throw new ValidateError("Cinema id invalid!");
                }
                cinemaUpdate.Name = request.Name;
                cinemaUpdate.Address = request.Address;
                cinemaUpdate.Description = request.Description;
                cinemaUpdate.UpdatedDate = DateTime.Now;

                _cinemaRepository.UpdateByEntity(cinemaUpdate);
                return cinemaUpdate;
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
        public bool Delete(int cinemaId)
        {
            try
            {
                var cinemaDelete = _cinemaRepository.FindOrFail(cinemaId);
                if (cinemaDelete == null)
                {
                    throw new ValidateError("Cinema Id invalid");
                }
                _cinemaRepository.DeleteByEntity(cinemaDelete);
                _cinemaRepository.SaveChange();

                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
