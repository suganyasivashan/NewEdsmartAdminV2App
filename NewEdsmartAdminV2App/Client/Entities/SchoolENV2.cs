using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewEdsmartAdminV2App.Client.Entities
{
    public class SchoolENV2
    {
        [Key]
        public string SchoolId { get; set; }
        public string SchoolName { get; set; }
    }
}
