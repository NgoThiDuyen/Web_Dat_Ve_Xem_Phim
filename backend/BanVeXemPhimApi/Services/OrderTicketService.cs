using AutoMapper;
using BanVeXemPhimApi.Common;
using BanVeXemPhimApi.Common.Enum;
using BanVeXemPhimApi.Database;
using BanVeXemPhimApi.Dto;
using BanVeXemPhimApi.Models;
using BanVeXemPhimApi.Repositories;
using BanVeXemPhimApi.Request;
using System;
using System.Linq;

namespace BanVeXemPhimApi.Services
{
    public class OrderTicketService
    {
        private readonly ScheduleRepository _scheduleRepository;
        private readonly MovieRepository _movieRepository;
        private readonly CinemaRepository _cinemaRepository;
        private readonly OrderTicketRepository _orderTicketRepository;
        private readonly IMapper _mapper;
        public OrderTicketService(ApiOption apiOption, DatabaseContext databaseContext, IMapper mapper)
        {
            _scheduleRepository = new ScheduleRepository(apiOption, databaseContext, mapper);
            _movieRepository = new MovieRepository(apiOption, databaseContext, mapper);
            _cinemaRepository = new CinemaRepository(apiOption, databaseContext, mapper);
            _orderTicketRepository = new OrderTicketRepository(apiOption, databaseContext, mapper);
            _mapper = mapper;
        }

        /// <summary>
        /// book ticket
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="bookTicketRequest"></param>
        /// <returns></returns>
        public object BookTicket(int userId, BookTicketRequest bookTicketRequest)
        {
            try
            {
                var orderTicket = _mapper.Map<OrderTicket>(bookTicketRequest);
                orderTicket.UserId = userId;
                var schedule = _scheduleRepository.FindOrFail(orderTicket.ScheduleId);
                if (schedule == null || schedule.PlaySchedule < DateTime.Now.AddHours(1))
                {
                    throw new Exception("Lịch chiếu đã quá hạn đặt, vui lòng chọn phim khác!");
                }

                var seatList = orderTicket.SeatList.Split(",");
                foreach (var seat in seatList)
                {
                    if (schedule.SeatHaveBeenBookedList.Contains(seat))
                    {
                        throw new Exception("Ghế đã có người khác đặt, vui lòng chọn ghế khác!");
                    }
                }
                orderTicket.TotalPrice = seatList.Length * 80000;

                if (!string.IsNullOrEmpty(schedule.SeatHaveBeenBookedList))
                {
                    schedule.SeatHaveBeenBookedList += ", ";
                }

                for (int i = 0; i < seatList.Length - 1; i++)
                {
                    schedule.SeatHaveBeenBookedList += seatList[i] + ", ";
                }
                if(seatList.Length > 0)
                {
                    schedule.SeatHaveBeenBookedList += seatList[seatList.Length - 1];
                }
                schedule.UpdatedDate = DateTime.Now;

                // update seatlist of schedule
                _scheduleRepository.UpdateByEntity(schedule);
                _scheduleRepository.SaveChange();

                _orderTicketRepository.Create(orderTicket);
                _orderTicketRepository.SaveChange();

                return orderTicket;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get orderhistory by user id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public object OrderHistory(int userId)
        {
            try
            {
                var orderTicketList = _orderTicketRepository.FindByCondition(row => row.UserId == userId).OrderByDescending(row=> row.Id).ToList();
                var orderHistoryDtoList = orderTicketList.Select(row => _mapper.Map<OrderHistoryDto>(row)).ToList();

                foreach(var orderHistoryDto in orderHistoryDtoList)
                {
                    orderHistoryDto.OrderDateString = orderHistoryDto.CreatedDate.ToString("HH:mm dd/MM/yyyy");
                    var schedule = _scheduleRepository.FindOrFail(orderHistoryDto.ScheduleId);
                    if (schedule != null)
                    {
                        orderHistoryDto.PlayScheduleString = schedule.PlaySchedule.ToString("HH:MM") + " " + SystemConfig.DayInWeekList[(int)schedule.PlaySchedule.DayOfWeek] + "-" + schedule.PlaySchedule.ToString("dd/MM/yyyy");
                        var movie = _movieRepository.FindOrFail(schedule.MovieId);
                        if (movie != null)
                        {
                            orderHistoryDto.MovieName = movie.Name;
                            orderHistoryDto.Image = movie.Image;
                        }
                    }
                }
                return orderHistoryDtoList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
