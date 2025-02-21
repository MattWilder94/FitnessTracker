# Fitness Tracker App

## Overview
The **Fitness Tracker App** is a web application built with **ASP.NET MVC** that helps users track their workouts, exercises, and nutrition. 
The app allows users to log workout routines, track calorie intake, and set fitness goals based on whether they want to lose, maintain, or gain weight.

## Features
- **Workout Tracking:**
  - Log exercises, including weight lifted, reps, and notes.
  - Select workout type (Strength Training, Cardio, Mixed).
  - Track muscle groups targeted during each workout.
  
- **Calorie & Nutrition Tracking:**
  - Manually log calorie intake.
  - Track macronutrients (Protein, Carbs, Fats).
  - Set and calculate calorie goals based on fitness objectives.

## Technologies Used
- **Backend:** ASP.NET Core MVC, Entity Framework Core
- **Frontend:** Razor Views, Bootstrap (optional)
- **Database:** SQLite or SQL Server (Configurable)
- **Version Control:** Git, GitHub


## Installation & Setup
### Prerequisites
- .NET 7+ installed
- Visual Studio / VS Code
- SQL Server or SQLite

### Steps
1. **Clone the repository**:
   ```sh
   git clone https://github.com/your-username/FitnessTracker.git
   cd FitnessTracker
dotnet restore
dotnet ef database update
dotnet run

## Usage
- Naviagte to the Workouts page to log exercises
- Use the Nutrition page to trak calorie intake
- View progress over time based on logged data
