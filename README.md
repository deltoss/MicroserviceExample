# MicroserviceExample

.Net & Typescript Microservice Example

- [Problem Domain](#problem-domain)
- [Roadmap](#roadmap)
  - [Origin](#origin)
  - [Alpha](#alpha)
  - [Beta](#beta)
  - [Gamma](#gamma)

## Problem Domain

The company founders has a collection of rich Markdown files throughout their development career. The idea is to provide services to manage, search & download Markdown files. Lets call this application **Marktopia**.

We need to make **Marktopia** scalable, so we're building it as a Microservice API. We need to support the following functionalities:

Service Name | Description
--- | ---
**Catalog Service** | This microservice will be responsible for managing the list of available Markdowns, including their titles, authors, and other relevant details. It will provide APIs for adding, updating, and deleting Markdowns from the catalog, as well as searching for Markdowns based on various criteria.
**Pricing Service** | This microservice will manage the pricing information for the Markdown documents. It will store the cost and selling price for each Markdown document and provide APIs to update prices as needed.
**Order Processing Service** | This microservice will be responsible for processing customer orders. including creating new orders, payment processing, updating order status, and sending notifications to users. It will interact with the pricing services to check the price of the Markdown documents.
**Shopping Cart Service** | This microservice would manage the shopping cart functionality, including adding and removing items, calculating totals, and handling checkout.
**Authentication and Authorization Service** | This microservice would handle user login and authentication, as well as authorization for accessing different parts of the application.

## Roadmap

### Origin

- [ ] Define problem domain.
- [ ] Defining entities & microservice context boundaries.
- [ ] Implementing first microservice with .Net
  - Database-per-service pattern.
  - Find & use design patterns.
    - CQRS
    - Mediator
- [ ] Docker
- [ ] Event Bus (RabbitMQ)
- [ ] Implement at 2+ microservices with .Net.
- [ ] Unit Tests
- [ ] Event-Driven Architecture.
- [ ] CI
  - GitHub actions is free for public repos.
- [ ] Integration Tests

### Alpha

- [ ] Authentication.
- [ ] Saga pattern.
- [ ] Test Driven Development.
- [ ] CD & Hosting
- [ ] Secrets Management
  - Github actions may have secret management in-built.
- [ ] Functional Tests
  - Send HTTP requests to Microservices.
  - Tools:
    - Postman
    - Jest

### Beta

- SPA Frontend
  - React
  - NextJS
- Microfrontend
  - Meta Frameworks

### Gamma

- [ ] Monitoring & Alerts.
  - E.g. Prometheus
- [ ] Add typescript microservice.
- [ ] Microservice Orchestration
  - Workflow engines
  - Event based approach
