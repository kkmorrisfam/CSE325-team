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
/test

## Installation & Setup
### Prerequisites
.NET 8 SDK installed
Git

NOte: SQLite CLI is optional — only needed if you want to manually inspect the database outside of the application.

#### Start
git clone https://github.com/kkmorrisfam/CSE325-team.git
cd CSE325-team
dotnet restore
dotnet ef database update
dotnet watch run

### Seeding data:

#### Seeding runs **automatically on application startup**. On launch, the app:

1) Applies any pending EF Core migrations  
2) Seeds required data in this order:
   - **Users & Roles** (Identity)  
   - **Vehicles**  
   - **Bookings**  
   - **Payments**

This behavior is configured in `Program.cs`:
```csharp
await db.Database.MigrateAsync();                  // 1) Apply migrations
await SeedUser.InitializeAsync(services);          // 2a) Identity users/roles
await SeedVehicle.InitializeAsync(db);             // 2b) Vehicles
await SeedBooking.InitializeAsync(db);             // 2c) Bookings
await SeedPayment.InitializeAsync(db);             // 2d) Payments

#### Force reseed/reset database
##### Option A: drop & recreate
dotnet ef database drop -f
dotnet ef database update
dotnet watch run   # triggers seeding again

##### Option B: delete the SQLite file (path from your connection string),
# then run the app to recreate+seed.

### Enviornment configurations:



### Testing:
On local enviornemnts you can test database using each table name as an endpoint and if desired a specific /:id

dotnet restore

Apply migrations: dotnet ef database update
Run application: dotnet watch run

## Database Schema
•	Users – Stores user profiles and roles
•	Vehicles – Vehicle listings with attributes like Make, Model, Year
•	Bookings – Reservation records with start/end dates
•	Payments – Payment transactions linked to bookings
•	Promotions – Discount rules and codes- 


## 🗄 Database Schema

### Identity tables (ASP.NET Identity)
**Users**
 - Role (TEXT, required) 
 - Email (TEXT, required, unique)
 - Password (TEXT, required)
 - FirstName (TEXT, required)
 - LastName (TEXT, required)-

### Domain tables

**Vehicle**
- VehicleId (INTEGER, PK, autoincrement)
- Make (TEXT, required)
- Model (TEXT, required)
- Year (INTEGER, nullable)
- Color (TEXT, required)
- VehicleType (TEXT, required)
- Transmission (TEXT, required)
- DailyRate (decimal(10,2), required) *(SQLite numeric)*
- ImageFileName (TEXT, nullable)
- FuelType (TEXT, nullable)
- Seats (INTEGER, nullable)
- LicensePlate (TEXT, max 20, nullable)
- Mileage (INTEGER, nullable)
- Status (TEXT, required)  *(e.g., Active/Maintenance/Inactive)*
- Capacity (INTEGER, required)

**Booking**
- BookingId (INTEGER, PK, autoincrement)
- StartDate (TEXT, required) *(DateTime)*
- EndDate (TEXT, required) *(DateTime)*
- TotalPrice (decimal(10,2), required)
- VehicleId (INTEGER, required) • **FK → Vehicle(VehicleId)**
- UserId (TEXT, required) • **FK → AspNetUsers(Id)**
- **Indexes:** `IX_Booking_VehicleId`, `IX_Booking_UserId`

**Payment**
- PaymentId (INTEGER, PK, autoincrement)
- PaymentAt (TEXT, required) *(DateTime)*
- Amount (decimal(10,2), required)
- PaymentMethod (TEXT, required)
- State (TEXT, required)
- Zip (TEXT, max 10, required)
- UserId (TEXT, required) • **FK → AspNetUsers(Id)**  • **Index:** `IX_Payment_UserId`
- BookingId (INTEGER, nullable) • **FK → Booking(BookingId)**  • **Index:** `IX_Payment_BookingId`
- Status (TEXT, required)

---

### Relationships (quick view)
- **User 1..* Booking** via `Booking.UserId`
- **Vehicle 1..* Booking** via `Booking.VehicleId`
- **User 1..* Payment** via `Payment.UserId`
- **Booking 0..1..* Payment** via `Payment.BookingId` (optional link)
- **User ↔ Role (many‑to‑many)** via `AspNetUserRoles`

---

### Implementation notes
- **Decimal types on SQLite:** EF maps `decimal(10,2)` to SQLite’s numeric affinity. Price/amount rounding handled in code.
- **Status fields:** `Vehicle.Status` and `Payment.Status` are strings; if you plan enums, add conversions or constraints in the model.


## Known Issues / Future Work
- **Vehicle Image Upload**: Currently uses static images; need to implement file upload feature.
- **Booking Validation**: Improve validation logic to prevent overlapping bookings.


## Accessibility & Performance
 -	Lighthouse scores:
