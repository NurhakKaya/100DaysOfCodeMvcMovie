using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _100DaysOfCodeMvcMovie.Models;

namespace _100DaysOfCodeMvcMovie.Data
{
    public class _100DaysOfCodeMvcMovieContext : DbContext
    {
        public _100DaysOfCodeMvcMovieContext (DbContextOptions<_100DaysOfCodeMvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<_100DaysOfCodeMvcMovie.Models.Movie> Movie { get; set; }
    }
}
