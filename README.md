# 🧩 Multi-Format API Adapter Demo (C#)

This project demonstrates a clean, real-world example of an **API Adapter** that consumes and normalizes data from two different external APIs — one using JSON, the other using XML.

> ☑️ Built with .NET 6 – Console Application  
> ☑️ Demonstrates Adapter Pattern in practical usage  
> ☑️ Ideal for integration with legacy and modern systems

---

## 🚀 Features

- 🟡 Adapts JSON policy data from a RESTful service
- 🟠 Adapts XML policy data from a legacy SOAP-like provider
- 🟢 Maps both into a common internal model: `InsurancePolicy`
- 🔁 Ready to be extended for real API communication (HTTP Client layer can be added)

---

## 🧭 Architecture Diagram

```
                     ┌─────────────┐
                     │  JSON API   │
                     └────┬────────┘
                          │
                          ▼
                   ┌──────────────┐
                   │  API Adapter │
                   └────┬─────────┘
         ┌──────────────┼──────────────┐
         ▼                             ▼
┌────────────────┐           ┌────────────────────┐
│ Deserialize    │           │   Deserialize      │
│   from JSON    │           │     from XML       │
└────────────────┘           └────────────────────┘
         ▼                             ▼
       ┌────────────────────────────────────┐
       │       Internal Domain Model        │
       └────────────────────────────────────┘
                          │
                          ▼
        Send to Microservice / Save / Analyze


```
