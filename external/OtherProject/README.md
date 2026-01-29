# ❌ No-as-a-Service

<p align="center">
  <img src="https://raw.githubusercontent.com/hotheadhacker/no-as-a-service/main/assets/imgs/naas-with-no-logo-bunny.png" width="800" alt="No-as-a-Service Banner" width="70%"/>
</p>


Ever needed a graceful way to say “no”?  
This tiny API returns random, generic, creative, and sometimes hilarious rejection reasons — perfectly suited for any scenario: personal, professional, student life, dev life, or just because.

Built for humans, excuses, and humor.

## 🚀 API Usage

**Base URL**
```
Wherever you publish it
```

**Method:** `GET`  

### 🔄 Example Request
```http
GET /
```

### ✅ Example Response
```json
{
  "reason": "This feels like something Future Me would yell at Present Me for agreeing to."
}
```

Use it in apps, bots, landing pages, Slack integrations, rejection letters, or wherever you need a polite (or witty) no.

---

## 🛠️ Self-Hosting

Want to run it yourself? It’s lightweight and simple (hahaha just kidding, its IIS).

### 1. Create a new VS project using Git Clone

### 2. Publish to an IIS WebApplication folder

---

## 📁 Project Structure

```
no-as-service/
├── NaaS.sln            # VS Solution File
├── NaaS
    ├── reasons.json    # 1000+ universal rejection reasons
    ├── NaaS.csproj     # VS Project Fle
    ├── Program.cs      # API class
└── README.md
```

---

## 👤 Author

Refactored with malicious joy by [sapph42](https://github.com/sapph42)

## 👤 Original Author

Created with creative stubbornness by [hotheadhacker](https://github.com/hotheadhacker)

---

## 📄 License

MIT — do whatever, just don’t say yes when you should say no.
