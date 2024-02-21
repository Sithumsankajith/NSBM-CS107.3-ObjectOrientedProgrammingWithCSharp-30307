using System;

class Product
{
  
    private int productId;
    private string productName;
    private double price;
    private int quantityInStock;

    
    public Product(int productId, string productName, double price, int quantityInStock)
    {
        this.productId = productId;
        this.productName = productName;
        this.price = price;
        this.quantityInStock = quantityInStock;
    }

   
    public void AddProduct(int quantityToAdd)
    {
        quantityInStock += quantityToAdd;
        Console.WriteLine($"{quantityToAdd} {productName}(s) added to inventory.");
    }

    
    public void BuyProduct(int quantityToBuy)
    {
        if (quantityToBuy <= 0)
        {
            Console.WriteLine("Quantity to buy must be greater than zero.");
            return;
        }

        if (quantityToBuy > quantityInStock)
        {
            Console.WriteLine("Insufficient quantity in stock.");
        }
        else
        {
            quantityInStock -= quantityToBuy;
            Console.WriteLine($"{quantityToBuy} {productName}(s) bought successfully.");
        }
    }

    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product Name: {productName}");
        Console.WriteLine($"Price: ${price}");
        Console.WriteLine($"Quantity in Stock: {quantityInStock}");
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Product laptop = new Product(101, "Laptop", 800, 10);

        
        laptop.DisplayProductInfo();

        Console.ReadLine();
    }
}