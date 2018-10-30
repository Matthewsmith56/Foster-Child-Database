using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FosterSite.Models
{
    public class TableValidation
    {
        public int ID { get; set; }

        [Range(0, 100)]
        public int Licensed_Beds { get; set; }

        [Required]
        public int Occupied_Beds { get; set; }

        [Required]
        public int Available_Beds { get; set; }

        [Range(0, 18)]
        public int Min_Age { get; set; }

        [Range(0, 18)]
        public int Max_Age { get; set; }

        [Phone, EmailAddress]
        public string POC { get; set; }
    }
}