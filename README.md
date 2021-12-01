# Clean Architecture
A solution template that can be used to build Domain-Driven Design (DDD)-based or simply well-factored, SOLID applications using ASP.NET Core.

# Fenin.Infrastructure
This project encapsulates access to infrastructure, such as SQL database, Storages, Services Email etc. 

# Fenin.Application
CRUD-services: implement simple CRUD-operations on entities/resources
Use cases: implements specific use cases with CQRS-pattern (which often affect changes on multiple database entities)
Validations, Services

# Fenin.Core
This project holds all domain relevant interfaces, wich are then implemented in application and infrastructure project.

# Fenin.Web
This project has REST API and ASP.NET core web aplication.
