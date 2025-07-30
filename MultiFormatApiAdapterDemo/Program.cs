using MultiFormatApiAdapterDemo.Adapters;
using MultiFormatApiAdapterDemo.Services;

Console.WriteLine("Multi-Format API Adapter Demo");

//Json data
var jsonPolicyService = new JsonPolicyService();
var jsonRaw = jsonPolicyService.GetRawJson();
var jsonPolicy = PolicyAdapter.ConvertFromJson(jsonRaw);  

//Xml data
var xmlPolicyService = new XmlPolicyService();
var xmlRaw = xmlPolicyService.GetRawXml();
var xmlPolicy = PolicyAdapter.ConvertFromXml(xmlRaw);

//sender service
var sender = new PolicySenderService();
sender.Send(jsonPolicy);
sender.Send(xmlPolicy);

Console.WriteLine("Policies sent successfully!");