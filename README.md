🤖Merchant Manager API
----------------------------
This project is a .NET 8 Web API designed for managing merchants with CRUD operations. It includes features like user authentication, custom authorization, global exception handling, logging, and validation. This API is built using ASP.NET Core and incorporates best practices such as Dependency Injection, SOLID principles, and RESTful design.

✨Features
-----------------
• User Authentication: A fake user authentication system using tokens for login validation.

• Authorization: Custom authorization attribute to ensure only authorized users can access protected endpoints.

• Global Exception Handling: Middleware to handle exceptions globally and return user-friendly error messages.

• CRUD Operations: Create, Read, Update, and Delete operations for managing merchants.

• Validation: FluentValidation for input validation of API requests.

• Logging: Request logging middleware to log API requests and responses.

• Swagger: Integrated Swagger UI for easy API documentation and testing.

🖥️Technologies Used
-----------------
• .NET 8 Web API

• C#

• ASP.NET Core Middleware

• FluentValidation

• Swagger for API documentation

🚩API Endpoints
-----------------
The API uses a fake authentication system where users are identified by predefined static tokens passed in the request headers.

🔍Valid Tokens:

• Admin: admin-token

• User: user-token

📍 Merchant Management
-----------------
The API provides CRUD operations for managing merchants.

Endpoints:

| HTTP Method | Endpoint | Description |
|------------|---------|-------------|
| **GET** | `/api/MerchantInformation/GetAll` | Get all merchants |
| **GET** | `/api/MerchantInformation/GetbyId/{id}` | Get a specific merchant by ID |
| **POST** | `/api/MerchantInformation/Post` | Create a new merchant |
| **PUT** | `/api/MerchantInformation/{id}` | Update a merchant completely by ID |
| **DELETE** | `/api/MerchantInformation/{id}` | Delete a merchant by ID |

🎯 Code Overview
-----------------

⚙️ Fake User Authentication
------------------
The authentication service uses fake tokens to simulate a basic login system, where tokens are manually checked against the headers in the request.

📚 Custom Authorization Attribute
-------
The FakeAuthorizeAttribute is a custom action filter that validates the request header for a valid token before allowing access to the protected endpoints.


🛠️ Global Exception Handling & Logging Middleware
----------
Global exception handling ensures that any unexpected errors are caught and logged, and a user-friendly error message is returned to the client.
Request logging middleware captures all incoming requests for monitoring and debugging purposes.

✅ Swagger
---------------
Swagger UI provides an interactive interface for testing API endpoints. You can explore and test all the available endpoints directly from the Swagger UI.
 
📚 Additional Notes
---------------------
Authorization Header: Use the X-Fake-Auth header with valid tokens (admin-token or user-token) for accessing protected endpoints.
Error Handling: Any unhandled exceptions will be caught by the global exception middleware and logged.
Testing: Use Swagger or Postman to test all available endpoints.
