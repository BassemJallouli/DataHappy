using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataHappy.Models
{
    public class Conference
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        
    }
}
