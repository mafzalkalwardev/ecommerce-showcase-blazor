# E-Commerce Showcase (Blazor Server)

Simple e-commerce demo built with **ASP.NET Core 7 Blazor Server** — product catalog, order modal, in-memory order storage, and order history.

## Features

- Product grid with Bootstrap 5 cards
- Order form modal with validation
- In-memory `ProductService`, `OrderService`, and `CustomerService`
- Order confirmation and order history pages
- Unsplash product images (no local assets required)

## Tech Stack

- .NET 7
- Blazor Server
- Bootstrap 5.3 (CDN)
- In-memory services (no database)

## Architecture

```mermaid
flowchart TB
    subgraph ui [Blazor Pages]
        Index["Index.razor /"]
        Orders["Orders.razor /orders"]
        OrderConfirmed["OrderConfirmed.razor"]
    end

    subgraph services [Data Services]
        ProductService
        OrderService
        CustomerService
    end

    subgraph models [Models]
        Product
        Order
        Customer
    end

    Index --> ProductService
    Index --> OrderService
    Index --> CustomerService
    Orders --> OrderService
    ProductService --> Product
    OrderService --> Order
    CustomerService --> Customer
```

## Pages

| Route | Page | Description |
|-------|------|-------------|
| `/` | Index | Product showcase and order modal |
| `/products` | Product | Alternate product listing |
| `/orders` | Orders | Order history table |
| `/orderconfirmed` | OrderConfirmed | Success message after checkout |

## Run Locally

Requires [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0).

```powershell
cd ECommerceShowcase
dotnet restore
dotnet run
```

Open `https://localhost:5001` (or the URL shown in the terminal).

## Project Structure

```
ECommerceShowcase/
├── Data/           # ProductService, OrderService, CustomerService
├── Models/         # Product, Order, Customer
├── Pages/          # Blazor pages
├── Shared/         # Layout components
├── wwwroot/        # Static CSS
└── Program.cs      # DI and middleware
```

## Author

Muhammad Afzal Kalwar — [GitHub](https://github.com/mafzalkalwardev)

## License

MIT — see [LICENSE](LICENSE).
