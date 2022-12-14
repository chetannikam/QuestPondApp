using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuestPondApp.Models
{
    public class Customer
    {
        [Required]
        [RegularExpression("^[A-Z]{3,3}[0-9]{4,4}$")]
        public string CustomerCode { get; set; }
        
        [Required]
        [StringLength(6)]
        public string CustomerName { get; set; }
    }
}