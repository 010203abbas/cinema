using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace cinema.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public int FilmId { get; set; }
        //[ForeignKey("FilmId")]
        //public Film Film { get; set; }
        public List<Film> Films { get; set; }
    }
}
