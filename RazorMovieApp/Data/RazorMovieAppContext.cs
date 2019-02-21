using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorMovieApp.Models
{
    public class RazorMovieAppContext : DbContext
    {
        public RazorMovieAppContext (DbContextOptions<RazorMovieAppContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
    }
}
