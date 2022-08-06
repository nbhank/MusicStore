using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMusicStore.Models
{
    [ModelMetadataType(typeof(AlbumMetadata))]
    public partial class Album
    {
    }
    public class AlbumMetadata
    {
        public int AlbumId { get; set; }

        [Display (Name ="Genre")]
        public int GenreId { get; set; }

        [Display(Name ="Artist")]
        public int ArtistId { get; set; }

        [Required]
        public string Title { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public double Price { get; set; }

        [DataType(DataType.EmailAddress)]
        public string AlbumArtUrl { get; set; }
    }
}
