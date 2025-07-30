using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFormatApiAdapterDemo.Services
{
    public class JsonPolicyService
    {
        public string GetRawJson()
        {
            return """
            {
                "number": "POL123456",
                "client_name": "Ahmet Yılmaz",
                "expiry_date": "2026-01-15"
            }
            """;
        }
    }
}
