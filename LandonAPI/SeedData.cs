using LandonAPI.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LandonAPI
{
    public static  class SeedData
    {

        public static async Task InitializeAsync(IServiceProvider provider)
        {
            await AddTestData(provider.GetRequiredService<HotelApiDbContext>());
        }

        public static async Task AddTestData(HotelApiDbContext context)
        {
            if(context.Rooms.Any())
            {
                return;
            }
            context.Rooms.Add(new RoomEntity()
            {
                Id = new Guid(),
                Name = "Oxford Suite",
                Rate = 1101

            });

            context.Rooms.Add(new RoomEntity()
            {
                Id = new Guid(),
                Name = "Driscoll suite",
                Rate = 2345
            });

            await context.SaveChangesAsync();
        }
    }
}
