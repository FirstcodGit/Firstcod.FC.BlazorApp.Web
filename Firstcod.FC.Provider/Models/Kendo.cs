using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Firstcod.FC.Provider.Models
{
    public class Kendo
    {
        [Key]
        public long Id { get; set; }
        public string StringVal { get; set; }
        public string IntegerVal { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
