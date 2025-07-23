# raulfch.com — Personal Portfolio Site

This is the source code for my personal portfolio website, [raulfch.com](https://raulfch.com).  
Built with modern tools and best practices, it's designed to showcase my projects, work experience, certifications, and more.
This is the opposite of an overengineered website. I wanted to keep things simple

---

## 🚀 Tech Stack

- **Frontend & Backend:** ASP.NET Core 8 with Razor Pages, Tailwind
- **Database:** CockroachDB (via Entity Framework Core)
- **Authentication:** Google OAuth (admin access only)
- **Dev Tools:** JetBrains Rider IDE
- **Chatbot Automation:** [n8n]
- **Secrets Management:** `.NET` [User Secrets](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets)
- **Deployment:** Azure Web App

---

## ✨ Features

- 🔐 Secure admin page with Google login
- 📝 Editable About Me, Experience, and Certifications
- 📁 Portfolio section for showcasing projects
- 💬 Integrated chatbot powered by `n8n`
- 🌐 Live and deployed on [raulfch.com](https://raulfch.com)
- 🛠 Built with clean Razor Pages architecture and EF Core for database interaction

---

## 📁 Project Structure

├── Pages/ # Razor Pages (.cshtml and .cshtml.cs)
│ ├── Index.cshtml # Home page
│ ├── Partial/ # Partial views for index page
│ ├── Admin/ # Admin panel (secured with Google auth)
│ └── Shared/ # Layout and shared UI components
├── wwwroot/ # Static files (CSS, JS, icons)
├── Data/ # EF Core DB context
├── Models/ # Domain models
├── appsettings.json # General config
└── Program.cs / Startup.cs # App entry point

---

## 🌐 Deployment (Azure)

This site is deployed via Azure Web App with GitHub Actions .

Environment variables and secrets are set via Azure App Configuration.

The site runs in production mode and connects to the CockroachDB free cluster.


---

## ⚙️ Development Setup

1. **Clone the repo:**

   ```bash
   git clone https://github.com/your-username/portfolio-site.git
   cd portfolio-site

2. **Set up user secrets:**

    ```bash
    dotnet user-secrets init
    dotnet user-secrets set "Authentication:Google:ClientId" "your-client-id"
    dotnet user-secrets set "Authentication:Google:ClientSecret" "your-client-secret"
    dotnet user-secrets set "ConnectionStrings:DefaultConnection" "your-cockroach-connection-string"

3. **Apply migrations**

   ```bash
   dotnet ef database update

4.  **Run the site locally:**

    ```bash
    dotnet run
