# BulkyBook 📖🛒

> A book e-commerce web application built with ASP.NET Core MVC — currently in development as part of a hands-on online learning journey.

---

## 🧭 Overview

BulkyBook is an online bookstore where customers can browse, add to cart, and purchase books with a real payment flow. The platform supports multiple user roles — customers, employees, and administrators — each with their own dedicated workspace and capabilities.

This project is being developed incrementally, applying industry-standard patterns like Repository Pattern, Dependency Injection, and N-tier architecture in a real-world scenario.

---

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| Web Framework | ASP.NET Core MVC (.NET 10) |
| ORM | Entity Framework Core |
| Database | SQL Server / Azure SQL Database |
| Authentication | ASP.NET Core Identity |
| Payment | Stripe API |
| Email | Mailjet |
| Frontend | Razor Pages, Bootstrap, JavaScript |
| Hosting | Azure App Service |

---

## 🗂️ Solution Structure

```
BulkyBook/
├── BulkyBookWeb/          # Entry point — controllers, views, areas
│   ├── Areas/
│   │   ├── Admin/         # Product, order, user & category management
│   │   ├── Customer/      # Storefront, cart, checkout
│   │   └── Identity/      # Login, register, account pages
│   └── wwwroot/           # CSS, JS, images
├── BulkyBook.Business/    # Services & business logic
├── BulkyBook.DataAccess/  # Repositories, DbContext, migrations
├── BulkyBook.Models/      # Domain models & ViewModels
└── BulkyBook.Utility/     # Constants, helpers, email sender
```

---

## ✨ Features (Planned & In Progress)

### 👤 Customer
- Browse and search product catalog
- Shopping cart management
- Stripe-powered secure checkout
-  Order history & tracking

### 🛠️ Admin
- Product & category CRUD
- User management
- Order processing dashboard
- Sales analytics
---

## ⚙️ Local Setup

### Prerequisites
- .NET 10
- SQL Server or LocalDB
- Visual Studio 2022+

### 1. Configure the database

Edit `BulkyBookWeb/appsettings.json`:

```json
"ConnectionStrings": {
  "SQLConnection": "Server=localdb\\DB_SERVER_NAME;Database=BulkyBook;Trusted_Connection=True;"
}
```

### 2. Configure Stripe & Mailjet

```json
"Stripe": {
  "SecretKey": "sk_test_...",
  "PublishableKey": "pk_test_..."
},
"Mailjet": {
  "ApiKey": "...",
  "SecretKey": "...",
  "SenderEmail": "you@example.com"
}
```

---

## 🚀 Deployment

This app is configured for deployment on **Azure App Service** with **Azure SQL Database**:

1. Provision an Azure SQL Database and update the connection string in Azure Portal
2. Create an Azure App Service (Windows, .NET 10)
3. Publish directly from Visual Studio or via GitHub Actions

---

## 📌 Status

> 🔨 **Work in progress** — features are being added progressively as development continues.

## Demo image from existing code
<img width="1912" height="975" alt="image" src="https://github.com/user-attachments/assets/3d83b125-8086-4e70-9756-a639ba3395b9" />
