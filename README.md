# MVCFormValidation (.NET 8 + ASP.NET Core MVC)

**MVCFormValidation** is a simple ASP.NET Core MVC application built using Visual Studio 2022 and .NET 8.0.  
It allows users to submit their **Name** and **Age** through a web form, validates the input on the server side, and displays the result on a separate page.

---

## 📌 Why This Project?

This project is a great starting point for anyone learning:

- ASP.NET Core MVC basics
- Razor views and Tag Helpers
- Model binding and form validation
- Form handling using the POST-Redirect-GET pattern

---

## 🚀 Features

- Form input for `Name` and `Age`
- Server-side validation using `[Required]`, `[Range]`, etc.
- Clean result display with Razor view
- Link to return to the input form
- Uses Tag Helpers like `asp-for`, `asp-action`, and `asp-validation-for`

---

## 🧰 Tech Stack

- **Language:** C#
- **Framework:** .NET 8.0 (ASP.NET Core MVC)
- **IDE:** Visual Studio 2022
- **View Engine:** Razor
- **Validation:** Data Annotations

---

## 📂 Project Structure

<pre>
  MVCFormValidation/
├── Controllers/
│ └── PersonController.cs
├── Models/
│ └── Person.cs
├── Views/
│ └── Person/
│ ├── Input.cshtml
│ └── Result.cshtml
├── wwwroot/
│ └── (static files, if needed)
├── Program.cs
└── MVCFormValidation.csproj
</pre>


---

## ✅ Requirements

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 (v17.8 or later)
- Git (optional, for source control)

---

## 💻 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/Prashant-Kumar-03/MVCFormValidation.git
   ```

2. Open the solution:
   - Open `MVCFormValidation.sln` in **Visual Studio 2022**

3. Build and run:
   - Press **F5** or click the **Start** button

4. Access the app in your browser:
   - Go to:
     ```
     https://localhost:{port-number}/Person/Input
     ```

---

## 📝 Notes

- Built using **ASP.NET Core MVC (.NET 8.0)** and **Visual Studio 2022**
- Uses Razor Views and **Tag Helpers** for cleaner syntax and form handling
- Input validation is handled using Data Annotations and displayed using `asp-validation-for`
- `_ValidationScriptsPartial` loads unobtrusive client-side validation scripts automatically

---

## 📸 Screenshots
> - The input form
<img width="678" height="927" alt="image" src="https://github.com/user-attachments/assets/120aea28-98c9-4d94-8bba-89104741ab43" />


> - Result page
<img width="712" height="438" alt="image" src="https://github.com/user-attachments/assets/179af4d7-98ff-4219-b234-a37b24f3c21d" />

other than that if you want to see
> - Validation in action
<img width="778" height="455" alt="image" src="https://github.com/user-attachments/assets/3266d431-c5ed-46f0-a506-1b706e18b565" />


---

## 📃 License

This project is open-source and intended for educational and learning purposes.

---

## 🙌 Author

Created with ❤️ using ASP.NET Core MVC and .NET 8.0  
GitHub: [Prashant-Kumar-03](https://github.com/Prashant-Kumar-03)
