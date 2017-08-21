﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFWebApp.Models
{
    public class AlbumEditViewModel
    {
        public int AlubumId { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(1024)]
        public string AlbumArtUrl { get; set; }
    }
}