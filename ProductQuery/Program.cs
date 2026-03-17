using System;
using System.Collections.Generic;
using System.Linq;

// README.md를 읽고 코드를 작성하세요.
List<Product> products = new List<Product>()
{
    new Product("Laptop", "Electronics",1200),
    new Product("Mouse", "Electronics",25),
    new Product("Keyboard", "Electronics",75),
    new Product("Shirt", "Clothing",50),
    new Product("Pants", "Clothing",100),
    new Product("Desk", "Furniture",250),
    new Product("Chair", "Furniture",150),
    new Product("Monitor", "Electronics",300),

};

Console.WriteLine("=== 문제 1: 가격 100 이상 ===");
var price = products
    .Where(n => n.Price >= 100);
foreach (var p1 in price)
{
    Console.WriteLine($"{p1.Name}");
}

Console.WriteLine("=== 문제 2: Electronics 카테고리 ===");
var Category = products
    .Where(n => n.Category == "Electronics");
foreach (var p1 in Category)
{
    Console.WriteLine($"{p1.Name}-{p1.Category}-{p1.Price}원");
}
Console.WriteLine("=== 문제 3: 이름순 정렬 ===");
var up = products
    .OrderBy(n => n.Name );
foreach (var p1 in up)
{
    Console.WriteLine($"{p1.Name}");
}
Console.WriteLine("=== 문제 4: 평균 가격 ===");
var average = products.Average();

foreach (var p1 in up)
{
    Console.WriteLine($"{p1.Name}");
}


class Product
{
    public string Name;
    public string Category;
    public int Price;

    public Product(string name, string category, int price)
    {
        Name = name;
        Category = category;
        Price = price;
    }
}






