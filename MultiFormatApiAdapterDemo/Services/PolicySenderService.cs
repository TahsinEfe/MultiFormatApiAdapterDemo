using MultiFormatApiAdapterDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFormatApiAdapterDemo.Services
{
    public class PolicySenderService
    {
        public void Send(InsurancePolicy policy)
        {
            // Simulate sending the policy to an external service
            Console.WriteLine("\n📨 Sending policy to service...");
            Console.WriteLine($"- Policy #: {policy.PolicyNumber}");
            Console.WriteLine($"- Customer: {policy.CustomerName}");
            Console.WriteLine($"- Valid Until: {policy.ValidUntil:yyyy-MM-dd}");
        }
    }
}
