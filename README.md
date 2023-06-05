# MicroServicesProject

### Catalog Microservice
Our microservice responsible for storing and presenting information about our courses.
<br>
• MongoDB (Database) <br>
• One-To-Many/One-To-One relationship<br>

<img src="./docs/catalog-swagger.png">
<img src="./docs/catalogapi-test.gif">

### Basket Microservice
Our microservice responsible for managing the shopping cart.<br>
• RedisDB (Database)

### Discount Microservice
Our microservice responsible for managing discount coupons assigned to users.<br>
• PostgreSQL (Database)<br>
• Dapper (Micro ORM)<br>

<img src="./docs/discount/ss1.png">
<img src="./docs/discount/ss2.png">
<img src="./docs/discount/ss3.png">
<img src="./docs/discount/ss4.png">
<img src="./docs/discount/ss5.png">
<img src="./docs/discount/ss6.png">


### Order Microservice
Our microservice responsible for managing orders.<br>
We developed this microservice using the Domain Driven Design approach.<br>
We used the MediatR library to implement the CQRS design pattern in this microservice.<br>
• SQL Server (Database)<br>
• Domain Driven Design<br>
• CQRS (MediatR Library)<br>

### FakePayment Microservice
Our microservice responsible for handling payments.<br>

### IdentityServer Microservice
• SQL Server (Database)<br>
Our microservice responsible for managing user data, generating access tokens and refresh tokens.<br>

### PhotoStock Microservice
Our microservice responsible for storing and presenting course photos.<br>

<img src="./docs/save-photo-with-token.png">

### API Gateway
• Ocelot Library<br>

### Message Broker
• We used RabbitMQ as our message queue system.<br>
• We used the MassTransit library to communicate with RabbitMQ.<br>
• RabbitMQ (MassTransit Library)<br>

### Identity Server
• Generating tokens and refresh tokens<br>
• Protecting our microservices with access tokens<br>
• Building a structure that complies with OAuth 2.0 / OpenID Connect protocols.<br>

<img src="./docs/identity-token-postman.png">
