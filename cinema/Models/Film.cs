using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cinema.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }



        public int LanguagId { get; set; }
        [ForeignKey("LanguagId")]
        public Language Language { get; set; }



        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }
        
       
        public  int DirectorId{ get; set; }
        [ForeignKey("DirectorId")]
        public Director director { get; set; }

    }
}
