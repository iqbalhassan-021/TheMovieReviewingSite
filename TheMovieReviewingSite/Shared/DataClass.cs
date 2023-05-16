using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace TheMovieReviewingSite.Shared
{
    internal class DataClass:DbContext
    {
        public DataClass(DbContextOptions<DataClass> options) : base(options)
        {

        }
        public DbSet<ModelClass> MovieDatas { get; set; }
    }
}
