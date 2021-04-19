using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KPDNHEP.Console.Domain.Models
{
    public class Applications
    {
        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationIcon { get; set; }
        public string ApplicationUrl { get; set; }
        public string ApplicationDescription { get; set; }
    }
}
