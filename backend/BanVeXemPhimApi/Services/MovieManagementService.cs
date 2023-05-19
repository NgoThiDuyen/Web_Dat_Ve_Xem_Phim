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
    public class MovieManagementService
    {
        private readonly MovieRepository _movieRepository;
        private readonly IMapper _mapper;
        public MovieManagementService(ApiOption apiOption, DatabaseContext databaseContext, IMapper mapper)
        {
            _movieRepository = new MovieRepository(apiOption, databaseContext, mapper);
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public object GetMovies(int limit, int page)
        {
            try
            {
                var query = this._movieRepository.FindAll();
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
                    //Amount = amount,
                    //PageSize = limit,
                    TotalRecords  = total,
                    TotalPages = totalPage,
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
        public object Store(MovieStoreRequest request)
        {
            try
            {
                var newMovie = _mapper.Map<Movie>(request);
                _movieRepository.Create(newMovie);
                _movieRepository.SaveChange();
                return newMovie;
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
        public object Update(int movieId, MovieUpdateRequest request)
        {
            try
            {
                var movieUpdate = _movieRepository.FindOrFail(movieId);
                if(movieUpdate == null)
                {
                    throw new ValidateError("Id invalid");
                }
                movieUpdate.Name = request.Name;
                movieUpdate.Author = request.Author;
                movieUpdate.Cast = request.Cast;
                movieUpdate.MovieType = request.MovieType;
                movieUpdate.Time = request.Time;
                movieUpdate.ReleaseDate = request.ReleaseDate;
                movieUpdate.Description = request.Description;
                movieUpdate.NumberBooking = request.NumberBooking;
                movieUpdate.NumberView = request.NumberView;
                movieUpdate.UpdatedDate = DateTime.Now;

                _movieRepository.UpdateByEntity(movieUpdate);
                _movieRepository.SaveChange();
                return movieUpdate;
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
        public bool Delete(int movieId)
        {
            try
            {
                var movieDelete = _movieRepository.FindOrFail(movieId);
                if (movieDelete == null)
                {
                    throw new ValidateError("Id invalid");
                }
                _movieRepository.DeleteByEntity(movieDelete);
                _movieRepository.SaveChange();

                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
