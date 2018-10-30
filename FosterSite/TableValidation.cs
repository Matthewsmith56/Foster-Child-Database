using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace FosterSite
{
    public class TableValidation
    {
            public int ID { get; set; }

            [Range (0, 100)]
            public int Licensed_Beds { get; set; }

            [Required]
            public int Occupied_Beds { get; set; }

            [Required]
            public string Available_Beds { get; set; }

            [Range (0, 18)]
            public string Min_Age { get; set; }

            [Range(0, 18)]
            public string Max_Age { get; set; }
    }
}