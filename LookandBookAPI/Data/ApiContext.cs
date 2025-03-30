using LookandBookAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace LookandBookAPI.Data
{
    public class ApiContext : DbContext
    {


        public DbSet<HotelBooking> HotelBooking { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
            
        }
    }
}
