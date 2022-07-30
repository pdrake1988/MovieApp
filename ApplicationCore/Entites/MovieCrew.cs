using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entites
{
    public class MovieCrew
    {
        public Movie MovieId { get; set; }
        
        public Crew CrewId { get; set; }

        [Required]
        [Column(TypeName = "Varchar(128)")]
        public string Department { get; set; }

        [Required]
        [Column(TypeName = "Varchar(128)")]
        public string Job { get; set; }
    }
}
