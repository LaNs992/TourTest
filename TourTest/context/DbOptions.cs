using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTest.context
{
    public class DbOptions
    {
        //public static DbContextOptions<TourContext> Options()
        //{
        //    var builder = new ConfigurationBuilder();
        //    builder.SetBasePath(Directory.GetCurrentDirectory());
        //    builder.AddJsonFile("appsettings.json");
        //    var config = builder.Build();
        //    string connectionString = config.GetConnectionString("DefaultConnection");
        //    var optionsBuilder = new DbContextOptionsBuilder<TourContext>();
        //    return optionsBuilder
        //        .UseSqlServer(connectionString)
        //        .Options;
        //}
    }
}
