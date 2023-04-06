
<p>


 What's fullstackhero's .NET Web API Boilerplate?

fullstackhero's .NET Web API Boilerplate is a starting point for your next `.NET 6 Clean Architecture Project` that incorporates the most essential packages and features your projects will ever need including out of the box Multi-Tenancy support. This project can save well over `200+ hours` of development time for your team.

> As the name suggests, this is an API / Server Boilerplate. You can find other Client Boilerplates that consume this API under `@fullstackhero` handle.
> - Find `Blazor WebAssembly Boilerplate` 

 Goals

The goal of this repository is to provide a complete and feature-rich starting point for any .NET Developer / Team to kick-start their next major project using .NET 6 Web API. This also serves the purpose of learning advanced concepts and implementations such as `Multitenancy, CQRS, Onion Architecture, Clean Coding standards` and so on.

 Features

- [x] Built on .NET 6.0
- [x] Follows Clean Architecture Principles
- [x] Domain Driven Design
- [ ] Completely Documented at [baott.net]()
- [x] Multi Tenancy Support with Finbuckle
  - [x] Create Tenants with Multi Database / Shared Database Support
  - [x] Activate / Deactivate Tenants on Demand
  - [x] Upgrade Subscription of Tenants - Add More Validity Months to each tenant!
- [x] Supports MySQL, MSSQL, Oracle & PostgreSQL!

<details>
  <summary>Click to See More!</summary>

- [x] Uses Entity Framework Core as DB Abstraction
- [x] Flexible Repository Pattern
- [x] Dapper Integration for Optimal Performance
- [x] Serilog Integration with various Sinks - File, SEQ, Kibana
- [x] OpenAPI - Supports Client Service Generation
- [x] Mapster Integration for Quicker Mapping
- [x] API Versioning
- [x] Response Caching - Distributed Caching + REDIS
- [x] Fluent Validations
- [x] Audit Logging
- [x] Advanced User & Role Based Permission Management
- [x] Code Analysis & StyleCop Integration with Rulesets
- [x] JSON Based Localization with Caching
- [x] Hangfire Support - Secured Dashboard
- [x] File Storage Service
- [x] Test Projects
- [x] JWT & Azure AD Authentication
- [x] MediatR - CQRS
- [x] SignalR Notifications
- [x] & Much More
</details>

 Documentation

Read Documentation related to this Boilerplate here - 
> Feel free to contribute to the Documentation Repository - 

 Getting Started

To get started with this Boilerplate, here are the avaiable options.

- Install using `dotnet new` . Use this for release versions of the Boilerplate only.
- Fork the Repository. Use this if you want to always keep your version of the Boilerplate up-to date with the latest changes.

> Make sure that your DEV enviroment is setup, [Read the Development Environment Guide]()

 Forking the Repository

You would probably need to take this approach if you want to keep your source code upto date with the latest changes. To get started based on this repository, you need to get a copy locally. You have three options: fork, clone, or download.

- Make a fork of this repository in your Github account.
- Create your new `dotnet-webapi-boilerplate` personal project by cloning the forked repository on your personal github.
- Setup an upstream remote on your personal project pointing to your forked repository using command `git remote add upstream https://github.com/{githubuseraccount}/dotnet-webapi-boilerplate` and `git remote set-url --push upstream DISABLE`


### Using the .NET CLI

> 0.0.1 is now released!

Open up your Command Prompt / Powershell and run the following command to install the solution template.

```powershell
dotnet new --install Architech.WebAPI.Boilerplate
```
This would install the ` .NET WebAPI Boilerplate` template globally on your machine. With that done, let's see how you can start generating complete .NET WebAPI Solutions seamlessly.

Simply navigate to a new directory (wherever you want to place your new solution), and open up Command Prompt at the opened directory.

Run the following command. Note that, in this demonstration, I am naming my new solution as `Architech.Demo`.

```powershell
dotnet new architech-web-api -o Architech.Demo
```

Contributors

Submit your PR and join the elite list!

 License

This project is licensed with the [MIT license](LICENSE).

 Support :star:

Has this Project helped you learn something New? or Helped you at work?
