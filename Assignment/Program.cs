using static Assignment.Program;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>
{
                new Order { OrderID = 1, Customer = "Ahmed",   OrderDate = new DateTime(1996, 5, 12), Total = 450.00m },
                new Order { OrderID = 2, Customer = "Hany",    OrderDate = new DateTime(1998, 1, 20), Total = 1200.00m },
                new Order { OrderID = 3, Customer = "Omar",    OrderDate = new DateTime(1999, 3, 15), Total = 300.00m },
                new Order { OrderID = 4, Customer = "Mona",    OrderDate = new DateTime(2000, 7, 8),  Total = 499.99m },
                new Order { OrderID = 5, Customer = "Sara",    OrderDate = new DateTime(1997, 2, 3),  Total = 800.00m },
                new Order { OrderID = 6, Customer = "Ali",     OrderDate = new DateTime(1998, 11, 11),Total = 50.00m },
                new Order { OrderID = 7, Customer = "Nour",    OrderDate = new DateTime(1995, 9, 28), Total = 2000.00m },
                new Order { OrderID = 8, Customer = "Mostafa", OrderDate = new DateTime(1999, 12, 1), Total = 230.00m }
            };
            #region LINQ - Aggregate Operators

            // 1. Uses Count to get the number of odd numbers in the array
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int oddCount = Arr.Count(n => n % 2 != 0);

            // 2. Return a list of customers and how many orders each has.
             List<Customer> customers = new List<Customer>
{
                    new Customer
                    {
                        Name = "Ahmed",
                        City = "Cairo",
                        State = "WA",
                        Orders = new List<Order>
                        {
                            new Order { OrderID = 101, Customer = "Ahmed",  OrderDate = new DateTime(1997, 3, 12), Total = 250.00m },
                            new Order { OrderID = 102, Customer = "Ahmed",  OrderDate = new DateTime(1999, 5, 20), Total = 1400.00m }
                        }
                    },

                    new Customer
                    {
                        Name = "Sara",
                        City = "Giza",
                        State = "CA",
                        Orders = new List<Order>
                        {
                            new Order { OrderID = 103, Customer = "Sara", OrderDate = new DateTime(1998, 7, 10), Total = 350.00m },
                            new Order { OrderID = 104, Customer = "Sara", OrderDate = new DateTime(2000, 1, 2), Total = 780.00m },
                            new Order { OrderID = 105, Customer = "Sara", OrderDate = new DateTime(1996, 11, 9), Total = 120.00m }
                        }
                    },

                    new Customer
                    {
                        Name = "Omar",
                        City = "Alex",
                        State = "WA",
                        Orders = new List<Order>
                        {
                            new Order { OrderID = 106, Customer = "Omar", OrderDate = new DateTime(1995, 9, 8), Total = 2000.00m }
                        }
                    },

                    new Customer
                    {
                        Name = "Mona",
                        City = "Mansoura",
                        State = "FL",
                        Orders = new List<Order>
                        {
                            new Order { OrderID = 107, Customer = "Mona", OrderDate = new DateTime(2000, 4, 15), Total = 499.99m }
                        }
                    },

                    new Customer
                    {
                        Name = "Ali",
                        City = "Cairo",
                        State = "NY",
                        Orders = new List<Order>
                        {
                            new Order { OrderID = 108, Customer = "Ali", OrderDate = new DateTime(1998, 11, 11), Total = 80.00m },
                            new Order { OrderID = 109, Customer = "Ali", OrderDate = new DateTime(1999, 12, 2), Total = 600.00m }
                        }
                    }
                };

                    var customerOrderCount =
                            customers.Select(c => new
                            {
                                c.Name,
                                OrderCount = c.Orders.Count
                            });

            // 3. Return a list of categories and how many products each has
            List<Product> products = new List<Product>()
            {
                new Product { ProductID = 1, Name = "Apple", Category = "Fruits", UnitPrice = 3.50m, UnitsInStock = 10 },
                new Product { ProductID = 2, Name = "Blueberry", Category = "Fruits", UnitPrice = 5.00m, UnitsInStock = 0 },
                new Product { ProductID = 3, Name = "Cherry", Category = "Fruits", UnitPrice = 4.00m, UnitsInStock = 25 },
                new Product { ProductID = 4, Name = "Banana", Category = "Fruits", UnitPrice = 2.00m, UnitsInStock = 100 },
                new Product { ProductID = 5, Name = "Tomato", Category = "Vegetables", UnitPrice = 1.50m, UnitsInStock = 0 },
                new Product { ProductID = 6, Name = "Potato", Category = "Vegetables", UnitPrice = 1.00m, UnitsInStock = 200 },
                new Product { ProductID = 7, Name = "Cucumber", Category = "Vegetables", UnitPrice = 2.20m, UnitsInStock = 40 },
                new Product { ProductID = 8, Name = "Milk", Category = "Dairy", UnitPrice = 12.00m, UnitsInStock = 5 },
                new Product { ProductID = 9, Name = "Cheese", Category = "Dairy", UnitPrice = 30.00m, UnitsInStock = 15 },
                new Product { ProductID = 10, Name = "Yogurt", Category = "Dairy", UnitPrice = 8.00m, UnitsInStock = 0 }
            };

            var categoryCount =
                products.GroupBy(p => p.Category)
                        .Select(g => new { Category = g.Key, Count = g.Count() });


            // 4. Get the total of the numbers in an array.
            int total = Arr.Sum();
            #endregion
        }
    }
}
