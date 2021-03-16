using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewEdsmartAdminV2App.Shared.Entities
{
    public class School
    {
            [Key]
            public int ID { get; set; }
            public string Title { get; set; }
        
    }
}

