using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiFormatApiAdapterDemo.Adapters;

namespace MultiFormatApiAdapterDemo.Services
{
    public class XmlPolicyService
    {
        public string GetRawXml()
        {
            return """
            <Policy>
                <Code>POL654321</Code>
                <Name>Elif Demir</Name>
                <ValidUntil>2025-08-30T00:00:00</ValidUntil>
            </Policy>
            """;
        }
    }
}
