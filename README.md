# Hospital System (HS-System)

A comprehensive C# desktop application for managing hospital operations, including patient records, appointments, medical inventory, and more.

## 📋 Overview

HS-System is a multi-layered hospital management application built with C# that provides functionality for managing medical services, staff, patients, and inventory in a hospital environment.

Some Images from the app 
--
![DESKTOP-IK9MONC RetainCarsProject - Diagram_Base_ - Microsoft SQL Server Management Studio 16_09_2024 05_54_02 م](https://github.com/user-attachments/assets/99bbee11-7b99-45df-8bb9-1f175c2cda31)


![Login 02_10_2024 07_44_23 م](https://github.com/user-attachments/assets/0db28f7b-77f9-4ea2-920d-2ceeffc1fcbd)

![BookANewLapTest 02_10_2024 07_47_44 م](https://github.com/user-attachments/assets/ddc9822c-49d3-4695-a1d8-194cbdb6e800)

![ListOfMedicalsInStorage 02_10_2024 07_47_17 م](https://github.com/user-attachments/assets/574bd35e-ece0-4f23-9285-c363fe96a123)

## 🏗️ Architecture

The project follows a layered architecture pattern:

- **HospitalSys** - Main application/presentation layer with UI components
- **clsBusineesLayer** - Business logic and service layer
- **DataAccessLayer** - Database access and data operations
- **SecurityLayer** - Authentication and authorization
- **DataBase Backup** - Database backup and recovery files


## ✨ Features

Based on the UI screenshots, the system includes:

- **User Authentication** - Secure login system
- **Patient Management** - Patient record creation and management
- **Appointment Booking** - Schedule new medical appointments
- **Medical Inventory** - Track and manage medical supplies and medications
- **Database Management** - Centralized data storage and retrieval

## 📁 Project Structure

```
HS-System/
├── HospitalSys/              # Main application UI
├── clsBusineesLayer/         # Business logic
├── DataAccessLayer/          # Database operations
├── SecurityLayer/            # Authentication & security
└── DataBase Backup/          # Database backup files
```

## 🔧 Technology Stack

- **Language:** C#
- **Framework:** .NET (version as per project configuration)
- **Database:** SQL Server
- **UI:** Windows Forms (or WPF, depending on implementation)

## 📝 Configuration

### App.config File

Update the following configuration settings in `App.config`:

1. **Database Connection String** - Update server name, database name, and credentials
2. **Security Settings** - Configure authentication parameters
3. **Application Settings** - Set application-specific configurations

## 🔒 Security

The SecurityLayer provides:

- User authentication and authorization
- Secure credential handling
- Session management

**Note:** Default credentials should be changed in production environments.

## 📂 Database

The database includes tables for:

- Users and authentication
- Patients and medical records
- Appointments and schedules
- Medical inventory and supplies
- Staff and department information

## ⚠️ Troubleshooting

### Common Issues

1. **Database Connection Errors**
   - Verify SQL Server is running
   - Check connection string in App.config
   - Ensure database is properly restored

2. **Login Issues**
   - Verify default credentials (Admin/1234)
   - Check user registry in the database
   - Clear application cache and retry

3. **Configuration Problems**
   - Review the App.config file for correct syntax
   - Ensure all required settings are present
   - Check Windows Registry for application configurations

## 📞 Support

If you encounter any issues:

- Check the database connection and configuration
- Verify all required files are present
- Review the application event logs
- Contact the project maintainer

## 📄 License

Please refer to the repository for license information.

## 👤 Author

**Amro-Aladghem**

---



## 🚀 Getting Started

### Prerequisites

- .NET Framework or .NET Core (version dependent on project setup)
- SQL Server (for database)
- Visual Studio or compatible C# IDE

### Installation

1. **Download the Repository**
   - Clone or download the ZIP file from the repository

2. **Restore the Database**
   - A database backup is included in the `DataBase Backup` folder
   - Restore it to your SQL Server instance using SQL Server Management Studio

3. **Configure Database Connection**
   - Open the `App.config` file in the HospitalSys project
   - Update the connection string with your SQL Server information
   - Example:
     ```xml
     <connectionStrings>
       <add name="HospitalConnection" 
            connectionString="Server=YOUR_SERVER;Database=HospitalDB;User Id=sa;Password=YOUR_PASSWORD;" />
     </connectionStrings>
     ```

4. **Default Credentials**
   - Username: `Admin`
   - Password: `1234`

5. **Build and Run**
   - Open the solution in Visual Studio
   - Build the solution
   - Run the HospitalSys application





--If you have any Problem you can check you Registry Or You can contact with me :-)
