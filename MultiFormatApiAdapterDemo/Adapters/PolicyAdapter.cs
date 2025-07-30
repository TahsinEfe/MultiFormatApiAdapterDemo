using MultiFormatApiAdapterDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MultiFormatApiAdapterDemo.Adapters
{
    public static class PolicyAdapter
    {
        public static InsurancePolicy ConvertFromJson(string json)
        {
            var model = JsonSerializer.Deserialize<JsonPolicy>(json)!;

            if (string.IsNullOrWhiteSpace(model.expiry_date))
                throw new FormatException("expiry_date is missing or empty in JSON");

            return new InsurancePolicy
            {
                PolicyNumber = model.number,
                CustomerName = model.client_name,
                ValidUntil = DateTime.Parse(model.expiry_date)
            };
        }


        public static InsurancePolicy ConvertFromXml(string xml)
        {
            var serializer = new XmlSerializer(typeof(XmlPolicy));
            using var reader = new StringReader(xml);
            var model = (XmlPolicy)serializer.Deserialize(reader)!;

            return new InsurancePolicy
            {
                PolicyNumber = model.Code,
                CustomerName = model.Name,
                ValidUntil = model.ValidUntil
            };
        }
    }
}