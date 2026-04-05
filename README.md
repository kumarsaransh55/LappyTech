# 💻 LappyTech Procurement Platform

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white)](#)
[![Azure](https://img.shields.io/badge/Microsoft%20Azure-0089D6?logo=microsoft-azure&logoColor=white)](#)
[![Razorpay](https://img.shields.io/badge/Razorpay-Payment%20Gateway-02042B?logo=razorpay&logoColor=white)](#)
[![GitHub Actions](https://img.shields.io/badge/CI%2FCD-GitHub%20Actions-2088FF?logo=github-actions&logoColor=white)](#)

**Lappy** is an enterprise-grade B2B and B2C e-commerce platform designed for tech hardware procurement. Built with ASP.NET Core 8 and Azure, it features a highly scalable architecture, dynamic tiered pricing, and bank-grade security protocols.

🔗 **[View Live Website](https://lappytech.azurewebsites.net/)** | 🎥 **[Watch Demo Video](https://your-demo-video-link.com)**

---

<div align="center">
  <!-- Just drag and drop your best screenshot over the text below in GitHub -->
  <img width="1920" height="1079" alt="LappyTech Homepage" src="https://github.com/user-attachments/assets/f072b006-67d3-4e0f-8474-1f06c7ed208f" />
</div>

---


## ✨ Key Features

- **Multi-Tenant Workflows:** Role-Based Access Control (RBAC) supporting distinct user journeys for retail consumers and corporate (B2B) entities.
- **Dynamic Pricing Engine:** Automated tiered-volume pricing (e.g., 10+, 25+, 100+ units) and corporate Net-30 credit logic.
- **Secure Checkout & Payments:** Razorpay integration with strict server-side HMAC-SHA256 signature validation to guarantee 100% financial data integrity.
- **Asynchronous UI:** Seamless shopping cart experience using ajax partial page updates (no reloading).
- **Automated Communication:** Real-time transactional emails and order lifecycle tracking using MailKit and Brevo SMTP.
- **Admin Dashboard:** Asynchronous, high-performance data grids utilizing DataTables, AJAX, and LINQ projections.

## 🛠️ Tech Stack & Architecture

### Backend & Architecture
- **Framework:** C#, ASP.NET Core 8 MVC
- **Data Access:** Entity Framework Core (EF Core), LINQ
- **Design Patterns:** Repository Pattern, Unit of Work Pattern
- **Optimization:** Utilized `.AsNoTracking()` for high-volume read-only catalog queries, reducing server memory allocation by ~50%.

### Frontend
- **UI:** Bootstrap 5 (Responsive flexbox design), CSS3 Animations
- **Interactivity:** JavaScript, HTMX, jQuery, SweetAlert2
- **Data Grids:** DataTables with Server-Side rendering

### Cloud, DevOps & Security
- **Hosting:** Azure App Service
- **Database:** Azure SQL Database
- **CI/CD:** GitHub Actions (Automated build, test, and zero-downtime deployment pipelines)
- **Security:** ASP.NET Core Identity, OAuth 2.0 (Google/Facebook Auth), **Azure Key Vault** (with Managed Identities for zero-trust secret management).

---

## 🚀 Local Setup & Installation

To run this project locally, you will need [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) and SQL Server.

### 1. Clone the repository
```bash
git clone https://github.com/kumarsaransh55/Lappy.git
cd Lappy
```
### 2. Configure User Secrets / AppSettings
You will need to configure your own API keys. In your appsettings.Development.json, ensure you have the following structure:
```JSON
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=LappyDb;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  "Razorpay": {
    "KeyId": "YOUR_RAZORPAY_KEY",
    "KeySecret": "YOUR_RAZORPAY_SECRET"
  },
  "EmailSender": {
    "SmtpServer": "smtp-relay.brevo.com",
    "Port": 587,
    "Username": "YOUR_SMTP_USER",
    "Password": "YOUR_SMTP_PASSWORD"
  }
}
```
(Note: Production secrets are injected securely via Azure Key Vault).
### 3. Apply Database Migrations
Open the Package Manager Console (PMC) or terminal and run:
```bash
dotnet ef database update
```
### 4. Run the Application
```Bash
dotnet run
```

This project was developed to showcase scalable e-commerce architecture and cloud security best practices.
