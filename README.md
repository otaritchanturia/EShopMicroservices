
# 🚀 EShopMicroservices

A modern **microservices-based e-commerce system** built with **.NET 8**, demonstrating real-world architecture patterns such as **DDD, CQRS, Vertical Slice Architecture, and Event-Driven Communication**.

This project showcases how to design scalable, maintainable, and production-ready distributed systems using industry-standard tools and practices.

---

## 📌 Overview

This solution is composed of multiple independent microservices, each responsible for a specific business domain:

- **Catalog Service** – manages products  
- **Basket Service** – handles shopping carts  
- **Discount Service (gRPC)** – calculates discounts  
- **Ordering Service** – processes orders  
- **API Gateway (YARP)** – single entry point for clients  

### Communication

- **Synchronous** → REST / gRPC  
- **Asynchronous** → RabbitMQ (Event-Driven)

---

## 🧱 Architecture

The system follows modern architectural principles:

- Microservices Architecture  
- Domain-Driven Design (DDD)  
- CQRS (Command Query Responsibility Segregation)  
- Vertical Slice Architecture  
- Clean Architecture (for Ordering Service)  

---

## 🛠️ Tech Stack

### Backend
- .NET 8 / ASP.NET Core  
- Minimal APIs + Carter  
- MediatR  
- FluentValidation  
- Mapster / AutoMapper  

### Databases
- PostgreSQL (Marten - document DB)  
- SQL Server (EF Core)  
- Redis (Distributed Cache)  
- SQLite (Discount Service)  

### Infrastructure
- RabbitMQ + MassTransit  
- YARP API Gateway  
- Docker & Docker Compose  

---

## 📦 Microservices

### Catalog.API
- Vertical Slice Architecture  
- PostgreSQL + Marten  

### Basket.API
- Redis caching (Cache-Aside pattern)  
- Decorator pattern for caching  
- Publishes checkout events  

### Discount.Grpc
- gRPC service  
- SQLite database  

### Ordering.API
- Clean Architecture + DDD  
- Handles domain & integration events  
- SQL Server + EF Core  

### API Gateway (YARP)
- Routes requests to services  
- Handles cross-cutting concerns  

---

## 🔁 Event Flow (Checkout)

1. User checks out basket  
2. Basket publishes checkout event  
3. Event goes to RabbitMQ  
4. Ordering service consumes event  
5. Order is created  
6. Basket is cleared  

---

## ⚙️ Running the Project

### Prerequisites
- Docker Desktop  
- .NET 8 SDK  

### Run

```bash
git clone https://github.com/otaritchanturia/EShopMicroservices.git
cd EShopMicroservices
docker-compose up --build
