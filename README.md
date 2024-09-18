## Features

- **Product Listing:** Browse through a list of available products with details like name, description, price, and image.
- **Add to Cart:** Easily add products to your shopping cart with a single click.
- **View Cart:** View all items in your cart, update quantities, or remove items.
- **Stateless Architecture:** Cart data is managed entirely on the client-side using cookies, ensuring the server remains stateless.
- **Reusable UI Components:** Utilizes View Components for modular and reusable UI elements.

## Technology Stack

- **ASP.NET Core MVC**
- **C#**
- **View Components**
- **Cookies** for cart management
- **Newtonsoft.Json** for JSON serialization/deserialization
- **Bootstrap 4** for styling

## Getting Started

Follow these instructions to set up and run the project on your local machine.

### Prerequisites

- **.NET 7.0 SDK** or later installed on your machine. You can download it from the [.NET website](https://dotnet.microsoft.com/download).
- **Visual Studio 2022** or any other preferred IDE/text editor.
- **Git** (optional, for version control).

### Installation

1. **Clone the Repository**

   ```bash
   git clone https://github.com/kinarajv/SimpleShoppingCartViewComponents.git
   cd SimpleShoppingCartViewComponents
   ```

2. **Restore Dependencies**

   Navigate to the project directory and restore the necessary packages.

   ```bash
   dotnet restore
   ```

3. **Build the Project**

   Ensure that the project builds successfully.

   ```bash
   dotnet build
   ```

4. **Run the Project**

   Start the application.

   ```bash
   dotnet run
   ```

5. **Access the Application**

   Open your web browser and navigate to `https://localhost:5001` (or the URL specified in the console) to access the application.

## Usage

1. **Browse Products**

   - Navigate to the **Products** page to view the available products.
   - Each product displays its image, name, description, and price.

2. **Add Products to Cart**

   - Click the **"Add to Cart"** button on any product to add it to your shopping cart.
   - The Shopping Cart button in the navigation bar will update to show the number of items and the total price.

3. **View Shopping Cart**

   - Click on the **Shopping Cart** button/link in the navigation bar to view your cart.
   - The **Your Shopping Cart** page displays all items, their quantities, individual prices, and the total amount.

4. **Manage Cart Items**

   - **Update Quantity:** Change the quantity of any item and click **"Update"** to adjust the total.
   - **Remove Item:** Click the **"Remove"** button to delete an item from your cart.

5. **Continue Shopping**

   - After managing your cart, click **"Continue Shopping"** to return to the Products page and add more items.

## Project Structure

- **Controllers/**
  - `ProductsController.cs` – Handles product listing and adding items to the cart.
  - `CartController.cs` – Manages cart viewing, updating, and removing items.
  
- **Models/**
  - `Product.cs` – Represents a product.
  - `CartItem.cs` – Represents an item in the cart.
  - `ShoppingCartViewModel.cs` – View model for the Shopping Cart View Component.
  - `CartViewModel.cs` – View model for the Cart view.
  
- **Services/**
  - `IProductService.cs` & `ProductService.cs` – Service for managing products.
  - `ICartService.cs` & `CartService.cs` – Service for managing the shopping cart using cookies.
  
- **ViewComponents/**
  - `ShoppingCartViewComponent.cs` – View Component for displaying cart summary in the navigation bar.
  
- **Views/**
  - **Products/**
    - `Index.cshtml` – Displays the list of products.
  - **Cart/**
    - `Index.cshtml` – Displays the shopping cart details.
  - **Shared/Components/ShoppingCart/**
    - `Default.cshtml` – View for the Shopping Cart View Component.
  - **Shared/**
    - `_Layout.cshtml` – Main layout file integrating the Shopping Cart View Component.
  
- **wwwroot/**
  - **css/**
    - `site.css` – Custom styles.
  - **images/**
    - Sample product images.
  
- **Program.cs** – Configures services and middleware.

## Security Considerations

- **HttpOnly Cookies:** The cart data is stored in HttpOnly cookies to prevent client-side scripts from accessing them.
- **Data Integrity:** While the cart data is serialized to JSON, consider encrypting or signing the cookie data in production to prevent tampering.
- **Cookie Expiration:** The cart cookie is set to expire after 7 days. Adjust this as needed based on your requirements.

## Contributing

Contributions are welcome! If you'd like to improve this project, please follow these steps:

1. **Fork the Repository**

2. **Create a Feature Branch**

   ```bash
   git checkout -b feature/YourFeature
   ```

3. **Commit Your Changes**

   ```bash
   git commit -m "Add your feature"
   ```

4. **Push to the Branch**

   ```bash
   git push origin feature/YourFeature
   ```

5. **Open a Pull Request**

## License

This project is licensed under the [MIT License](LICENSE).

---

Thank you for checking out **ShoppingCartSample**! If you have any questions or need further assistance, feel free to reach out.
