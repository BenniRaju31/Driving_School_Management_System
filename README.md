## Driving School Management system (Project Execution instructions)

## Overview
This project is a .NET application built in C# that utilizes a MySQL database. It serves as a platform for managing driving school operations.

## Installation

### Prerequisites
- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/) or [XAMPP](https://www.apachefriends.org/index.html) with PHPMyAdmin

### Setup
1. Clone the repository to your local machine:

    ```bash
    git clone https://github.com/yourusername/projectname.git
    ```

2. Import the database into MySQL Server or XAMPP PHPMyAdmin:
    - Open your MySQL Server or XAMPP control panel.
    - Start the MySQL Server and Apache Server.
    - Access PHPMyAdmin via your web browser (typically at `http://localhost/phpmyadmin`).
    - Create a new database named `ITDrivingSchool`.
    - Import the database file provided (`database.sql`) into the `ITDrivingSchool` database.

### Configuration
In the project's source code, locate the `app.config` or `web.config` file and update the database connection settings:

```xml
<connectionStrings>
    <add name="MyConnectionString" connectionString="server=localhost;database=ITDrivingSchool;uid=root;password=;" providerName="MySql.Data.MySqlClient" />
</connectionStrings>
```

Make sure to replace `server`, `database`, `uid`, and `password` with your MySQL server configuration.

## Usage
After completing the installation and configuration steps, you can run the application using Visual Studio or by compiling and executing the `.cs` files.

## Credentials
Here are the default credentials for connecting to the MySQL database:

- **Server:** localhost
- **Database:** ITDrivingSchool
- **User ID:** root
- **Password:** (Leave it blank)


## Contributing
If you'd like to contribute to this project, feel free to fork the repository and submit a pull request. We welcome any suggestions, bug fixes, or enhancements.

