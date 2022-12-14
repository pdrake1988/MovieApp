using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entites
{
    public class MovieCast
    {
        public Movie MovieId { get; set; }

        public Cast CastId { get; set; }

        [Required]
        [Column(TypeName = "Varchar(450)")]
        public string Character { get; set; }
    }
}
