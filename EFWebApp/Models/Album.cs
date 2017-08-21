using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFWebApp.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }
    }

    public class MusicContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
    }
}