﻿using Microsoft.EntityFrameworkCore;
using HotelBookingApi.Models;
using System.Collections.Generic;
namespace HotelBookingApi.Data
{
    public class ApiContext : DbContext
        {
            public DbSet<HotelBooking> Bookings { get; set; }
            public ApiContext(DbContextOptions<ApiContext> options) : base(options)
            {

            }


        }
    }

