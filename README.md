# CSE325 Team Project 

# BookMe – A Car Rental Booking Platform

## 📌 Overview
BookMe is a .NET Blazor web application that allows businesses to rent out vehicles on an hourly or daily basis.  
It features a vehicle checkout system including CRUD management, role-based access control, and responsive design for both desktop and mobile users.


## 👥 Team Members
- Mitchel Drennan
- Charles Burton
- Kerri Morris
- Roguin Espinal
- David Valentine

## Project Links
- **Repository:** [CSE325-team](https://github.com/kkmorrisfam/CSE325-team)
- **Deployed Site:** _TBD_
- **Project Board:** [https://github.com/users/kkmorrisfam/projects/4](https://github.com/users/kkmorrisfam/projects/4)
- **Demo Video:** _TBD_

---

## Features
- **Authentication & Authorization**: ASP.NET Identity with Admin & Customer roles
- **Vehicle Management**: Add, edit, delete, and search for available vehicles
- **Booking Workflow**: Create, view, edit, and cancel bookings
- **Admin Dashboard**: Manage cars, users, and bookings
- **Responsive Design**: Optimized for desktop & mobile

---

## Technology Stack
- **Frontend**: Blazor Server
- **Backend**: ASP.NET Core
- **Database**: SQLite (local)
- **Authentication**: ASP.NET Identity
- **Deployment**: Github
- **Version Control**: GitHub

---

## Project Structure
/Components
/Pages
/Admin
/Bookings
/Data
/Models
/wwwroot


## Installation & Setup

### Seeding data:

### Enviornment configurations

### Testing:
dotnet test

dotnet restore

Apply migrations: dotnet ef database update
Run application: dotnet watch run

## Database Schema
•	Users – Stores user profiles and roles
•	Vehicles – Vehicle listings with attributes like Make, Model, Year
•	Bookings – Reservation records with start/end dates
•	Payments – Payment transactions linked to bookings
•	Promotions – Discount rules and codes- 

## Known Issues

## Project History

## Accessibility & Performance
•	Lighthouse scores:
