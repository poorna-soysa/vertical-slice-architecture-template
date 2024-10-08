# Vertical Slice Architecture Template

This repository provides a template for building applications using the Vertical Slice Architecture with .NET 8. It includes implementations for CQRS, MediatR, global exception handling, Carter library, FluentValidation, EF Core, and the result pattern.

## Table of Contents

- [Getting Started](#getting-started)
- [Architecture Overview](#architecture-overview)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Setup](#setup)
- [Contributing](#contributing)
- [License](#license)
- [Support](#support)

## Getting Started

To get a local copy up and running, follow these simple steps.

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/poorna-soysa/vertical-slice-architecture-template.git
   ```
2. Navigate to the project directory
   ```sh
   cd vertical-slice-architecture-template
   ```
3. Restore dependencies
   ```sh
   dotnet restore
   ```

## Architecture Overview

This template follows the Vertical Slice Architecture, which organizes code by features rather than technical concerns. Each feature is self-contained, promoting high cohesion and low coupling.

## Features

- **CQRS**: Command and Query Responsibility Segregation.
- **MediatR Library**: Implements the mediator pattern for handling requests and notifications.
- **Global Exception Handling**: Centralized handling of exceptions.
- **Carter Library**: Lightweight library for building HTTP APIs.
- **FluentValidation Library**: Validation library for .NET.
- **Entity Framework Core**: Object-relational mapper for .NET.
- **Result Pattern**: Standardized way of handling operation results.
- **Health Checks**:  standardized approach for monitoring and assessing the operational status of systems.

## Technologies Used

- **.NET 8**
- **CQRS**
- **MediatR**
- **Carter Library**
- **FluentValidation**
- **EF Core**
- **HealthChecks Library**

## Setup

1. Configure your database connection string in `appsettings.json`.
2. Run the application
   ```sh
   dotnet run
   ```

## Contributing

Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

Distributed under the MIT License. See `LICENSE` for more information.

## Support

If you find this project helpful, consider buying me a coffee!

[![Buy Me a Coffee](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/poorna.soysa)
```
