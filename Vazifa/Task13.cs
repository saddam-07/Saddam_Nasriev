using System;
using System.Collections.Generic;
class Task13
{
    public static void Run()
    {
        Product product = new Product("Book", 100m, 20);
        ProductInfo prInfo = new ProductInfo("IBT", 5.5, "IT");
        Order order = new Order();
        order.Status = (OrderStatus)1;
        product.PrintInfo();
        prInfo.Print();
        order.PrintStatus();
    }
}