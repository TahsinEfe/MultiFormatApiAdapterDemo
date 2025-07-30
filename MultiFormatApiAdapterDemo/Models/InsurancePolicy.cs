using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFormatApiAdapterDemo.Models
{
    public class InsurancePolicy
    {
        public string PolicyNumber { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public DateTime ValidUntil { get; set; }

    }
}
