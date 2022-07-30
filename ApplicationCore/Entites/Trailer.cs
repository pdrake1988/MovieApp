using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entites
{
    public class Trailer
    {
        public int Id { get; set; }
        public Movie MovieId { get; set; }

        [Column(TypeName = "Varchar(2084)")]
        public string TrailerUrl { get; set; }

        [Column(TypeName = "Varchar(2084)")]
        public string Name { get; set; }
    }
}
