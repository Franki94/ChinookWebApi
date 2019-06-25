using Chinook.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Chinook.WebApi.Repository.MySql
{
    public class ChinookMySqlContext : DbContext

    {
        public ChinookMySqlContext(DbContextOptions<ChinookMySqlContext> options)
          : base(options)
        {
        }
        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<Artist> Artist { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceLine> InvoiceLine { get; set; }
        public virtual DbSet<MediaType> MediaType { get; set; }
        public virtual DbSet<Playlist> Playlist { get; set; }
        public virtual DbSet<PlaylistTrack> PlaylistTrack { get; set; }
        public virtual DbSet<Track> Track { get; set; }
    }
}
