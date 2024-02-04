using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTest.context
{
    public class SampleContext : IDesignTimeDbContextFactory<TourContext>
    {
        public TourContext CreateDbContext(string[] args) => new TourContext(DbOptions.Options());
    }
}


