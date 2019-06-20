using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PharmaFactory.Models
{
    public class Deposit
    {
        [Key]
        public int IdDeposit { get; set; }
        public string Location { get; set; }
    }
}